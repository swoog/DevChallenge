using DevChallenge.Tools;
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
        public ICommand Ok
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetAboutPage());
                });
            }
        }
    }
}
