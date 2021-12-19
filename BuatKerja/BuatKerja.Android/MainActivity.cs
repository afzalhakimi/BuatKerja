using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Content.Res;
using MediaManager;
using Xamarin.Forms;

namespace BuatKerja.Droid
{
    [Activity(Label = "Click Best", Icon = "@mipmap/CB_launcher", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            switch (Device.Idiom)
            {
                case TargetIdiom.Phone:
                    RequestedOrientation = ScreenOrientation.Portrait;
                    break;
                case TargetIdiom.Tablet:
                    RequestedOrientation = ScreenOrientation.Landscape;
                    break;
            }
            base.OnCreate(savedInstanceState);
            CrossMediaManager.Current.Init(this);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            switch (newConfig.Orientation)
            {
                case Orientation.Landscape:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            LockRotation(Orientation.Portrait);
                            break;
                        case TargetIdiom.Tablet:
                            LockRotation(Orientation.Landscape);
                            break;
                    }
                    break;
                case Orientation.Portrait:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            LockRotation(Orientation.Portrait);
                            break;
                        case TargetIdiom.Tablet:
                            LockRotation(Orientation.Landscape);
                            break;
                    }
                    break;
            }
        }

        private void LockRotation(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.Portrait:
                    RequestedOrientation = ScreenOrientation.Portrait;
                    break;
                case Orientation.Landscape:
                    RequestedOrientation = ScreenOrientation.Landscape;
                    break;
            }
        }
    }
}