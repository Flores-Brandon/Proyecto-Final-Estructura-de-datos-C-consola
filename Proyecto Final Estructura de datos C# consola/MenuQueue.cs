using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    public class MenuQueue
    {
        public static string Name = "Queue";

        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static SubMenuQueue _SubMenuQueue = new SubMenuQueue();
        public static SubMenuCircularQueue _SubMenuCircular = new SubMenuCircularQueue();
        public static SubMenuPriorityQueue _SubMenuPriorityQueue = new SubMenuPriorityQueue();

        public static string[] _TypeQueue = _Information.TypeQueue;

        public MenuQueue() { }

        public void CycleQueue(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_TypeQueue, Name);
                Console.Write("Escribe el número de una opción: ");
                Operation = Option(Operation);
            } while (Operation != _TypeQueue.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumTypeQueue)option;
            Console.Clear();
            Menu(option, x);
            return option;
        }

        private void Menu(int Numer, EnumTypeQueue Stacks)
        {
            switch (Stacks)
            {
                case EnumTypeQueue.Queue:
                    _SubMenuQueue.MenuOption(Numer);
                    break;

                case EnumTypeQueue.CircularQueue:
                    _SubMenuCircular.MenuOption(Numer);
                    break;

                case EnumTypeQueue.PriorityQueues:
                    _SubMenuPriorityQueue.MenuOption(Numer);
                    break;
            }
        }
    }
}