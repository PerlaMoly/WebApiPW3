﻿using System;
using System.Collections.Generic;

#nullable disable

namespace claseServicio.Models
{
    public partial class PedidosDTO
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public virtual ModificadoPorDTO? ModificadoPor { get; set; }
        public virtual IEnumerable<PedidoArticuloDTO> Articulos { get; set; }
    }
}
