using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Proyect.core.ViewModels
{
   public class viewModelClima : MvxViewModel
    {

        private string ciudad;
        public string Ciudad
        {
            get { return ciudad; }
            set { Ciudad = value;RaisePropertyChanged(() => Ciudad); }
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

        public void asd()
        {
            string url = "http://api.apixu.com/v1/current.json?key=43dad43a410f428d86e133125171804&q=rosario";
            string json = JsonConvert.SerializeObject(url);
        }
      

       

    }
}
