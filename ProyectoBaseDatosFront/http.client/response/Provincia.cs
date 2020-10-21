using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class Provincia    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("nombre")]
        public string Nombre { get; set; } 

        [JsonProperty("departamento")]
        public Departamento Departamento { get; set; } 
    }

}