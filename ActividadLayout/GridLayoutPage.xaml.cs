using System;
using Microsoft.Maui.Controls;

namespace ActividadLayout
{
    public partial class GridLayoutPage : ContentPage
    {
        public GridLayoutPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }
        
    }
}