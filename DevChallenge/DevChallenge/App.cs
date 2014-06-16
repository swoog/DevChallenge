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
        public static Page GetMainPage()
        {
            var view = new MainPage();
            var vm = new MainViewModel();
            view.BindingContext = vm;
            vm.Navigation = view.Navigation;

            return view;
        }

        public static Page GetAboutPage()
        {
            var view = new AboutPage();
            var vm = new AboutViewModel();
            view.BindingContext = vm;
            vm.Navigation = view.Navigation;

            return view;
        }
    }
}
