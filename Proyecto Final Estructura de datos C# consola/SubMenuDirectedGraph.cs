﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{

    public class SubMenuDirectedGraph
    {
        public static string Name = "Directed Graph";

        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static DirectedGraph<int> _Items = new DirectedGraph<int>();

        public static string[] _Option = _Information.Graph;

        public SubMenuDirectedGraph() { }

        public void Menu(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_Option, Name);
                Console.Write("Escribe el número de una opción: ");
                Operation = Option(Operation);
            } while (Operation != _Option.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumOperationsGraph)option;
            Console.Clear();
            Methos(x);
            return option;
        }

        private void Methos(EnumOperationsGraph Stack)
        {
            int DataF = 0, DataS = 0;
            switch (Stack)
            {
                case EnumOperationsGraph.AddVertex:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.AddVertex(DataF);
                    break;

                case EnumOperationsGraph.AddEdge:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    Console.WriteLine("Segundo Dato: ");
                    try { DataS = int.Parse(Console.ReadLine()); } catch { }
                    _Items.AddEdge(DataF, DataS);
                    break;

                case EnumOperationsGraph.RemoveVertex:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.RemoveVertex(DataF);
                    break;

                case EnumOperationsGraph.RemoveEdge:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    Console.WriteLine("Segundo Dato: ");
                    try { DataS = int.Parse(Console.ReadLine()); } catch { }
                    _Items.RemoveEdge(DataF, DataS);
                    break;

                case EnumOperationsGraph.ExistVertex:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.VertexExists(DataF);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.ExistEdge:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    Console.WriteLine("Segundo Dato: ");
                    try { DataS = int.Parse(Console.ReadLine()); } catch { }
                    _Items.EdgeExists(DataF, DataS);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.GetAllVertex:
                    Console.WriteLine("Obtener todos los vértices");
                    _Items.GetAllVertices();
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.GetAllEdge:
                    Console.WriteLine("Obtener todos los bordes");
                    _Items.GetAllEdges();
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.Transverse:
                    Console.WriteLine("Dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.TraverseBFS(DataF);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.CalculateDegree:
                    Console.WriteLine("Insertar un dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.CalculateDegree(DataF);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.CalculateBFSLevels:
                    Console.WriteLine("Insertar un dato: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.CalculateBFSLevels(DataF);
                    Console.ReadKey();
                    break;
            }
        }
    }
}