using DAM_Leccion_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_01.ViewModel {
    public class MainPageViewModel {
        public PersonasModel personasModel { get; set; }

        public MainPageViewModel(){
            Consultar();
        }

        public void Consultar(){
            personasModel = new PersonasModel()
            {
                Nombre = "Jonathan Romero M",
                Apellido = "Romero Molina",
                Edad = "20",
            };


         }
    }

}
