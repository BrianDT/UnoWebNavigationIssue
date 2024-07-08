// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace UnoWebNavigationIssue;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using ServicesX;
using ViewModelInterfaces;
using ViewModels;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainPage"/> class.
    /// </summary>
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

    /// <summary>
    /// Instigates a programatic navigation.
    /// </summary>
    /// <param name="sender">The sender</param>
    /// <param name="e">The event args</param>
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.VM.NavigateToSampleSite();
    }
}
