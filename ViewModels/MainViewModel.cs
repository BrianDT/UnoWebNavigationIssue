// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace ViewModels
{
    using ServiceInterfaces;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using ViewModelInterfaces;

    public class MainViewModel : IMainViewModel
    {
        private INavigationService navigationService;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

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
        private void NavigateToExternalPage(string name, string targetData)
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