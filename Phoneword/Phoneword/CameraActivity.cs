using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Android.Graphics;
using Android.Provider; //permite utilizar la camara

namespace Phoneword
{
    [Activity(Label = "Camara")]
    public class CameraActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.cameraMenu);

            Button cameraButton = FindViewById<Button>(Resource.Id.cameraButton);
            var visorImagen = FindViewById<ImageView>(Resource.Id.visorImagenes);
            cameraButton.Click += btnCameraClick;
        }

        private void btnCameraClick(object sander, EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture); // pedido de camara
            StartActivityForResult(intent, 0);
            
        }
   
     } //inicializacion de actividad



}