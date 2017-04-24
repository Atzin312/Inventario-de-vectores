using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Inventario
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;

        public Producto (int codigo, string nombre, int cantidad, int costo)
        {
            this. _codigo = codigo;
            this. _nombre = nombre;
            this._cantidad = cantidad;
            this._costo = costo;
        }

        public int regresarCodigo()
        {
            return _codigo;
        }

        public string regresarNombre()
        {
            return _nombre;
        }

        public int regresarCantidad()
        {
            return _cantidad;
        }

        public int regresarCosto()
        {
            return _costo;
        }

        public override string ToString()
        {
            return _codigo + " " + _nombre + " " + _cantidad + " " + _costo;
        }
    }
}
