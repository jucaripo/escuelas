using System;
using System.Collections.Generic;

namespace escuelas.Models
{
    // este modelo es de un objeto
    // en el json es un array por lo que
    // hay que cuidar que  crees el List de este objeto 
    public class plantelModel
    {

        public string idPlantelES { get; set; }
        public string NombrePlantelES { get; set; }
        public string logo_plantel { get; set; }
        public string NombreMunicipio { get; set; }
        public string NombreEstado { get; set; }
        public List<carreraModel> carreras { get; set; }
        public List<imageneModel> imagenes { get; set; }




        public plantelModel()
        {
            // iniciamos los contructores para no tener error en el modelo
            var carreras = new List<carreraModel>();
            var imagenes = new List<imageneModel>();
        }
    }
}
