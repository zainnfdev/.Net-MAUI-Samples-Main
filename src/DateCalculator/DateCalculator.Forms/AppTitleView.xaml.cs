﻿using DateCalculator.Views;
using System;
using Xamarin.Forms;

namespace DateCalculator
{
    public partial class AppTitleView : ContentView
    {
        public static readonly BindableProperty PageTitleProperty
            = BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(BasePage), default(string));

        public AppTitleView()
        {
            InitializeComponent();
        }

        public string PageTitle
        {
            get => (string)GetValue(PageTitleProperty);
            set => SetValue(PageTitleProperty, value);
        }

        private void Hamburger_Tapped(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
        }
    }
}