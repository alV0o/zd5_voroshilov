 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_voroshilov
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Welcome : ContentPage
	{
		public Welcome ()
		{
			InitializeComponent ();
		}

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Password.Text))
            {
                var newPage = new MainPage(Username.Text);
                await Navigation.PushAsync(newPage);
            }
            else
            {
                DisplayAlert("Ошибка!", "Заполните поля", "Ок");
            }
        }
	}
}