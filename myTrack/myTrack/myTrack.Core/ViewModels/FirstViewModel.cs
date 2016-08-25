using System.Collections.Generic;
using myTrack.Core.Model;
using MvvmCross.Core.ViewModels;

namespace myTrack.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        private List<Codigo> _listaCodigo = new List<Codigo>();
        public List<Codigo> ListaCodigo
        {
            get { return _listaCodigo; }
            set { SetProperty(ref _listaCodigo, value); }
        }

        public FirstViewModel()
        {
            ListaCodigo.Add(new Codigo() { CodigoId = 1, Registro = "0001", Titulo = "Teste 1" });
            ListaCodigo.Add(new Codigo() { CodigoId = 2, Registro = "0002", Titulo = "Teste 2" });
            ListaCodigo.Add(new Codigo() { CodigoId = 3, Registro = "0003", Titulo = "Teste 3" });
            ListaCodigo.Add(new Codigo() { CodigoId = 4, Registro = "0004", Titulo = "Teste 4" });
        }


    }
}
