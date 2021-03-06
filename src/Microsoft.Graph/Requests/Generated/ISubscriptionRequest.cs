// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISubscriptionRequest.
    /// </summary>
    public partial interface ISubscriptionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Subscription using PUT.
        /// </summary>
        /// <param name="subscriptionToCreate">The Subscription to create.</param>
        /// <returns>The created Subscription.</returns>
        System.Threading.Tasks.Task<Subscription> CreateAsync(Subscription subscriptionToCreate);        /// <summary>
        /// Creates the specified Subscription using PUT.
        /// </summary>
        /// <param name="subscriptionToCreate">The Subscription to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Subscription.</returns>
        System.Threading.Tasks.Task<Subscription> CreateAsync(Subscription subscriptionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Subscription.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Subscription.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Subscription.
        /// </summary>
        /// <returns>The Subscription.</returns>
        System.Threading.Tasks.Task<Subscription> GetAsync();

        /// <summary>
        /// Gets the specified Subscription.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Subscription.</returns>
        System.Threading.Tasks.Task<Subscription> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Subscription using PATCH.
        /// </summary>
        /// <param name="subscriptionToUpdate">The Subscription to update.</param>
        /// <returns>The updated Subscription.</returns>
        System.Threading.Tasks.Task<Subscription> UpdateAsync(Subscription subscriptionToUpdate);

        /// <summary>
        /// Updates the specified Subscription using PATCH.
        /// </summary>
        /// <param name="subscriptionToUpdate">The Subscription to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Subscription.</returns>
        System.Threading.Tasks.Task<Subscription> UpdateAsync(Subscription subscriptionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubscriptionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubscriptionRequest Expand(Expression<Func<Subscription, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISubscriptionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISubscriptionRequest Select(Expression<Func<Subscription, object>> selectExpression);

    }
}
