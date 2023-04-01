// <copyright file="IMainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace ViewModelInterfaces
{
    using System.ComponentModel;

    /// <summary>
    /// The main view model.
    /// </summary>
    public interface IMainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Navigate to a predefined web site.
        /// </summary>
        void NavigateToSampleSite();
    }
}