﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace theme_change
{
    public partial class App : Application
    {
        public App()
        {
            //Device.SetFlags(new string[] { "Experimental" });
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
