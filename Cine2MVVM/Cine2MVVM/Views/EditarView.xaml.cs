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
    public partial class EditarView : ContentPage
    {
        public EditarView()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
         await   Navigation.PopToRootAsync();
        }
    }
}