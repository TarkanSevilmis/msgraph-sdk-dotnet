// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITaskDetailsRequest.
    /// </summary>
    public partial interface ITaskDetailsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TaskDetails using PUT.
        /// </summary>
        /// <param name="taskDetailsToCreate">The TaskDetails to create.</param>
        /// <returns>The created TaskDetails.</returns>
        System.Threading.Tasks.Task<TaskDetails> CreateAsync(TaskDetails taskDetailsToCreate);        /// <summary>
        /// Creates the specified TaskDetails using PUT.
        /// </summary>
        /// <param name="taskDetailsToCreate">The TaskDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TaskDetails.</returns>
        System.Threading.Tasks.Task<TaskDetails> CreateAsync(TaskDetails taskDetailsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TaskDetails.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TaskDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TaskDetails.
        /// </summary>
        /// <returns>The TaskDetails.</returns>
        System.Threading.Tasks.Task<TaskDetails> GetAsync();

        /// <summary>
        /// Gets the specified TaskDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TaskDetails.</returns>
        System.Threading.Tasks.Task<TaskDetails> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TaskDetails using PATCH.
        /// </summary>
        /// <param name="taskDetailsToUpdate">The TaskDetails to update.</param>
        /// <returns>The updated TaskDetails.</returns>
        System.Threading.Tasks.Task<TaskDetails> UpdateAsync(TaskDetails taskDetailsToUpdate);

        /// <summary>
        /// Updates the specified TaskDetails using PATCH.
        /// </summary>
        /// <param name="taskDetailsToUpdate">The TaskDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TaskDetails.</returns>
        System.Threading.Tasks.Task<TaskDetails> UpdateAsync(TaskDetails taskDetailsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaskDetailsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaskDetailsRequest Expand(Expression<Func<TaskDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITaskDetailsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITaskDetailsRequest Select(Expression<Func<TaskDetails, object>> selectExpression);

    }
}