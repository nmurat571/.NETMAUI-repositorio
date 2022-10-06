using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo_App2.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Send()
        {
            //verificar que property Text no esté vacía
            if(string.IsNullOrEmpty(Text))
                return;
            //enviar texto a saludo.xaml
            await Shell.Current.GoToAsync($"{nameof(GreetingPage)}?Text={text}");
            Text = string.Empty;
        }

    }
}
