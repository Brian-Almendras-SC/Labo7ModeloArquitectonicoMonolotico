using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreView
{
    public class HTMLANDCSS
    {
        public string DireccionHttp()
        {
            return "http:/WebStore.html";
        }
        public string Shop()
        {
            Console.Write("WebStore");
            Console.WriteLine(" Inicio Productos Contactenos");
            Console.WriteLine("Donde desea ir");
            String aux = Console.ReadLine();
            return aux;
        }
        public void Productos(String[] productos)
        {
            foreach (var item in productos)
            {
                Console.WriteLine(item);
            }
        }
        public void Contactenos(Dictionary<string, string> informacion)
        {
            String direccion = "";
            foreach (var item in informacion)
            {
                direccion = direccion + $"{item.Key}: {item.Value}\n";
            }
            Console.WriteLine(direccion);
        }
    }
}
