using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura_de_datos_C__consola
{
    internal class Nodoo
    {
        public Nodoo Left { get; set; }
        public Nodoo Right { get; set; }
        public int Data { get; set; }

        public Nodoo(int Data)
        {
            this.Data = Data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        private Nodoo Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Add(int valor)
        {
            Root = _Add(Root, valor);
        }

        public void Delete(int valor)
        {
            Root = _Delete(Root, valor);
        }

        public bool Search(int valor)
        {
            return _Search(Root, valor);
        }

        public void PreOrden()
        {
            _PreOrden(Root);
            Console.WriteLine();
        }

        public void PostOrden()
        {
            _PostOrder(Root);
            Console.WriteLine();
        }

        public void InOrden()
        {
            _InOrder(Root);
            Console.WriteLine();
        }

        private Nodoo _Add(Nodoo nodo, int valor)
        {
            if (nodo == null)
            {
                return new Nodoo(valor);
            }

            if (valor < nodo.Data)
            {
                nodo.Left = _Add(nodo.Left, valor);
            }
            else if (valor > nodo.Data)
            {
                nodo.Right = _Add(nodo.Right, valor);
            }
            return nodo;
        }

        private Nodoo _Delete(Nodoo nodo, int valor)
        {
            if (nodo == null)
            {
                return nodo;
            }
            if (valor < nodo.Data)
            {
                nodo.Left = _Delete(nodo.Left, valor);
            }
            else if (valor > nodo.Data)
            {
                nodo.Right = _Delete(nodo.Right, valor);
            }
            else
            {
                if (nodo.Left == null)
                {
                    return nodo.Right;
                }
                else if (nodo.Right == null)
                {
                    return nodo.Left;
                }
                nodo.Data = MinValue(nodo.Right);
                nodo.Right = _Delete(nodo.Right, nodo.Data);
            }
            return nodo;
        }

        private int MinValue(Nodoo nodo)
        {
            int min = nodo.Data;
            while (nodo.Left != null)
            {
                min = nodo.Left.Data;
                nodo = nodo.Left;
            }
            return min;
        }

        private bool _Search(Nodoo nodo, int valor)
        {
            if (nodo == null)
            {
                return false;
            }

            if (valor == nodo.Data)
            {
                return true;
            }

            if (valor < nodo.Data)
            {
                return _Search(nodo.Left, valor);
            }
            else
            {
                return _Search(nodo.Right, valor);
            }
        }

        private void _PreOrden(Nodoo Tree)
        {
            if (Tree != null)
            {
                Console.Write(Tree.Data + " ");
                _PreOrden(Tree.Left);
                _PreOrden(Tree.Right);
            }
        }

        private void _PostOrder(Nodoo Tree)
        {
            if (Tree != null)
            {
                _PostOrder(Tree.Left);
                _PostOrder(Tree.Right);
                Console.Write(Tree.Data + " ");
            }
        }

        private void _InOrder(Nodoo Tree)
        {
            if (Tree != null)
            {
                _InOrder(Tree.Left);
                Console.Write(Tree.Data + " ");
                _InOrder(Tree.Right);
            }
        }
    }
}