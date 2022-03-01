using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaPedidos.Models
{
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string UnidadMedida { get; set; }
        public string ValorNeto { get; set; }
        public virtual Pedido VirtualPedido { get; set; }
    }
}