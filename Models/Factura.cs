﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_.Models
{
    [Table("Factura")]
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }

        [ForeignKey("ClienteId")]
        public int Cliente { get; set; }

        [ForeignKey("PedidoId")]
        public int PedidoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFactura { get; set; }
        public bool Estado { get; set; }
        public decimal Total  { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

    }
}