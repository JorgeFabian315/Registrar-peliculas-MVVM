﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cine2MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarView : ContentPage
    {
        public AgregarView()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}