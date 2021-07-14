using System;
using System.Collections.Generic;

#nullable disable

namespace claseServicio.Models
{
    public partial class ResponsePedidos
    {
        public ResponsePedidos()
        {

        }
        public int count { get; set; }
        public List<PedidosDTO> items { get; set; }

    }
}
