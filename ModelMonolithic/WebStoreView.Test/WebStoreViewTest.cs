using NUnit.Framework;

namespace WebStoreView.Test
{
    public class Tests
    {
        HTMLANDCSS webStoreView;
        [SetUp]
        public void Setup()
        {
            webStoreView = new HTMLANDCSS();
 
        }

        [Test]
        public void ObtenerLaDireccionWeb()
        {
            var Auxiliar=webStoreView.DireccionHttp();
            string Dirección = "http:/WebStore.html";
            Assert.Pass(Auxiliar, Dirección);
        }
    }
}