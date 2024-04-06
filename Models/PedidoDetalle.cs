using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_.Models
{
    public class PedidoDetalle
    {
        public int PedidoDetale { get; set; }
        [ForeignKey("PedidoId")]
        public int PedidoId { get; set; }

        public DateTime FechaCreacion{ get; set; }
        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total{ get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
       
    }
}