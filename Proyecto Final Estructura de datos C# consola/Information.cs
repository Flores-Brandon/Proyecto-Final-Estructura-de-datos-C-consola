﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    public enum EnumDataStructures
    {
        None,
        Stack,
        Queues,
        List,
        Tree,
        Graph,
        Salir
    }

    #region Types
    public enum EnumTypeStack
    {
        None,
        StackStatic,
        StackDinamic
    }

    public enum EnumTypeQueue
    {
        None,
        Queue,
        CircularQueue,
        PriorityQueues
    }

    public enum EnumTypeList
    {
        None,
        SimpleList,
        CircularList,
        DoubleLinkdeList,
        CircularDoubleLinkedList
    }

    public enum EnumTypeGraph
    {
        None,
        DirectedGraph,
        UndirectedGraph
    }
    #endregion

    #region Operations
    public enum EnumOperationsStack
    {
        Generate,
        Push,
        Pop,
        Peek,
        Contains,
        Show
    }

    public enum EnumOperationsQueue
    {
        Generate,
        Enqueue,
        Dequeue,
        Show,
        Clear
    }

    public enum EnumOperationsList
    {
        Generate,
        Add,
        Delete,
        Search,
        Show,
        ShowRevers,
        Clear
    }

    public enum EnumOperationsTree
    {
        None,
        Add,
        Delete,
        Search,
        InOrder,
        PosOrder,
        PreOrder
    }

    public enum EnumOperationsGraph
    {
        None,
        AddVertex,
        AddEdge,
        RemoveVertex,
        RemoveEdge,
        ExistVertex,
        ExistEdge,
        GetAllVertex,
        GetAllEdge,
        Transverse,
        CalculateDegree,
        CalculateBFSLevels
    }
    #endregion

    public class Information
    {
        public string[] TypeDataStructures =
        {
            "[1]Stack",
            "[2]Queues",
            "[3]List",
            "[4]Tree",
            "[5]Graph",
            "[6]Salir"

        };



        #region Types
        public string[] TypeStack =
        {
            "[1]StackStatic",
            "[2]StackDinamic",
            "[3]Salir"
        };

        public string[] TypeQueue =
        {
            "[1]Queue",
            "[2]CircularQueue",
            "[3]PriorityQueues",
            "[4]Salir"
        };

        public string[] TypeList =
        {
            "[1]SimpleList",
            "[2]CircularList",
            "[3]DoubleLikedList",
            "[4]CirculasDoubleLikedList",
            "[5]Salir"
        };

        public string[] TypeGraph =
        {
            "[1]DirectedGraph",
            "[2]UnidirectedGraph",
            "[3]Salir"
        };
        #endregion


        #region Operations
        public string[] Stack =
        {
            "[0]Geneate",
            "[1]Push",
            "[2]Pop",
            "[3]Peek",
            "[4]Contains",
            "[5]Show",
            "[6]Salir"
        };

        public string[] Queue =
        {
            "[0]Geneate",
            "[1]Enqueue",
            "[2]Dequeue",
            "[3]Show",
            "[4]Clear",
            "[5]Salir"
        };

        public string[] List =
        {
            "[0]Geneate",
            "[1]Add",
            "[2]Delete",
            "[3]Search",
            "[4]Show",
            "[5]Show revers",
            "[6]Clear",
            "[7]Salir"
        };

        public string[] Tree =
        {
            "[1]Add",
            "[2]Delete",
            "[3]Search",
            "[4]InOrder",
            "[5]PostOrder",
            "[6]PreOrder",
            "[7]Salir"
        };

        public string[] Graph =
        {
            "[1]Add Vertex",
            "[2]Add Edge",
            "[3]Remove Vertex",
            "[4]Remove Edge",
            "[5]Exist Vertex",
            "[6]Exist Edge",
            "[7]Get All Vertex",
            "[8]Get All Edge",
            "[9]Transverse",
            "[10]Calculate Degree",
            "[11]Calculate BFS Levels",
            "[12]Salir"
        };
        #endregion

        public Information() { }
    }
}