﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    public class MenuList
    {
        public static string Name = "List";

        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static SubMenu_SL _ShowSubMenu_SL = new SubMenu_SL();
        public static SubMenu_CL _ShowSubMenu_CL = new SubMenu_CL();
        public static SubMenu_DLL _ShowSubMenu_DLL = new SubMenu_DLL();
        public static SubMenu_CDLL _ShowSubMenu_CDLL = new SubMenu_CDLL();

        public string[] _TypeList = _Information.TypeList;
        public static string[] _OptionList = _Information.List;

        public MenuList() { }

        public void CycleList(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_TypeList, Name);
                Console.Write("Escribe el número de una opción: ");
                Operation = Option(Operation);
            } while (Operation != _TypeList.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumTypeList)option;
            Console.Clear();
            Menu(option, x);
            return option;
        }

        private void Menu(int Numer, EnumTypeList Lists)
        {
            switch (Lists)
            {
                case EnumTypeList.SimpleList:
                    _ShowSubMenu_SL.MenuOption(Numer);
                    break;

                case EnumTypeList.CircularList:
                    _ShowSubMenu_CL.MenuOption(Numer);
                    break;

                case EnumTypeList.DoubleLinkdeList:
                    _ShowSubMenu_DLL.MenuOption(Numer);
                    break;

                case EnumTypeList.CircularDoubleLinkedList:
                    _ShowSubMenu_CDLL.MenuOption(Numer);
                    break;
            }
        }
    }
}