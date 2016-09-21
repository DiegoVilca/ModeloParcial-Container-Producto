using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        #region Constructores


        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo) :this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio) :this(codigoDeBarra,nombre,tipo)
        {
            this._precio = precio;
        }

        #endregion Constructores


        //Metodos
        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Tipo: " + this._tipo);
            sb.AppendLine("Codigo: " + this._codigoDeBarra);
            sb.Append("Precio: " + this._precio);
            
            Console.WriteLine(sb.ToString());
        }


        #region Sobrecargas

        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            if (proUno._tipo == tipo)
                return true;
            return false;
        }

        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        { 
            return !(proUno == tipo);
        }


        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno._codigoDeBarra == proDos._codigoDeBarra)
                return true;
            return false;
        }

        public static bool operator !=(Producto proUno, Producto proDos)
        {
            return !(proUno == proDos);
        }


        #endregion Sobrecargas

        /*
         * Temas parcial
         * 
         * creacion constructor, constructor correcto, que es constructor correcto
         * sobrecarga operadores
         * sobrecargar un operador implicito clase ppuerta que me lo transforme a string
         * arrays, como crearlo y como recorrerlo
         * metodo de instancia, metodo estatico
         * utilizacion del this
         * constructores estaticos
         * propiedades de lectura, escritura
         * (conceptualmente) diferencias o igualdades entre por ejemplo, met estatico y de instancia
         * similitudes: estan en la misma clase, reciben parametros
         * diferencias: a uno se lo llama con la Clase. al otro hay que instanciarlo
         * dif/igual clase-objeto, propidad-atributo, constructor-metodo
         * errores de sintaxis
         * Que muestra un codigo
         * 
         * Alumno A = new alumno();
         * A.nombre = "Jose";
         * Alumno B= (string) "pepe";
         * Alumno C = new alumno();
         * c.nombre = "Maria";
         * Alumno d = new Allumno()
         * 
         * b=a
         * d=b
         * 
         * a.nombre = "natalia";
         * //ver referencia, copias
         * console.(d.nombre)
         * 
         * ///////////////////////////////////
         * 
         * Siete puntos
         * 
         * 
         * 
         */

    }
}
