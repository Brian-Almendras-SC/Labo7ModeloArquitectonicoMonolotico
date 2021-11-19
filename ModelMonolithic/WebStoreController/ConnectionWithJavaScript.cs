using System;
using System.Collections.Generic;
using System.Text;
using WebStoreModel;
using WebStoreView;

namespace WebStoreController
{
    public class ConnectionWithJavaScript
    {

        private HTMLANDCSS _vista;
        private DataBaseNoSql _modelo;
        public ConnectionWithJavaScript(HTMLANDCSS Vista, DataBaseNoSql Modelo)
        {
            _vista = Vista;
            _modelo = Modelo;
        }
        public void LlamarInicio()
        {

            while (true)
            {
                var Opcion = _vista.Shop();
                switch (Opcion)
                {
                    case "Inicio":
                        LlamarInicio();
                        break;
                    case "Productos":
                        SolicitarListaDeProductos();
                        break;
                    case "Contactenos":
                        Contactanos();
                        break;
                }
            }
        }
        public void SolicitarListaDeProductos()
        {
            var Auxiliar = _modelo.RetornarListaDeProductos();
            _vista.Productos(Auxiliar);
        }
        public void Contactanos()
        {
            var Auxiliar = _modelo.RetornarInformacionDeLaEmpresa();
            _vista.Contactenos(Auxiliar);
        }
    }
}
