// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace UnoWebNavigationIssue
{
    using ServicesX;
    using ViewModelInterfaces;
    using ViewModels;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var navigationService = new NavigationService();
            this.DataContext = new MainViewModel(navigationService);
        }

        /// <summary>
        /// Gets the view model for binding, this would normally be an interface.
        /// </summary>
        public IMainViewModel VM => this.DataContext as IMainViewModel;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.VM.NavigateToSampleSite();
        }
    }
}