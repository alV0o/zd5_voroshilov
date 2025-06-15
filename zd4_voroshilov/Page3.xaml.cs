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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        //установка данных
        public void SetData(string type, int maxValue, int nowValue)
        {
            TypeOfPay.Text = type;
            MaxValueOfSlider.Text = maxValue.ToString();
            NowValueOfSlider.Text = nowValue.ToString();

            switch (type)
            {
                case "Аннуитетный":
                    TranscriptOfType.Text = "Аннуитетный платёж - это схема погашения кредита, при которой ежемесячный платёж остаётся неизменным на протяжении всего срока кредита.";
                    break;

                case "Дифференцированный":
                    TranscriptOfType.Text = "Дифференцированный платёж - это способ погашения кредита, при котором сумма ежемесячного платежа постепенно уменьшается на протяжении всего срока кредита.";
                    break;
                default:
                    TranscriptOfType.Text = "Отсутствует";
                    TypeOfPay.Text = "Отсутствует";
                    MaxValueOfSlider.Text = "Отсутствует";
                    NowValueOfSlider.Text = "Отсутствует";
                    break;
            }
        }
    }
}
