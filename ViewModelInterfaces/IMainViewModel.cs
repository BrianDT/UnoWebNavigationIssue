// <copyright file="IMainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023. All rights reserved</copyright>

namespace ViewModelInterfaces
{
    using System.ComponentModel;

    public interface IMainViewModel : INotifyPropertyChanged
    {
        void NavigateToSampleSite();
    }
}