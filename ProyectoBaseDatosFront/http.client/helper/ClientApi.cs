using Newtonsoft.Json;
using ProyectoBaseDatosFront.http.client.response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatosFront.http.client.helper
{
    public class ClientApi
    {
        private static readonly string URL_BASE = "http://190.117.113.40//clinic-service/";


        private string url;
        public ClientApi(string url)
        {
            this.url = URL_BASE + url;
        }


        private async Task<T> SendRequest<T>(object body, string method)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.SetRawHeader("content-type", "application/json; charset=utf-8");
                request.SetRawHeader("Accept", "application/json");

                request.Method = method;

                if (body != null)
                {
                    string content = JsonConvert.SerializeObject(body);
                    byte[] byte1 = Encoding.ASCII.GetBytes(content);
                    request.ContentLength = byte1.Length;
                    Stream newStream = request.GetRequestStream();
                    newStream.Write(byte1, 0, byte1.Length);
                } 
                
                            
                WebResponse response = request.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = await reader.ReadToEndAsync();
                    T objOut = JsonConvert.DeserializeObject<T>(result);
                    return objOut;
                }
            }
            catch (WebException ex)
            {
                using (StreamReader r = new StreamReader(((HttpWebResponse)ex.Response).GetResponseStream()))
                {
                    string result = await r.ReadToEndAsync();
                    JException jException = JsonConvert.DeserializeObject<JException>(result);
                    throw jException;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                JException jException = new JException();
                jException.message = "Ocurrió un error!";

                throw jException;
            }
        }

        public async Task<T> SendPost<T>(object objIn)
        {
            return await SendRequest<T>(objIn, "POST");
        }
        public async Task<T> SendGet<T>()
        {
            return await SendRequest<T>(null, "GET");
        }
    }
}
