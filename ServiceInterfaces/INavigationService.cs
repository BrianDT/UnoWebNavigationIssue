// <copyright file="INavigationService.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace ServiceInterfaces
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Selected elements from a navigation service.
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        /// Navigates to an external page
        /// </summary>
        /// <param name="targetUri">The URI to navigate to</param>
        /// <returns>The async task that can be awaited</returns>
        Task ExternalPageNavigation(Uri targetUri);
    }
}