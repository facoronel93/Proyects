using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalc.Droid
{
    using System;
    using Android.App;
    using MvvmCross.Droid.Views;


    namespace TipCalc.UI.Droid.Views
    {
        [Activity(Label = "Tip", MainLauncher = true)]
        public class TipView : MvxActivity
        {
            public new Core.TipViewModel ViewModel
            {
                get { return (Core.TipViewModel)base.ViewModel; }
                set { base.ViewModel = value; }
            }

            protected override void OnViewModelSet()
            {
                base.OnViewModelSet();
                SetContentView(Resource.Layout.View_Tip);
            }


        }
    }
}

