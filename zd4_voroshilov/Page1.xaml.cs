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
    public partial class Page1 : ContentPage
    {
        public string Type {  get; set; }
        public int MaxValue { get; set; }
        public int NowValue { get; set; }

        public Page1()
        {
            InitializeComponent();
        }

        //метод, считывающий значение слайдера
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ProcentsRate.Text = $"{e.NewValue:F0}%";//обновление Label с изображением процентов

            CalcAllData(sender, e);
        }

        //расчет нужных данных
        private void CalcAllData(object sender, EventArgs e)
        {
            try
            {
                Type = TypeOfPayment.SelectedItem.ToString();
                MaxValue = (int)ProcentsSlider.Maximum;
                NowValue = (int)ProcentsSlider.Value;

                if (TypeOfPayment.SelectedIndex == 0)//проверка на выбранный вид платежа
                {

                    double sumOfCredit = double.Parse(SumOfCredit.Text);
                    int monthForPayment = int.Parse(DateMonth.Text);
                    int procents = (int) ProcentsSlider.Value;

                    string checkValid = Calculator.CheckValidSumAndMonths(sumOfCredit, monthForPayment);

                    if (checkValid != "")//проверка на правильно введенные данные
                    {
                        DisplayAlert("Ошибка!", checkValid, "Ок");
                    }
                    else
                    {
                        double monthPayment = Calculator.CalculateMonthPayment(sumOfCredit, monthForPayment, procents);
                        double allSum = Calculator.CalcAllSumPayment(sumOfCredit, monthForPayment, procents);
                        double overPayment = Calculator.CalcOverPayment(sumOfCredit, monthForPayment, procents);

                        //вывод вычисленных данных на Label`ы
                        MonthPayment.Text = $"Ежемесячный платеж: {Math.Round(monthPayment, 2)}р.";
                        AllSum.Text = $"Общая сумма: {Math.Round(allSum, 2)}p.";
                        OverPayment.Text = $"Переплата: {Math.Round(overPayment, 2)}p.";

                    }
                }
                else if (TypeOfPayment.SelectedIndex == 1)
                {
                    double sumOfCredit = double.Parse(SumOfCredit.Text);
                    int monthForPayment = int.Parse(DateMonth.Text);
                    int procents = (int)ProcentsSlider.Value;

                    string checkValid = Calculator.CheckValidSumAndMonths(sumOfCredit, monthForPayment);

                    if (checkValid != "")//проверка на правильно введенные данные
                    {
                        DisplayAlert("Ошибка!", checkValid, "Ок");
                    }
                    else
                    {
                        double allSum = Calculator.CalcAllSumPayment(sumOfCredit, monthForPayment, procents);
                        double overPayment = Calculator.CalcOverPayment(sumOfCredit, monthForPayment, procents);

                        //вывод вычисленных данных на Label`ы
                        MonthPayment.Text = $"Ежемесячный платеж:";
                        AllSum.Text = $"Общая сумма: {Math.Round(allSum, 2)}p.";
                        OverPayment.Text = $"Переплата: {Math.Round(overPayment, 2)}p.";
                    }
                }
            }
            catch
            {
                DisplayAlert("Ошибка!","Введите верные данные!","Ок");
            }
        }
    }
}