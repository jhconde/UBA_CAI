using Newtonsoft.Json;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/api/v1/cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        private List<Cliente> MapList(string json)
        {
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }




        //private Cliente MapObj(string json)
        //{
        //    var lst = JsonConvert.DeserializeObject<Cliente>(json);
        //    return lst;
        //}
        //public Cliente TraerPorCodigo(int codigo)
        //{
        //    string json2 = WebHelper.Get("/api/v1/cliente/" + codigo.ToString()); // trae un texto en formato json de una web
        //    Cliente resultado = MapObj(json2);
        //    return resultado;
        //}
    }
}
