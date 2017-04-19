using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Proyect.Droid
{
    [Activity(Label = "Clima", MainLauncher = true, Icon = "@drawable/icon")]
    public class climaView : MvxActivity
    {
        public new core.ViewModels.viewModelClima ViewModel
        {
            get { return (core.ViewModels.viewModelClima)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.clima);
        }
  
    }
}

