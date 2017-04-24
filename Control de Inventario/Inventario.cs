using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Inventario
{
    class Inventario
    {
        int tamaño = 0;
        Producto[] inventario = new Producto[15];

        public void Agregar(Producto producto)
        {
            int contador = 0;
            if (tamaño == 0)
            {
                inventario[tamaño] = producto;
                tamaño++;
            }
            else
            {
                for (int i = 0; i < tamaño; i++)                
                    if (inventario[i].regresarCodigo() == producto.regresarCodigo())                    
                        contador = 1;
                if (contador != 1)
                {
                    inventario[tamaño] = producto;
                    tamaño++;
                }                                   
            }
            
        }

        public void Eliminar(int codigo)
        {
            for (int i = 0; i < tamaño; i++)            
                if (inventario[i].regresarCodigo() == codigo)
                {
                    while (i < tamaño)
                    {
                        inventario[i] = inventario[i + 1];
                        i++;
                    }
                    inventario[tamaño] = null;
                    tamaño--;
                }            
        }

        public Producto Buscar(int codigo)
        {
            int saber = 0, i;

            for (i = 0; i < tamaño && saber != 1; i++)            
                if (inventario[i].regresarCodigo() == codigo)                
                    saber = 1;                
                else                
                    saber = 0;
            if (saber == 1)
                return inventario[i - 1];
            else
                return null;             
        }

        public string Reporte()
        {
            string cadena="";
            for (int i = 0; i < tamaño; i++)            
                cadena += inventario[i].ToString() + Environment.NewLine;            
            return cadena;
        }

        public void Insertar(Producto producto, int posición)
        {
            Producto auxiliar;
            tamaño++;
            if (tamaño <= posición)
                inventario[tamaño - 1] = producto;
            else
                for (int i = posición - 1; i < tamaño; i++)
                {
                    auxiliar = inventario[i];
                    inventario[i] = producto;
                    producto = auxiliar;
                }
        }
    }
}
