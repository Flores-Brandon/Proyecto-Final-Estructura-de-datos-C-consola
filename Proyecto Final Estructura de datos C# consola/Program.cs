
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Option;
            MenuStructures Menu = new MenuStructures();
            do
            {
                Option = 0;
                Menu.PrintArray(Menu._TypeDataStructures, Menu.Name);
                Console.Write("Escribe el número de una opción: ");
                Option = Menu.Option(Option);
            } while (Option != 6);
        }
    }
}
