using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RelatorioXController : Controller
    {
        // GET: RelatorioX
        public ActionResult Index()
        {
            List<DiasIndicadorEva> diasIndicadorEva = new List<DiasIndicadorEva>();

            DiasIndicadorEva diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Agua";
            diasIndicador.UnidadeMedida = "M³";
            diasIndicador.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("3,62");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Agua";
            diasIndicador.UnidadeMedida = "M³";
            diasIndicador.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("5,02");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Agua";
            diasIndicador.UnidadeMedida = "M³";
            diasIndicador.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("12,62");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Energia";
            diasIndicador.UnidadeMedida = "Kwh";
            diasIndicador.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("15,22");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Energia";
            diasIndicador.UnidadeMedida = "Kwh";
            diasIndicador.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("3,00");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Energia";
            diasIndicador.UnidadeMedida = "Kwh";
            diasIndicador.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("7,14");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Vapor";
            diasIndicador.UnidadeMedida = "CV";
            diasIndicador.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("32,77");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Vapor";
            diasIndicador.UnidadeMedida = "CV";
            diasIndicador.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("37,66");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Alegrete";
            diasIndicador.Tipo = "Vapor";
            diasIndicador.UnidadeMedida = "CV";
            diasIndicador.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("13,06");
            diasIndicadorEva.Add(diasIndicador);


            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Agua";
            diasIndicador.UnidadeMedida = "M³";
            diasIndicador.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("3,62");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Agua";
            diasIndicador.UnidadeMedida = "M³";
            diasIndicador.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("5,02");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Agua";
            diasIndicador.UnidadeMedida = "M³";
            diasIndicador.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("12,62");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Energia";
            diasIndicador.UnidadeMedida = "Kwh";
            diasIndicador.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("15,22");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Energia";
            diasIndicador.UnidadeMedida = "Kwh";
            diasIndicador.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("3,00");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Energia";
            diasIndicador.UnidadeMedida = "Kwh";
            diasIndicador.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("7,14");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Vapor";
            diasIndicador.UnidadeMedida = "CV";
            diasIndicador.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("32,77");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Vapor";
            diasIndicador.UnidadeMedida = "CV";
            diasIndicador.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("37,66");
            diasIndicadorEva.Add(diasIndicador);

            diasIndicador = new DiasIndicadorEva();
            diasIndicador.UnidadeNome = "Bagé";
            diasIndicador.Tipo = "Vapor";
            diasIndicador.UnidadeMedida = "CV";
            diasIndicador.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            diasIndicador.Valor = Convert.ToDecimal("13,06");
            diasIndicadorEva.Add(diasIndicador);

            List<DiasIndicadorEvaLista> diasIndicadorEvaLista = new List<DiasIndicadorEvaLista>();
            var unidade = "";
            foreach (var item in diasIndicadorEva)
            {

                DiasIndicadorEvaLista diasIndicadorLista = new DiasIndicadorEvaLista();
               
                if (unidade != item.UnidadeNome.ToString())
                {
                    diasIndicadorLista.UnidadeNome = item.UnidadeNome;
                    unidade = item.UnidadeNome;

                    diasIndicadorLista.Tipo = PreencherTipo(diasIndicadorEva, item.UnidadeNome);
                    diasIndicadorEvaLista.Add(diasIndicadorLista);
                }
                
            }

            ViewBag.ListaIndicadorEva = diasIndicadorEvaLista;


            var relatorioX = this.ObterRelatorioX();
            return View(relatorioX);
        }

        private IEnumerable<RelatorioXModelView> ObterRelatorioX()
        {
            List<RelatorioXModelView> listaRelatorioX = new List<RelatorioXModelView>();

            RelatorioXModelView relatorioX = new RelatorioXModelView();
            relatorioX.Estado = "São Paulo";
            relatorioX.QtdeDias = 4;
            relatorioX.ListaCidades = this.ObterCidades(relatorioX.Estado, relatorioX.QtdeDias);
            listaRelatorioX.Add(relatorioX);

            relatorioX = new RelatorioXModelView();
            relatorioX.Estado = "Rio de Janeiro";
            relatorioX.QtdeDias = 4;
            relatorioX.ListaCidades = this.ObterCidades(relatorioX.Estado, relatorioX.QtdeDias);

            listaRelatorioX.Add(relatorioX);

            return listaRelatorioX;
        }

        private IEnumerable<Cidade> ObterCidades(string estado, int qtdeDias)
        {
            List<Cidade> listaCidades = new List<Cidade>();
            Cidade cidade = new Cidade();

            if (estado == "São Paulo")
            {
                cidade.Nome = "Itupeva";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Jundiai";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Varzea Paulista";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);
            }
            else
            {
                cidade.Nome = "Niteroi";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Arraial do Cabo";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);

                cidade = new Cidade();
                cidade.Nome = "Petropolis";
                cidade.ListaDias = this.ObterDias(qtdeDias);
                cidade.Total = cidade.ListaDias.Sum(a => a.Valor);
                listaCidades.Add(cidade);
            }

            return listaCidades;
        }

        private IEnumerable<Dias> ObterDias(int qtdeDias)
        {
            List<Dias> listaDias = new List<Dias>();

            for (int i = 1; i <= 3; i++)
            {
                listaDias.Add(new Dias()
                {
                    Dia = $"Dia {i}",
                    Valor = new decimal(100.00 * i)
                });
            }

            return listaDias;
        }



        private List<Tipo> PreencherTipo(List<DiasIndicadorEva> lista, string unidadeNome)
        {
            List<Tipo> listaTipo = new List<Tipo>();
            var tipo = "";

            foreach (var item in lista.Where(l => l.UnidadeNome.Equals(unidadeNome)))
            {
                Tipo tipoLista = new Tipo();
                

                if (tipo != item.Tipo.ToString())
                {
                    tipoLista.Tipos = item.Tipo;
                    tipoLista.UnidadeMedida = item.UnidadeMedida;
                    tipoLista.DiaValor = PreencherDiaValor(lista, item.Tipo);

                    tipo = item.Tipo;

                    listaTipo.Add(tipoLista);
                }
                
                
            }

            return listaTipo;
        }

        private List<DiaValor> PreencherDiaValor(List<DiasIndicadorEva> lista, string tipo)
        {
            var listaDiaValor = new List<DiaValor>();


            foreach (var item in lista.Where(l => l.Tipo.Equals(tipo)))
            {
                DiaValor diaValor = new DiaValor();

                diaValor.Data = item.Data;
                diaValor.Valor = item.Valor;
                listaDiaValor.Add(diaValor);
            }
            
            return listaDiaValor;
        }
    }
}
