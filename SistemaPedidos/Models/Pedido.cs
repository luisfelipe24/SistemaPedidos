using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPedidos.Models
{
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoID { get; set; }
        public DateTime FechaPedido { get; set; }
        public string NombreCliente { get; set; }
        public int IDCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string Moneda { get; set; }
        public virtual Usuario VirtualUsuario { get; set; }
        public virtual ICollection<Producto> ListaProductos { get; set; }
    }
}