using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {CPF}, Profissão: {Profissao}";
        }
    }
}
