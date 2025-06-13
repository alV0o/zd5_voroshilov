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
    public partial class MainPage : TabbedPage
    {
        public MainPage(string name)
        {
            InitializeComponent();
            Title = $"Привет, {name}";

            this.Resources.Add(StyleSheet.FromResource("styles.css", IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly));
        }
    }
}
