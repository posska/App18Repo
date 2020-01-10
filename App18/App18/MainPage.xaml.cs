using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App18
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         private void Button_Enter_OnClick(object sneder, EventArgs e)
        {
            Label_Display.Text = "Changed";
        }
    }
}
