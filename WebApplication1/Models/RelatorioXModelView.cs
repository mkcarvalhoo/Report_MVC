using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RelatorioXModelView
    {
        public string Estado { get; set; }
        public IEnumerable<Cidade> ListaCidades { get; set; }
        public int QtdeDias { get; set; }
    }

    public class Cidade
    {
        public string Nome { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<Dias> ListaDias { get; set; }
    }

    public class Dias
    {
        public string Dia { get; set; }
        public decimal Valor { get; set; }
    }

    public class DiasIndicadorEva
    {
        public string UnidadeNome { get; set; }
        public string Tipo { get; set; }
        public string UnidadeMedida { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

    }

    public class DiasIndicadorEvaLista
    {
        public string UnidadeNome { get; set; }
        public IEnumerable<Tipo> Tipo { get; set; }
        
        
    }

    public class Tipo
    {
        public string Tipos { get; set; }
        public string UnidadeMedida { get; set; }
        public IEnumerable<DiaValor> DiaValor { get; set; }

    }

    public class DiaValor
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

    }
}