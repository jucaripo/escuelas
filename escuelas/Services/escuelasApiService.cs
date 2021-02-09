using System;
using System.Collections.Generic;
using System.Net;
using escuelas.Models;
using Newtonsoft.Json;
using RestSharp;

namespace escuelas.Services
{
    /// <summary>
    /// Clase para llamar a la api y traer los datos
    /// </summary>
    public class escuelasApiService
    {

        private const string url = "https://applikt.guanajuato.gob.mx:82/webservice/api.php?accion=consultar-planteles&fbclid=IwAR2QPQiTPtREwD7X2WmukeKdUZjN9iz1hGcFPGdIbJajRas4nX06g8-k4oE";

        public escuelasApiService()
        {
        }

        public List<plantelModel> getEscuelas()
        {
            // lista de escuelas vacias
            var escuelas = new List<plantelModel>();

            // nuevo restClient url la url de la consulta get
            var client = new RestClient(url);
            // generamos un request
            var request = new RestRequest();
            // generamos la respuesta al cliente
            var response = client.Get(request);

            // si la respuesta http es ok  procedemos a deserializar los datos
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // response.content es el string del Json que regresa el server
                // List<PlantelModel> es el modelo como esta el json si no son iguales
                // dara error el Json.DeserailizeObject
                escuelas = JsonConvert.DeserializeObject<List<plantelModel>>(response.Content);
            }


            return escuelas;

        }

    }
}
