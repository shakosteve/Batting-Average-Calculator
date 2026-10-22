using System.Collections.Generic;
using System.Globalization;
using Android.App;
using Android.Media;
using Android.Widget;
using Android.OS;
using BattingAverageCalculator.Application;
using BattingAverageCalculator.Classes;
using BattingAverageCalculator.Data;

namespace BattingAverage
{
    [Activity(Label = "Batting Average Calculator", MainLauncher = true, Exported = true)]
    public class MainActivity : Activity
    {
        // Long clips are cut short with a fade so every reaction lasts about the same time
        private const int PlayMilliseconds = 3000;
        private const int FadeMilliseconds = 600;
        private const int FadeSteps = 12;

        private readonly Handler fadeHandler = new Handler(Looper.MainLooper);
        private Dictionary<CrowdReaction, MediaPlayer> crowdSounds;
        private MediaPlayer playingSound;

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

            crowdSounds = new Dictionary<CrowdReaction, MediaPlayer>
            {
                [CrowdReaction.Boo] = MediaPlayer.Create(this, Resource.Raw.crowd_boo),
                [CrowdReaction.Applause] = MediaPlayer.Create(this, Resource.Raw.crowd_applause),
                [CrowdReaction.Cheer] = MediaPlayer.Create(this, Resource.Raw.BallHitCheer)
            };

            // Load the flair once at launch rather than on every calculation
            var battingAverageDataAccess = new BattingAverageDataAccess();

            calcAverage.Click += (sender, args) =>
            {
                var battingAverageValidation = new BattingAverageValidation(hits.Text,atBats.Text);
                var battingAverageLogic = new BattingAverageLogic(battingAverageValidation.Hits, battingAverageValidation.AtBats, battingAverageDataAccess);

                hits.Text = battingAverageValidation.Hits.ToString(CultureInfo.CurrentCulture);
                atBats.Text = battingAverageValidation.AtBats.ToString(CultureInfo.CurrentCulture);

                PlayCrowd(battingAverageLogic.Reaction);
                battingAverage.Text = battingAverageLogic.Average;
                flair.Text = battingAverageLogic.Flair;
            };
        }

        protected override void OnDestroy()
        {
            fadeHandler.RemoveCallbacksAndMessages(null);
            foreach (var sound in crowdSounds.Values)
            {
                sound.Release();
            }

            base.OnDestroy();
        }

        private void PlayCrowd(CrowdReaction reaction)
        {
            // Cut off whatever is still playing so quick taps always restart the sound
            fadeHandler.RemoveCallbacksAndMessages(null);
            playingSound?.Pause();

            var sound = crowdSounds[reaction];
            playingSound = sound;
            sound.SetVolume(1f, 1f);
            sound.SeekTo(0);
            sound.Start();

            for (var step = 1; step <= FadeSteps; step++)
            {
                var volume = 1f - (float)step / FadeSteps;
                fadeHandler.PostDelayed(() => sound.SetVolume(volume, volume), PlayMilliseconds + step * FadeMilliseconds / FadeSteps);
            }

            fadeHandler.PostDelayed(() => sound.Pause(), PlayMilliseconds + FadeMilliseconds);
        }
    }
}
