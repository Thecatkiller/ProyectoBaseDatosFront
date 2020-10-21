using Newtonsoft.Json;
using System;
using System.Collections.Generic; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class Historial    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("factoresRiesgo")]
        public List<FactoresRiesgo> FactoresRiesgo { get; set; } 

        [JsonProperty("fechaCreacion")]
        public DateTime FechaCreacion { get; set; } 
    }

}