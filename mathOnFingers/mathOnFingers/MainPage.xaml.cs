using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;

namespace mathOnFingers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        protected async override void OnAppearing()
        {
            await DisplayAlert("Привет!", "Пока тебе не было игра обновилась, список изменений: \nТеперь не будут попадаться одинаковые числа в ответах \nВсе 0 были удалены", "Понятно");
        }

        private async void startGameButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Page1());
        }

        private void startSettingsButton(object sender, EventArgs e)
        {

        }

        private void exitButton(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

