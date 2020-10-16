using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelabo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forms_3_5_Page : ContentPage
    {
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Navigation.PushAsync(new WebViewPage(url));
        });

        public Forms_3_5_Page()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void ImageButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Image Button Clicked");
        }
    }
}