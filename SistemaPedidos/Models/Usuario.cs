using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPedidos.Models
{
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        public string NombreCom { get; set; }
        public string NombreUsu { get; set; }
        public string Contraseña { get; set; }
        public virtual ICollection<Pedido> ListaPedido { get; set; }
    }
}