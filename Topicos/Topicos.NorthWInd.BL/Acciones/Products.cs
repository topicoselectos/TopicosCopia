using System;
using System.Collections.Generic;
using System.Text;

namespace Topicos.NorthWInd.BL.Acciones
{
    internal class Products
    {
        private NorthWind.BaseDatos.Models.NorthWindContext context;

        public Products(NorthWind.BaseDatos.Models.NorthWindContext context)
        {
            this.context = context;
        }

        public NorthWind.BaseDatos.Models.Products ObtenerProductosPorId(int id)
        {
            NorthWind.BaseDatos.Models.Products elResultado;
            var elRepositorio = new Repositorio.Products();
            elResultado = elRepositorio.ObtenerProductosPorId(id);
            return elResultado;
        }

        internal NorthWind.BaseDatos.Models.Products ObtenerProductoPorId(int id)
        {
            NorthWind.BaseDatos.Models.Products elResultado;
            var elRepositorio = new Repositorio.Products();
            elResultado = elRepositorio.ObtenerProductosPorId(id);
            return elResultado;

        }
    }
}
