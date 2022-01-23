using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mathOnFingers.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private int winCount = 0;
        private AppData.FirstLevelLogic logic = new AppData.FirstLevelLogic();

        public Page2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            winCountLable.Text = winCount.ToString();
            logic.NumberGenerator();
            PrintMathExample(logic.firstNumber, logic.mathOperator, logic.secondNumber);
            firstAnswerButton.Text = logic.firstButtonText.ToString();
            secondAnswerButton.Text = logic.secondButtonText.ToString();
            thirdAnswerButton.Text = logic.thirdButtonText.ToString();
            if ((firstAnswerButton.Text == secondAnswerButton.Text || firstAnswerButton.Text == thirdAnswerButton.Text || secondAnswerButton.Text == thirdAnswerButton.Text) || (firstAnswerButton.Text == logic.winAnswer.ToString() || secondAnswerButton.Text == logic.winAnswer.ToString() || thirdAnswerButton.Text == logic.winAnswer.ToString()))
            {
                OnAppearing();
            }
            switch (logic.winButton)
            {
                case 0:
                    firstAnswerButton.Text = logic.winAnswer.ToString();
                    break;

                case 1:
                    secondAnswerButton.Text = logic.winAnswer.ToString();
                    break;

                case 2:
                    thirdAnswerButton.Text = logic.winAnswer.ToString();
                    break;

                default:
                    break;
            }

        }

        public void PrintMathExample(int num1, char oper, int num2)
        {
            mathExampleLable.Text = num1.ToString() + oper.ToString() + num2.ToString();
        }

        public async void firstAnswerButton_Clicked(object content, EventArgs e)
        {
            if (logic.winAnswer.ToString() == firstAnswerButton.Text)
            {
                winCount++;
                OnAppearing();
            }
            else
            {
                await DisplayAlert("Поражение!", $"К сожалению ты ответил неправильно! Правильный ответ был: {logic.winAnswer}", "Ок");
                winCount = 0;
                OnAppearing();
            }
        }

        public async void secondAnswerButton_Clicked(object content, EventArgs e)
        {
            if (logic.winAnswer.ToString() == secondAnswerButton.Text)
            {
                winCount++;
                OnAppearing();
            }
            else
            {
                await DisplayAlert("Поражение!", $"К сожалению ты ответил неправильно! Правильный ответ был: {logic.winAnswer}", "Ок");
                winCount = 0;
                OnAppearing();
            }
        }

        public async void ThirdAnswerButton_Clicked(object content, EventArgs e)
        {
            if (logic.winAnswer.ToString() == thirdAnswerButton.Text)
            {
                winCount++;
                OnAppearing();
            }
            else
            {
                await DisplayAlert("Поражение!", $"К сожалению ты ответил неправильно! Правильный ответ был: {logic.winAnswer}", "Ок");
                winCount = 0;
                OnAppearing();
            }
        }
    }
}