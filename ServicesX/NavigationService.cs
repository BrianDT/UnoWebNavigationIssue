// <copyright file="NavigationService.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace ServicesX
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ServiceInterfaces;

    /// <summary>
    /// Selected elements from a navigation service.
    /// </summary>
    public class NavigationService : INavigationService
    {
        /// <summary>
        /// Navigates to an external page
        /// </summary>
        /// <param name="targetUri">The URI to navigate to</param>
        /// <returns>The async task that can be awaited</returns>
        public async Task ExternalPageNavigation(Uri targetUri)
        {
            await Windows.System.Launcher.LaunchUriAsync(targetUri);
            return;
        }
    }
}
