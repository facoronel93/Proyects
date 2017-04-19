using MvvmCross.Core.ViewModels;
using System;

using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using Proyect.core.Services;

namespace Proyect.core.ViewModels
{
   public class viewModelClima : MvxViewModel
    {
        public override void Start()
        {
            asd();
            base.Start();
        }

        private string ciudad;
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value;RaisePropertyChanged(() => Ciudad); ; }
        }

        private string provincia;
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; RaisePropertyChanged(() => Provincia); }
        }

        private string pais;
        public string Pais
        {
            get { return pais; }
            set { pais = value; RaisePropertyChanged(() => Pais); }
        }

        private string temperatura;
        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; RaisePropertyChanged(() => Temperatura); }
        }

        private string humedad;
        public string Humedad
        {
            
            get { return humedad; }
            set { humedad = value; RaisePropertyChanged(() => Humedad); }
        }


     

        public async void asd()
        {
            var url = new Uri("http://api.apixu.com/v1/current.json?key=43dad43a410f428d86e133125171804&q=rosario");
            var httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync(url);
            string checkResult = result.ToString();
            httpClient.Dispose();
            RespuestaTiempo json = JsonConvert.DeserializeObject<RespuestaTiempo>(result);
            this.Pais = json.location.country;
        }

   
    }
           
        }


    
