using DAM_Leccion_01.Model;
using FoundationStandard.ObjectHydrator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_01.ViewModel
{
    public class PersonasViewModel{
        //Los datos se cargaran en una lista
        public ObservableCollection<PersonasModel> Personas { get; set; }
        // (Parametro T) -> Esto significa una clase generic para admitir cualquier tipo de datos
        public PersonasViewModel(){
            Consultar();
        }
        public void Consultar() {
            var listado = new Hydrator<PersonasModel>().WithFirstName(n => n.Nombre);//Lo tiene que convertir en una ->Hydrator (inyecta datos) y que cargue la propiedad nombre
            Personas = new ObservableCollection<PersonasModel>(listado.GetList(20)); //Obtiene solo 20 registros      
        }
    }
}
