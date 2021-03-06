﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Microsoft.Graph.Test.Requests.Functional
{
    [Ignore]
    [TestClass]
    public class OneDriveTests : GraphTestBase
    {
        // https://github.com/OneDrive/onedrive-sdk-csharp/blob/master/docs/chunked-uploads.md
        // https://dev.onedrive.com/items/upload_large_files.htm
        [TestMethod]
        public async Task OneDriveUploadLargeFile()
        {
            try
            {
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                var buff = (byte[])converter.ConvertTo(Microsoft.Graph.Test.Properties.Resources.hamilton, typeof(byte[]));
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
                {
                    // Describe the file to upload. Pass into CreateUploadSession, when the service works as expected.
                    var props = new DriveItemUploadableProperties();
                    //props.Name = "_hamilton.png";
                    //props.Description = "This is a pictureof Mr. Hamilton.";
                    //props.FileSystemInfo = new FileSystemInfo();
                    //props.FileSystemInfo.CreatedDateTime = System.DateTimeOffset.Now;
                    //props.FileSystemInfo.LastModifiedDateTime = System.DateTimeOffset.Now;
                    props.AdditionalData = new Dictionary<string, object>();
                    props.AdditionalData.Add("@microsoft.graph.conflictBehavior", "rename");

                    // Get the provider. 
                    // POST /v1.0/drive/items/01KGPRHTV6Y2GOVW7725BZO354PWSELRRZ:/_hamiltion.png:/microsoft.graph.createUploadSession
                    // The CreateUploadSesssion action doesn't seem to support the options stated in the metadata. This issue has been filed.
                    var uploadSession = await graphClient.Drive.Items["01KGPRHTV6Y2GOVW7725BZO354PWSELRRZ"].ItemWithPath("_hamilton.png").CreateUploadSession().Request().PostAsync();

                    var maxChunkSize = 320 * 1024; // 320 KB - Change this to your chunk size. 5MB is the default.
                    var provider = new ChunkedUploadProvider(uploadSession, graphClient, ms, maxChunkSize);

                    // Setup the chunk request necessities
                    var chunkRequests = provider.GetUploadChunkRequests();
                    var readBuffer = new byte[maxChunkSize];
                    var trackedExceptions = new List<Exception>();
                    DriveItem itemResult = null;

                    //upload the chunks
                    foreach (var request in chunkRequests)
                    {
                        // Do your updates here: update progress bar, etc.
                        // ...
                        // Send chunk request
                        var result = await provider.GetChunkRequestResponseAsync(request, readBuffer, trackedExceptions);

                        if (result.UploadSucceeded)
                        {
                            itemResult = result.ItemResponse;
                        }
                    }

                    // Check that upload succeeded
                    if (itemResult == null)
                    {
                        // Retry the upload
                        // ...
                    }
                }
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }


        [TestMethod]
        public async Task OneDriveNextPageRequest()
        {
            try
            {
                var driveItems = new List<DriveItem>();

                var driveItemsPage = await graphClient.Me.Drive.Root.Children.Request().Top(4).GetAsync();

                Assert.IsNotNull(driveItemsPage, "Expected that a page of OneDrive items is deserialized into an object.");

                driveItems.AddRange(driveItemsPage.CurrentPage);

                while (driveItemsPage.NextPageRequest != null)
                {
                    driveItemsPage = await driveItemsPage.NextPageRequest.GetAsync();
                    driveItems.AddRange(driveItemsPage.CurrentPage);
                }
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        // Addressing https://github.com/microsoftgraph/MSGraph-SDK-Code-Generator/issues/71
        //[TestMethod]
        //public async Task OneDriveNextPageRequestRootItemWithPath()
        //{
        //    try
        //    {
        //        // This calls contains the correct URL structure: 
        //        var path = "Community Service";
        //        var driveItemsPage = await graphClient.Me.Drive.Root.ItemWithPath(path).Children.Request().Top(1).GetAsync(); // DriveItemChildrenCollectionRequest.GetAsync()
        //        // https://graph.microsoft.com/v1.0/me/drive/root:/Community%20Service:/children?$top=1
        //        // BUG: the nextLink returned by the service is incorrect.

        //        // Assert that path is being added to the request URL.
        //        StringAssert.Contains(driveItemsPage.NextPageRequest.RequestUrl, path, $"The path, '{path}' was not appended to the request URL.");

        //        // This call does not issue the correct URL. Notice that ":/Community%20Service:" segment is missing.
        //        driveItemsPage = await driveItemsPage.NextPageRequest.GetAsync();
        //        // Actual nextLink value used to populate the NextPageRequest URL
        //        // https://graph.microsoft.com/v1.0/me/drive/root/children?$top=1&$skiptoken=Paged%3dTRUE%26p_SortBehavior%3d0%26p_FileRef%3dpersonal%252fgarthf%255fmod810997%255fonmicrosoft%255fcom%252fDocuments%252fCommunity%2520Service%252fBook%252exlsx%26p_ID%3d390%26RootFolder%3d%252fpersonal%252fgarthf%255fmod810997%255fonmicrosoft%255fcom%252fDocuments%252fCommunity%2520Service
        //        // Expected nextLink value used to populate the NextPageRequest URL
        //        // https://graph.microsoft.com/v1.0/me/drive/root:/Community%20Service:/children?$top=1&$skiptoken=Paged%3dTRUE%26p_SortBehavior%3d0%26p_FileRef%3dpersonal%252fgarthf%255fmod810997%255fonmicrosoft%255fcom%252fDocuments%252fCommunity%2520Service%252fBook%252exlsx%26p_ID%3d390%26RootFolder%3d%252fpersonal%252fgarthf%255fmod810997%255fonmicrosoft%255fcom%252fDocuments%252fCommunity%2520Service
        //    }
        //    catch (Microsoft.Graph.ServiceException e)
        //    {
        //        Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
        //    }
        //}

        // http://graph.microsoft.io/en-us/docs/api-reference/v1.0/api/item_downloadcontent
        [TestMethod]
        public async Task OneDriveGetContent()
        {
            try
            {
                var driveItems = await graphClient.Me.Drive.Root.Children.Request().GetAsync();

                foreach (var item in driveItems)
                {
                    // Let's download the first file we get in the response.
                    if (item.File != null)
                    {
                        var driveItemContent = await graphClient.Me.Drive.Items[item.Id].Content.Request().GetAsync();
                        Assert.IsNotNull(driveItemContent, "Expected to find a file.");
                        Assert.IsInstanceOfType(driveItemContent, typeof(Stream));
                        return;
                    }
                }
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }


        [TestMethod]
        public async Task OneDriveGetSetPermissions()
        {
            try
            {
                var driveItems = await graphClient.Me.Drive
                                                     .Root
                                                     .Children
                                                     .Request()
                                                     .GetAsync();

                foreach (var item in driveItems)
                {
                    // Let's get the first file in the response and expand the permissions set on it.
                    if (item.File != null)
                    {
                        // Get the permissions on the first file in the response.
                        var driveItem = await graphClient.Me.Drive
                                                            .Items[item.Id]
                                                            .Request()
                                                            .Expand("permissions")
                                                            .GetAsync();
                        Assert.IsNotNull(driveItem, "Expected to find a file.");

                        // Set permissions
                        var perm = new Permission();
                        perm.Roles = new List<string>() { "write"};
                        if (driveItem.Permissions.Count > 0)
                        {
                            var headerOptions = new List<HeaderOption>()
                            {
                                new HeaderOption("if-match", driveItem.CTag)
                            };

                            var permission = await graphClient.Me.Drive
                                                                 .Items[driveItem.Id]
                                                                 .Permissions[driveItem.Permissions[0].Id]
                                                                 .Request(headerOptions)
                                                                 .UpdateAsync(perm);
                        }
                        break;
                    }
                }
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        [TestMethod]
        public async Task OneDriveSearchFile()
        {
            // Note: can't upload an item and immediately search for it. Seems like search index doesn't get immediately updated.
            // Tried applying a delay of 30sec and it made no difference.
            try
            {
                // http://graph.microsoft.io/en-us/docs/api-reference/v1.0/api/item_search
                var driveItems = await graphClient.Me.Drive.Search("employee services").Request().GetAsync();

                // Expecting two results.
                Assert.AreEqual(2, driveItems.Count, "Expected 2 search results.");
                
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        // Assumption: test tenant has a file name that starts with 'Timesheet'.
        [TestMethod]
        public async Task OneDriveCreateSharingLink()
        {
            try
            {
                var itemToShare = await graphClient.Me.Drive.Root
                                                            .Children
                                                            .Request()
                                                            .Filter("startswith(name,'Timesheet')")
                                                            .GetAsync();

                StringAssert.StartsWith(itemToShare[0].Name, "Timesheet");

                var permission = await graphClient.Me.Drive.Root
                                                           .ItemWithPath(itemToShare[0].Name)
                                                           .CreateLink("edit", "organization")
                                                           .Request()
                                                           .PostAsync();

                Assert.AreEqual("organization", permission.Link.Scope, "Expected organization scope for sharing link");
                Assert.AreEqual("edit", permission.Link.Type, "Expected edit type for sharing link");
                Assert.IsNotNull(permission.Link.WebUrl, "Expected a sharing URL for the sharing link");

            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }

        // Assumption: test tenant has a file name that starts with 'Timesheet'.
        // Assumption: there is a user with an email alias of alexd and a display name of Alex Darrow in the test tenant.
        [TestMethod]
        public async Task OneDriveInvite()
        {
            try
            {
                // Get the item to share with another user.
                var itemToShare = await graphClient.Me.Drive.Root
                                                            .Children
                                                            .Request()
                                                            .Filter("startswith(name,'Timesheet')")
                                                            .GetAsync();

                StringAssert.StartsWith(itemToShare[0].Name, "Timesheet");

                var me = await graphClient.Me.Request().GetAsync();
                var domain = me.Mail.Split('@')[1];

                var recipients = new List<DriveRecipient>()
                {
                    new DriveRecipient()
                    {
                        Email = $"alexd@{domain}"
                    }
                };

                var roles = new List<string>() 
                {
                    "write"
                };

                var inviteCollection = await graphClient.Me.Drive
                                                           .Root
                                                           .ItemWithPath(itemToShare[0].Name)
                                                           .Invite(recipients, true, roles, true, "Checkout the Invite feature!")
                                                           .Request()
                                                           .PostAsync();

                Assert.AreEqual("Alex Darrow", inviteCollection[0].GrantedTo.User.DisplayName);
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Fail("Something happened, check out a trace. Error code: {0}", e.Error.Code);
            }
        }
    }
}
