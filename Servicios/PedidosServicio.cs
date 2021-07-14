using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using claseServicio.Models;
using claseServicio.Servicios;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace claseServicio.Servicios
{
    public class PedidosServicio: IPedidosServicio
    {
        private _20211CTPContext _dBcontext;
        
        public PedidosServicio(_20211CTPContext dBContext)
        {
            _dBcontext = dBContext;
        }

        public ResponsePedidos Buscar(int IdCliente, int IdEstado)
        {
            ResponsePedidos response = new ResponsePedidos();

            response.items = _dBcontext.Pedidos
                .Where(p => p.IdCliente == IdCliente && p.IdEstado == IdEstado)
                .Select(p => new PedidosDTO {
                    IdPedido = p.IdPedido,
                    IdCliente = p.IdCliente,
                    Estado = p.IdEstadoNavigation.Descripcion,
                    FechaModificacion = p.FechaModificacion,
                    ModificadoPor = new ModificadoPorDTO {
                        Email = p.ModificadoPorNavigation.Email,
                        IdUsuario = p.ModificadoPorNavigation.IdUsuario,
                        Nombre = p.ModificadoPorNavigation.Nombre,
                        Apellido = p.ModificadoPorNavigation.Apellido,
                        FechaNacimiento = p.ModificadoPorNavigation.FechaNacimiento
                    },
                    Articulos = p.PedidoArticulos.Select(a => new PedidoArticuloDTO {
                        IdArticulo = a.IdArticulo,
                        Codigo = a.IdArticuloNavigation.Codigo,
                        Descripcion = a.IdArticuloNavigation.Descripcion,
                        Cantidad = a.Cantidad
                    }),
                })
                .ToList();

            response.count = _dBcontext.Pedidos
                .Where(p => p.IdCliente == IdCliente && p.IdEstado == IdEstado)
                .Count();

            return response;
        }

    }
}
