using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }

    public class MainPageViewModel
    {
        public Command<string> SelectedCommand { get; }

        public IEnumerable<string> Items { get; } = Enumerable.Range(1, 10).Select(x => x.ToString()).ToArray();

        public MainPageViewModel()
        {
            this.SelectedCommand = new Command<string>(x => Debug.WriteLine(x));
        }
    }
}
