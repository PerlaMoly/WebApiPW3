using claseServicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace claseServicio.Servicios
{

   public interface IPedidosServicio
   {
        ResponsePedidos Buscar(int IdCliente, int IdEstado); 
   }
}