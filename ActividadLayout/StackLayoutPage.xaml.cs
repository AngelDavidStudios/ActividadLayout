using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadLayout;

public partial class StackLayoutPage : ContentPage
{
    public StackLayoutPage()
    {
        InitializeComponent();
    }
    
    private void NextPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }
}