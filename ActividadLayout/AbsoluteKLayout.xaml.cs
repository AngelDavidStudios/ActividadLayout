using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadLayout;

public partial class AbsoluteKLayout : ContentPage
{
    public AbsoluteKLayout()
    {
        InitializeComponent();
    }
    
    async void OnButtonClicked(object sender, EventArgs args)
{
    await Navigation.PushAsync(new GridLayoutPage());
}
}