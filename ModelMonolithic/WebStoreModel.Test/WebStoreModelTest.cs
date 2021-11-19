using NUnit.Framework;
using System.Collections.Generic;

namespace WebStoreModel.Test
{
    public class Tests
    {
        DataBaseNoSql webStoreModel;
        [SetUp]
        public void Setup()
        {
            webStoreModel = new DataBaseNoSql();
        }

        [Test]
        public void ObtenerProdcutosDeLaBD()
        {
            var Auxiliar =webStoreModel.RetornarListaDeProductos();
            string[] Productos ={ "Producto: Manzana y su precio: 100", "Producto: Pera y su precio: 150" };

            Assert.AreEqual(Auxiliar, Productos);
        }
        [Test]
        public void ObtenerInformacionDeLaEmpresa()
        {
            var Auxiliar = webStoreModel.RetornarInformacionDeLaEmpresa();
            Dictionary<string, string> Informacion = new Dictionary<string, string>()
            {
                {"Direccion", "Torre Sofia"},
                {"Telefono", "74747474" }
            };
            Assert.AreEqual(Auxiliar, Informacion);
        }
    }
}