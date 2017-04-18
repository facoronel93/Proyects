using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Start.Core.Services;

namespace Start.Core.ViewModel
{
   public class StartViewModel : MvxViewModel
    {
        private string _Nombre;
        public string Nombre
        {
            get { return Nombre; }
            set { _Nombre = value; RaisePropertyChanged(() => Nombre); }
        }

        private string _Apellido;
        public string Apellido
        {
            get { return Apellido; }
            set { _Apellido = value; RaisePropertyChanged(() => Apellido); }
        }

        private int _Dni;
        public int  Dni
        {
            get { return Dni; }
            set { _Dni = value; RaisePropertyChanged(() => Dni); }
        }

    /*    private string _NombreApellido;
        public string NombreApellido
        {
            get { return NombreApellido; }
            set { _NombreApellido = value; RaisePropertyChanged(() => Apellido);  }
        }*/

   /* public void Actualizar()
        {
            NombreApellido = _Nombre + _Apellido;
        }

      List<Persona> newList = new List<Persona>();
        public void ActualizarLista()
        {
            var _persona = new Persona();
            _persona.Nombre = Nombre;
            _persona.Apellido = Apellido;
            _persona.Dni = Dni;
          
              newList.Add(_persona);          
        }
       
       */ 
        
    }
}
