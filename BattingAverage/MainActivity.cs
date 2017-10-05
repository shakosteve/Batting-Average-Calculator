using System.Globalization;
using Android.App;
using Android.Media;
using Android.Widget;
using Android.OS;
using BattingAverageCalculator.Application;

namespace BattingAverage
{
    [Activity(Label = "Batting Average Calculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var hits = FindViewById<EditText>(Resource.Id.HitsText);
            var atBats = FindViewById<EditText>(Resource.Id.AtBatsText);
            var calcAverage = FindViewById<Button>(Resource.Id.CalculateBattingAverageButton);
            var battingAverage = FindViewById<TextView>(Resource.Id.BattingAverageText);
            var flair = FindViewById<TextView>(Resource.Id.FlairText);
            var player = MediaPlayer.Create(this, Resource.Raw.BallHitCheer);

            calcAverage.Click += (sender, args) =>
            {
                var battingAverageValidation = new BattingAverageValidation(hits.Text,atBats.Text);
                var battingAvergeLogic = new BattingAverageLogic(battingAverageValidation.Hits, battingAverageValidation.AtBats);

                hits.Text = battingAverageValidation.Hits.ToString(CultureInfo.CurrentCulture);
                atBats.Text = battingAverageValidation.AtBats.ToString(CultureInfo.CurrentCulture);

                player.Start();
                battingAverage.Text = $"Your batting average is: {battingAvergeLogic.Average}";
                flair.Text = battingAvergeLogic.Flair;
            };
        }
    }
}

