using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models.Usuarios
{
    public class RegistroWebModelInput
    {
        public string Login { get; set; }

        public string Email { get; set; }
        

        public string Senha { get; set; }
    }
}
