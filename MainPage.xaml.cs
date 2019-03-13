using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;




namespace BombSweeper
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int score = 0;


        public MainPage()
        {
            InitializeComponent();
           
        }

        async void ButtonClicked(object sender,EventArgs e)
        {
            Button button = sender as Button;

            //game over.
            if(button.Text == bomb)
            { 
                await DisplayAlert("Bomb exploded", "GAME OVER", "Retry");
                bomb = new Random().Next(1, 4).ToString();
                score = 0; //reset score 
            }
            else
            {
                score += 1; // adding score
                await DisplayAlert("Bomb Defused", "Score:" + score, "Continue");
                bomb = new Random().Next(1, 4).ToString();

            }
        }
             
    }
}
