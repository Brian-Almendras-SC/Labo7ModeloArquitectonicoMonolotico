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
            string Direcci�n = "http:/WebStore.html";
            Assert.Pass(Auxiliar, Direcci�n);
        }
    }
}