using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatosFront.http.client.response
{
    public class JException : Exception
    {
        [JsonProperty("error-code")]
        public string errorCode { get; set; }
        public string message { get; set; }
        public string url { get; set; }
        public List<Detail> details { get; set; }

        public override string ToString()
        {
            string detailsTxt = "";

            if (details != null)
            {
                details.ForEach(x => detailsTxt += x.ToString() + Environment.NewLine);
            }

            return this.message + Environment.NewLine +
                detailsTxt;
        }

    }

    public class Detail
    {
        public string errorCode { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return description;
        }
    }
}
