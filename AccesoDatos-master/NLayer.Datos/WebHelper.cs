using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            //rutaBase = ConfigurationManager.AppSettings["URL_API"];
            rutaBase = "https://cai-api.azurewebsites.net/";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            var uri = rutaBase + url;
//            var responseString = client.DownloadString("http://www.mocky.io/v2/5ed6e98332000035002743fd");
            var responseString = client.DownloadString(uri);

            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            var response = client.UploadValues(uri, parametros);

            var responseString = Encoding.Default.GetString(response);

            return responseString;
        }
    }

}
