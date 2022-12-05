using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui;

namespace MauiApp1
{
    public partial class MainPageModel : ObservableValidator
    {
        [ICommand]
        private async Task ShareAsync()
        {
            string text = $"Some Text to Share";

            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Calculation Results"
            });
        }
    }
}
