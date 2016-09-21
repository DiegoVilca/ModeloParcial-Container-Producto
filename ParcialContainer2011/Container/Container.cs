using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;


        //Constructor

        public Container(int capacidad, string Empresa)
        {
            this._listaProductos = new List<Producto>();
            this._capacidad = capacidad;
            this._empresa = Empresa;
        }


        #region Metodos

        public bool Agregar(Producto proUno)
        {
            foreach (Producto item in this._listaProductos)
            {
                if (item == proUno)
                    return false;
                
            }

            if (this._capacidad > this._listaProductos.Count)
            {
                this._listaProductos.Add(proUno);
                return true;
            }

            return false;


        }

        public static void Mostrar(Container Contenedor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-__-__Container__-__-");
            sb.AppendLine("Empresa: " + Contenedor._empresa);
            sb.AppendLine("Capacidad: " + Contenedor._capacidad);
            sb.Append("Productos:");
            
            Console.WriteLine(sb.ToString());

            foreach (Producto item in Contenedor._listaProductos)
            {
                item.mostrar();
            }

        }

        

        #endregion Metodos




        #region Sobrecargas

        public static List<Producto> operator -(Container contenedorUno, eTipoComestible tipo)
        {
            List<Producto> miLista = new List<Producto>();

            foreach (Producto item in contenedorUno._listaProductos)
            {
                if(item == tipo)
                    miLista.Add(item);
            }

            return miLista;
        }


        public static bool operator ==(Container contenedor, Producto proUno)
        {
            foreach (Producto item in contenedor._listaProductos)
            {
                if (item == proUno)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Container contenedor, Producto proUno)
        {
            return !(contenedor == proUno);
        }


        #endregion Sobrecargas

    }
}
