using System;
using WebStoreModel;
using WebStoreView;

namespace WebStoreController
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DataBaseNoSql webStoreModel = new DataBaseNoSql();
            HTMLANDCSS webStoreView = new HTMLANDCSS();
            ConnectionWithJavaScript webStore = new ConnectionWithJavaScript(webStoreView, webStoreModel);

            webStore.LlamarInicio();
        }
    }
}
