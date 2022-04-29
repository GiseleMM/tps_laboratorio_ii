﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            //Moto, Automovil, Camioneta, Todos
            Ciclomotor,Sedan,SUV,Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        //public Taller(int espacioDisponible)
        public Taller (int espacioDisponible): this( )
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return Taller.Listar(this,ETipo.Todos);
            return   Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipoParaMostrar)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                if(v is Ciclomotor && (tipoParaMostrar.ToString() == "Ciclomotor"))
                {
                    sb.AppendLine(v.Mostrar());

                }
                if(v is Suv && (tipoParaMostrar.ToString() == "SUV"))
                {
                    sb.AppendLine(v.Mostrar());
                }
                if(v is Sedan && (tipoParaMostrar.ToString()== "Sedan"))
                {
                    sb.AppendLine(v.Mostrar());
                }
                if(tipoParaMostrar.ToString() == "Todos")
                {
                    sb.AppendLine(v.Mostrar());
                }
              
                    //case ETipo.Camioneta:
                    //    sb.AppendLine(v.Mostrar());
                    //    break;
                    //case ETipo.Moto:
                    //    sb.AppendLine(v.Mostrar());
                    //    break;
                    //case ETipo.Automovil:
                    //    sb.AppendLine(v.Mostrar());
                    //    break;
                    //default:
                    //    sb.AppendLine(v.Mostrar());
                    //    break;

                   

                
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            //foreach (Vehiculo v in taller)
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo || taller.vehiculos.Count == taller.espacioDisponible)
                    return taller;
            }

            taller.vehiculos.Add(vehiculo);
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            //foreach (Vehiculo v in taller)
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    int indice = taller.vehiculos.IndexOf(v);
                    if(indice!=-1)
                    {
                        taller.vehiculos.RemoveAt(indice);
                    }
                    //agrego remove
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
