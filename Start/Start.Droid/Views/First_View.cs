using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;
using Start.Core.ViewModel;
namespace Start.Droid
{
    [Activity(Label = "Start.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : MvxActivity<StartViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.FirstView);
        }

        
       
    }
}

