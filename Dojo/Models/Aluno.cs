using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dojo.Models
{
    public class Aluno
    {

        public Faixa Faixa { get; set; }

        public TipoDeAssociacao TipoDeAssociacao { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

    }
}