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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        private async void OnClickStatic(object sender, EventArgs e) 
        {
            if (ButtonStatic.BackgroundColor == Color.FromHex("#459F45"))
            {
                ButtonStatic.BackgroundColor = Color.LightGray;
            }
            else if (ButtonStatic.BackgroundColor == Color.LightGray)
            {
                ButtonStatic.BackgroundColor = Color.White;
                ButtonStatic.TextColor = Color.Black;
            }
            else if (ButtonStatic.BackgroundColor == Color.White)
            {
                try
                {
                    await Navigation.PushAsync(new Page3(DropDown.SelectedItem.ToString(), (int)SliderProcents.Maximum, (int)SliderProcents.Value));

                    ButtonStatic.BackgroundColor = Color.FromHex("#459F45");
                    ButtonStatic.TextColor = Color.White;
                }
                catch
                {
                    DisplayAlert("Ошибка!", "Выберите элемент Picker и установите значение Slider", "Ок");
                }
            }
        }

        private void OnClickHover(object sender, EventArgs e)
        {
            if (ButtonHover.BackgroundColor == Color.FromHex("#388138"))
            {
                ButtonHover.BackgroundColor = Color.DarkGray;
            }
            else if (ButtonHover.BackgroundColor == Color.DarkGray)
            {
                ButtonHover.BackgroundColor = Color.White;
                ButtonHover.TextColor = Color.Black;
            }
            else if (ButtonHover.BackgroundColor == Color.White)
            {
                ButtonHover.BackgroundColor = Color.FromHex("#388138");
                ButtonHover.TextColor = Color.White;
            }
        }


        private void OnClickPressed(object sender, EventArgs e)
        {
            if (ButtonPressed.BackgroundColor == Color.FromHex("#2E6D2A"))
            {
                ButtonPressed.BackgroundColor = Color.Gray;
            }
            else if (ButtonPressed.BackgroundColor == Color.Gray)
            {
                ButtonPressed.BackgroundColor = Color.LightGray;
                ButtonPressed.TextColor = Color.Black;
            }
            else if (ButtonPressed.BackgroundColor == Color.LightGray)
            {
                ButtonPressed.BackgroundColor = Color.FromHex("#2E6D2A");
                ButtonPressed.TextColor = Color.White;
            }
        }
    }
}