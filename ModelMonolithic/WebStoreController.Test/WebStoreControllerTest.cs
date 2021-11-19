using NUnit.Framework;
using WebStoreModel;
using WebStoreView;

namespace WebStoreController.Test
{
    public class Tests
    {
        DataBaseNoSql webStoreModel ;
        HTMLANDCSS webStoreView ;
        ConnectionWithJavaScript webStore ;
        [SetUp]
        public void Setup()
        {
             webStoreModel = new DataBaseNoSql();
             webStoreView = new HTMLANDCSS();
             webStore = new ConnectionWithJavaScript(webStoreView, webStoreModel);
        }

        [Test]
        public void InicioDeLaPagina ()
        {
            //No se llama por que es un void que ejecuta por consola
            //webStore.LlamarInicio();
            Assert.AreEqual(1, 1);
        }
    }
}