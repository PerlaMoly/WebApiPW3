using claseServicio.Models;
using System;
using System.Linq;




namespace claseServicio.Servicios
{
    public class LoginServicio : ILoginServicio
    {
        private readonly _20211CTPContext _dBcontext;
        
        public LoginServicio(_20211CTPContext dBContext)
        {
            _dBcontext = dBContext;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }


        //public string Ingresar(string mail, string pass)
        public bool Ingresar(string mail, string pass,out Usuario usuarioEncontrado)
        {

            usuarioEncontrado = _dBcontext.Usuarios.FirstOrDefault(o => o.Email == mail && o.Password == pass);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado != null;

             }
            return false;
        }

    }
}
