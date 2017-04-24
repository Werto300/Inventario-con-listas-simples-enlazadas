using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        Producto inicio, temp;

        public Inventario()
        {
            inicio = temp = null;
        }
        
        public void Agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                temp.siguiente = nuevo;
            }
            temp = nuevo;
        }



        public void Eliminar(int codigo)
        {
            if (inicio != null)
            {
                Producto actual, padre;
                padre = BuscarPadre(codigo);
                if (padre == temp)
                {
                    return;
                }
                if (padre == null)
                {
                    actual = inicio;
                    inicio = inicio.siguiente;
                    padre = inicio;
                }
                else
                {
                    actual = padre.siguiente;
                    padre.siguiente = actual.siguiente;
                }
                actual = null;
                if (padre == null || padre.siguiente == null)
                {
                    temp = padre;
                }
            }
        }

        private Producto BuscarPadre(int codigo)
        {
            Producto padre, actual;
            actual = inicio;
            padre = null;
            while (actual != null)
            {
                if (actual.regresaCodigo() == codigo)
                {
                    break;
                } 
                padre = actual;
                actual = actual.siguiente;
            }
            return padre;
        }

        public Producto Buscar(int codigo)
        {
            Producto actual = inicio;
            while (actual != null)
            {
                if (actual.regresaCodigo() == codigo)
                {
                    return actual;
                }
                actual = actual.siguiente;
            }
            return null;
        }

        public string Reporte()
        {
            string salida = " ";
            if (inicio != null)
            {
                Producto actual = inicio;
                while (actual != null)
                {
                    salida += actual.ToString() +Environment.NewLine;
                    actual = actual.siguiente;
                }
            }
            return salida;
        }

        public void Insertar(Producto nuevo, int pos)
        {
            //int posActual = 1;
            //Producto auxiliar;
           
            //while (inicio != null)
            //{
            //    if (posActual == pos)
            //    {
            //        while (inicio != null)
            //        {
            //            auxiliar = inicio;
            //            inicio.siguiente = nuevo;
            //            nuevo = auxiliar;
            //        }
            //        break;
            //    }
            //    posActual++;
            //    inicio = inicio.siguiente;
            //}
        }
    }
}
