﻿using DevChallenge.Tools;
using DevChallenge.ViewModels;
using DevChallenge.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DevChallenge
{
    public class App
    {
        public static Page GetPage<TPage, TViewModel>()
            where TPage : Page, new()
            where TViewModel : BaseViewModel, new()
        {
            var view = new TPage();
            var vm = new TViewModel();
            view.BindingContext = vm;
            vm.Navigation = view.Navigation;

            return view;
        }

        public static Page GetStartPage()
        {
            return GetPage<MainPage, MainViewModel>();
        }
    }
}
