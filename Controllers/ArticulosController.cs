using claseServicio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace claseServicio.Controllers
{
    public class ArticulosController : Controller
    {
        private _20211CTPContext _dbContext;
        private ArticuloDTO _articuloDTO;

        public ArticulosController(_20211CTPContext dbContext)
        {
            _dbContext = dbContext;
            _articuloDTO = new ArticuloDTO();
        }

        [HttpGet]
        public List<ArticuloDTO> ObtenerArticulos()
        {
            return _dbContext.Articulos
               .Select(a => new ArticuloDTO { IdArticulo = a.IdArticulo, Codigo = a.Codigo, Descripcion = a.Descripcion }).ToList(); ;
        }

        [HttpPost]
        public List<ArticuloDTO> FiltroArticulos(String filtro)
        {
            return _dbContext.Articulos
                .Where(f => f.Descripcion.Contains(filtro))
               .Select(a => new ArticuloDTO { IdArticulo = a.IdArticulo, Codigo = a.Codigo, Descripcion = a.Descripcion }).ToList(); ;
        }
    }
}
