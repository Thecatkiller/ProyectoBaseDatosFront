using Newtonsoft.Json;
using System;

namespace ProyectoBaseDatosFront.http.client.response{ 

    public class FactoresRiesgo    {
        [JsonProperty("factorRiesgo")]
        public FactorRiesgo FactorRiesgo { get; set; } 

        [JsonProperty("fechaRegistro")]
        public DateTime FechaRegistro { get; set; } 

        [JsonProperty("comentario")]
        public string Comentario { get; set; } 
    }

}