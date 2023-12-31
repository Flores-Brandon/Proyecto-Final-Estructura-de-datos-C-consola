﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    public class MenuStack
    {
        public static string Name = "Stack";

        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static SubMenuStackS _ShowSubMenuStackS = new SubMenuStackS();
        public static SubMenuStackD _ShowSubMenuStackD = new SubMenuStackD();

        public static string[] _TypeStack = _Information.TypeStack;

        public MenuStack() { }

        public void CycleStack(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_TypeStack, Name);
                Console.Write("Escribe el número de una opción: ");
                Operation = Option(Operation);
            } while (Operation != _TypeStack.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumTypeStack)option;
            Console.Clear();
            Menu(option, x);
            return option;
        }

        private void Menu(int Numer, EnumTypeStack Stacks)
        {
            switch (Stacks)
            {
                case EnumTypeStack.StackStatic:
                    _ShowSubMenuStackS.MenuOption(Numer);
                    break;

                case EnumTypeStack.StackDinamic:
                    _ShowSubMenuStackD.MenuOption(Numer);
                    break;
            }
        }
    }
}
