﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models.Usuarios
{
    public class LoginWebModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string senha { get; set;}
    }
}
