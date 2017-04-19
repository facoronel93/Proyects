using Android.App;
using Android.Widget;
using MvvmCross.Droid.Views;
using System;
using System.Net;
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


            Button obtenerClima = FindViewById<Button>(Resource.Id.obtenerClima);
            //   var asd = new viewModelClima();
            obtenerClima.Click += (object sender, EventArgs e) =>
            {


            };
        }
   
        

     

        }
    }



