﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace multiplataforma__lab11
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.Operaciones();
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
