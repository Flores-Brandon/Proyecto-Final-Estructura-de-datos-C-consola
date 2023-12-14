﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    public class SubMenu_CL
    {
        public static string Name = "Circular List";

        public static Random _Random = new Random();
        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static CircularList<int> _Items = new CircularList<int>();

        public static string[] _OptionList = _Information.List;

        public SubMenu_CL() { }

        public void MenuOption(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_OptionList, Name);
                Console.Write("Write the number of one option: ");
                Operation = Option(Operation);
            } while (Operation != _OptionList.Length - 1);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumOperationsList)option;
            Console.Clear();
            Methos(x);
            return option;
        }

        private void Methos(EnumOperationsList Lists)
        {
            int Data = 0;
            switch (Lists)
            {
                case EnumOperationsList.Generate:
                    Console.Write("Generate: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    for (int i = 0; i < Data; i++)
                    {
                        _Items.Add(_Random.Next(100000));
                    }
                    Console.WriteLine("Finish");
                    Console.ReadKey();
                    break;

                case EnumOperationsList.Add:
                    Console.Write("Insertar Dato: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Add(Data);
                    break;

                case EnumOperationsList.Delete:
                    Console.Write("Eliminar un dato: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Delete(Data);
                    break;

                case EnumOperationsList.Search:
                    Console.Write(" Buscar un dato: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Search(Data);
                    break;

                case EnumOperationsList.Show:
                    _Items.Show();
                    Console.ReadKey();
                    break;

                case EnumOperationsList.ShowRevers:
                    _Items.ShowRevers();
                    Console.ReadKey();
                    break;

                case EnumOperationsList.Clear:
                    _Items.Clear();
                    break;
            }
        }
    }
}