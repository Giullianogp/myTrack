using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Hosting;
using myTrack.Core.ViewModels;
using Microsoft.Graphics.Canvas.Effects;
using MvvmCross.WindowsUWP.Views;

namespace myTrack.UWP.Views
{
    public sealed partial class FirstView : MvxWindowsPage
    {
        private new FirstViewModel ViewModel
        {
            get { return (FirstViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }


        public FirstView()
        {
            this.InitializeComponent();
            DataContext = ViewModel;
        }

        private void FirstView_OnLoaded(object sender, RoutedEventArgs e)
        {

        }



        private void FirstView_OnUnloaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
