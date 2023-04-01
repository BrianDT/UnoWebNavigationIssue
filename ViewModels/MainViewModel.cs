// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using ServiceInterfaces;
    using ViewModelInterfaces;

    /// <summary>
    /// The main view model.
    /// </summary>
    public class MainViewModel : IMainViewModel
    {
        private INavigationService navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">The navigation service.</param>
        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Navigate to a predefined web site.
        /// </summary>
        public void NavigateToSampleSite()
        {
            string name = "Author's web page";
            string webPage = "https://www.visualsoftwaresystemsltd.com";
            this.NavigateToExternalPage(name, webPage);
        }

        /// <summary>
        /// Navigate of a an external web page
        /// </summary>
        /// <param name="sourceName">The name of the page</param>
        /// <param name="targetData">The web page to be embedded</param>
        private void NavigateToExternalPage(string sourceName, string targetData)
        {
            try
            {
                this.navigationService.ExternalPageNavigation(new Uri(targetData, UriKind.Absolute));
            }
            catch (System.UriFormatException ex)
            {
#if DEBUG
                Debug.WriteLine(string.Format("{0} generated the exception {1}", targetData, ex.Message));
#endif
            }
        }
    }
}