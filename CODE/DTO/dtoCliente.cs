﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CamadasJeiel.CODE.DTO
{
    internal class dtoCliente
    {
        int id_cliente;
        string nome;
        string email;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
    }
}
