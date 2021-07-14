using System;
using System.Collections.Generic;

#nullable disable

namespace claseServicio.Models
{
    public partial class PedidoArticuloDTO
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
