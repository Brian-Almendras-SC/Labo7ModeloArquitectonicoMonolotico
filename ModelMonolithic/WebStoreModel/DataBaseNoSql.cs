using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreModel
{
    public class DataBaseNoSql
    {
        private Dictionary<string, int> _listaProductos;
        private Dictionary<string, string> _InformacionEmpresa;
        public DataBaseNoSql()
        {
            _listaProductos = new Dictionary<string, int>();
            _InformacionEmpresa = new Dictionary<string, string>();
        }

        void SolicitudDeProductosDB()
        {
            _listaProductos.Add("Manzana", 100);
            _listaProductos.Add("Pera", 150);
        }
        void SolicitudDeInformacionDB()
        {
            _InformacionEmpresa.Add("Direccion", "Torre Sofia");
            _InformacionEmpresa.Add("Telefono", "74747474");
        }
        public string[] RetornarListaDeProductos()
        {
            SolicitudDeProductosDB();
            string[] ListaProductos = new string[_listaProductos.Count];
            int Contador = 0;
            foreach (var item in _listaProductos)
            {
                ListaProductos[Contador] = $"Producto: {item.Key} y su precio: {item.Value}";
                Contador++;
            }
            return ListaProductos;
        }
        public Dictionary<string, String> RetornarInformacionDeLaEmpresa()
        {
            SolicitudDeInformacionDB();
            return _InformacionEmpresa;
        }
    }
}
