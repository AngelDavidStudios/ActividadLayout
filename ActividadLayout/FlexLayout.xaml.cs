using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadLayout;

public partial class FlexLayout : ContentPage
{
    public FlexLayout()
    {
        InitializeComponent();
    }
    
    async void OnImageTapped(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new AbsoluteKLayout());
    }
}