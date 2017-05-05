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
    /// The interface IEnterpriseCodeSigningCertificateRequest.
    /// </summary>
    public partial interface IEnterpriseCodeSigningCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EnterpriseCodeSigningCertificate using PUT.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToCreate">The EnterpriseCodeSigningCertificate to create.</param>
        /// <returns>The created EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> CreateAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToCreate);        /// <summary>
        /// Creates the specified EnterpriseCodeSigningCertificate using PUT.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToCreate">The EnterpriseCodeSigningCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> CreateAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EnterpriseCodeSigningCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EnterpriseCodeSigningCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EnterpriseCodeSigningCertificate.
        /// </summary>
        /// <returns>The EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> GetAsync();

        /// <summary>
        /// Gets the specified EnterpriseCodeSigningCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EnterpriseCodeSigningCertificate using PATCH.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToUpdate">The EnterpriseCodeSigningCertificate to update.</param>
        /// <returns>The updated EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> UpdateAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToUpdate);

        /// <summary>
        /// Updates the specified EnterpriseCodeSigningCertificate using PATCH.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToUpdate">The EnterpriseCodeSigningCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> UpdateAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Expand(Expression<Func<EnterpriseCodeSigningCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Select(Expression<Func<EnterpriseCodeSigningCertificate, object>> selectExpression);

    }
}