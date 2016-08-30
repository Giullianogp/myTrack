using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace myTrack.Core.ViewModels
{
    public class CodigoDetalheViewModel : MvxViewModel
    {
        public CodigoDetalheViewModel()
        {
            //var url = "http://developers.agenciaideias.com.br/correios/rastreamento/json/{0}";

            //var client = new HttpClient();
            //client.DefaultRequestHeaders.AcceptLanguage.Clear();
            //client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pt-br", 0.5));
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var resp = client.GetAsync(string.Format(url, IdCodigo.Text)).Result;

            //List<Rastreamento> retorno;

            //try
            //{
            //    retorno = resp.IsSuccessStatusCode ? JsonConvert.DeserializeObject<List<Rastreamento>>(resp.Content.ReadAsStringAsync().Result) : null;
            //}
            //catch (Exception ex)
            //{
            //    retorno = null;
            //}

            //if (retorno != null)
            //    listview.ItemsSource = retorno.OrderByDescending(x => x.DataD);
            //else
            //{

            //}
        }
    }
}
