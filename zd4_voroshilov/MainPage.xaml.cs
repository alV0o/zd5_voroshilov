using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace zd4_voroshilov
{
    public partial class MainPage : CarouselPage
    {

        public MainPage(string name)
        {
            InitializeComponent();
            Title = $"Привет, {name}";

            //подключение CSS
            this.Resources.Add(StyleSheet.FromResource("styles.css", IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly));

            //инициализация страниц
            Page1 page1 = new Page1();
            Page2 page2 = new Page2();
            Page3 page3 = new Page3();

            //проверка на третью страницу
            CurrentPageChanged += (s, e) =>
            {
                if (CurrentPage == page3)
                {
                    string type = page1.Type;
                    int maxValue = page1.MaxValue;
                    int nowValue = page1.NowValue;

                    page3.SetData(type, maxValue, nowValue);
                }
            };
            Children.Add(page1);
            Children.Add(page2);
            Children.Add(page3);
        }
    }
}
