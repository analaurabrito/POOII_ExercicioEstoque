using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTel003
{
    public class Login
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public Login()
        {

        }

        public Login(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
