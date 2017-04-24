using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        private int _codigo { get; }
        private string _nombre { get; }
        private int _cantidad { get; }
        private int _precio { get; }
        public Producto siguiente;

        public Producto(int codigo, string nombre, int cantidad, int precio)
        {

            this._codigo = codigo;
            this._nombre = nombre;
            this._cantidad = cantidad;
            this._precio = precio;
            siguiente = null;
        }


        public int regresaCodigo()
        {
            return _codigo;
        }

        public string regresaNombre()
        {
            return _nombre;
        }

        public int regresaCantidad()
        {
            return _cantidad;
        }

        public int regresaPrecio()
        {
            return _precio;
        }

        public override string ToString()
        {
            return _codigo + " " + _nombre + " " + _cantidad + " " + _precio;
        }
    }
}
