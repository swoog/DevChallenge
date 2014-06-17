using DevChallenge.Tools;
using DevChallenge.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DevChallenge.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand AboutCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetPage<AboutPage, AboutViewModel>());
                });
            }
        }
        public ICommand StatsCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetPage<AboutPage, AboutViewModel>());
                });
            }
        }

        public ICommand PlayCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetPage<AboutPage, AboutViewModel>());
                });
            }
        }
    }
}
