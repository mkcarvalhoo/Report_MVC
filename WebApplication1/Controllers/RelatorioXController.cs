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

            #region Lista

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

            #endregion

            List<DiasIndicadorEvaLista> diasIndicadorEvaLista = new List<DiasIndicadorEvaLista>();
            var unidade = "";
            foreach (var item in diasIndicadorEva)
            {

                DiasIndicadorEvaLista diasIndicadorLista = new DiasIndicadorEvaLista();

                if (unidade != item.UnidadeNome.ToString())
                {
                    diasIndicadorLista.UnidadeNome = item.UnidadeNome;
                    unidade = item.UnidadeNome;
                    diasIndicadorLista.VolumeRealizados = PreencherRealizados(diasIndicadorLista, item.Data, item.UnidadeNome);
                    diasIndicadorLista.Tipo = PreencherTipo(diasIndicadorEva, diasIndicadorLista, item.UnidadeNome);
                    diasIndicadorEvaLista.Add(diasIndicadorLista);
                }

            }

            ViewBag.ListaIndicadorEva = diasIndicadorEvaLista;


            var relatorioX = this.ObterRelatorioX();
            return View(relatorioX);
        }

        #region Antigo

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
        #endregion

        private IEnumerable<Dias> ObterDias(int qtdeDias)
        {
            List<Dias> listaDias = new List<Dias>();

            for (int i = 1; i <= 29; i++)
            {
                listaDias.Add(new Dias()
                {
                    Dia = $"Dia {i}",
                    Valor = new decimal(100.00 * i)
                });
            }

            return listaDias;
        }



        private List<Tipo> PreencherTipo(List<DiasIndicadorEva> lista, DiasIndicadorEvaLista listaIndicador, string unidadeNome)
        {
            List<Tipo> listaTipo = new List<Tipo>();
            var tipo = "";
            DateTime data;
            foreach (var item in lista.Where(l => l.UnidadeNome.Equals(unidadeNome)))
            {
                Tipo tipoLista = new Tipo();


                if (tipo != item.Tipo.ToString())
                {
                    tipoLista.Tipos = item.Tipo;
                    tipoLista.UnidadeMedida = item.UnidadeMedida;
                    tipoLista.DiaValor = PreencherDiaValor(lista, listaIndicador, item.Tipo, unidadeNome);

                    tipo = item.Tipo;
                    listaTipo.Add(tipoLista);
                }



            }

            return listaTipo;
        }

        private List<DiaValor> PreencherDiaValor(List<DiasIndicadorEva> lista, DiasIndicadorEvaLista listaIndicador, string tipo, string unidadeNome)
        {
            var listaDiaValor = new List<DiaValor>();


            foreach (var item in lista.Where(l => l.Tipo.Equals(tipo)).Where(l => l.UnidadeNome.Equals(unidadeNome)))
            {
                DiaValor diaValor = new DiaValor();

                diaValor.Data = item.Data;
                diaValor.Valor = item.Valor;

                foreach (var listaInd in listaIndicador.VolumeRealizados.Where(a => a.DataRealizado == item.Data))
                {
                    var result = listaInd.RealizadoAbate;
                    diaValor.ValorVolumeRealizadoAbate = Convert.ToDecimal(result);
                }
                //if agua
                //diaValor.Valor / diaValor.ValorVolumeRealizadoAbate

                //else 
                //diaValor.Valor / Cabeças Proc.

                foreach (var listaInd in listaIndicador.VolumeRealizados.Where(a => a.DataRealizado == item.Data))
                {
                    var result = listaInd.RealizadoDesossa;
                    diaValor.ValorVolumeRealizadoDesossa = Convert.ToDecimal(result);
                }
                //OBS: Incluir cálculo MédiaAcumulada 
                //diaValor.ValorVolumeRealizadoAbate / MédiaAcumulada - 1

                listaDiaValor.Add(diaValor);
            }



            return listaDiaValor;
        }

        private IEnumerable<VolumeRealizado> PreencherRealizados(DiasIndicadorEvaLista diasIndicadorEvaLista, DateTime data, string unidadeNome)
        {
            int dia = data.Day;
            int mes = (int)data.Month;
            int ano = data.Year;
            int qtdeDiasMes = DateTime.DaysInMonth(ano, mes);
            DateTime dataRealizado = Convert.ToDateTime("01/" + mes + "/" + ano + " 00:00:00");
            decimal totalRealizadoAbate = 0;
            decimal totalRealizadoDesossa = 0;

            List<VolumeRealizado> listaRealizado = new List<VolumeRealizado>();

            for (int i = 0; i < qtdeDiasMes; i++)
            {
                VolumeRealizado realizado = new VolumeRealizado();

                realizado.DataRealizado = dataRealizado;
                realizado.RealizadoAbate = PreencherRealizadoABate(dataRealizado, unidadeNome);
                realizado.RealizadoDesossa = PreencherRealizadoDesossa(dataRealizado, unidadeNome);
                listaRealizado.Add(realizado);

                totalRealizadoAbate = totalRealizadoAbate + Convert.ToDecimal(realizado.RealizadoAbate);
                totalRealizadoDesossa = totalRealizadoDesossa + Convert.ToDecimal(realizado.RealizadoDesossa);

                dataRealizado = dataRealizado.AddDays(1);
            }


            diasIndicadorEvaLista.MediaAcumuladaAbate = totalRealizadoAbate;
            diasIndicadorEvaLista.MediaAcumuladaDesossa = totalRealizadoDesossa;


            return listaRealizado;
        }

        private Nullable<decimal> PreencherRealizadoABate(DateTime data, string unidadeNome)
        {
            List<RealizadoAbate> realizadoAbate = new List<RealizadoAbate>();

            RealizadoAbate volumeRealizado = new RealizadoAbate();
            volumeRealizado.UnidadeNome = "Alegrete";
            volumeRealizado.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            volumeRealizado.Valor = Convert.ToDecimal("12,62");
            realizadoAbate.Add(volumeRealizado);


            volumeRealizado = new RealizadoAbate();
            volumeRealizado.UnidadeNome = "Alegrete";
            volumeRealizado.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            volumeRealizado.Valor = Convert.ToDecimal("12,63");
            realizadoAbate.Add(volumeRealizado);

            volumeRealizado = new RealizadoAbate();
            volumeRealizado.UnidadeNome = "Alegrete";
            volumeRealizado.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            volumeRealizado.Valor = Convert.ToDecimal("12,64");
            realizadoAbate.Add(volumeRealizado);


            List<RealizadoAbate> listaDiaValor = new List<RealizadoAbate>();

            var filtroLista = realizadoAbate
                .Where(l => l.Data == data)
                .Where(l => l.UnidadeNome == unidadeNome)
                .Select(l => l.Valor);


            return Convert.ToDecimal(filtroLista.FirstOrDefault());
        }

        private Nullable<decimal> PreencherRealizadoDesossa(DateTime data, string unidadeNome)
        {
            List<RealizadoDesossa> realizadoAbate = new List<RealizadoDesossa>();

            RealizadoDesossa volumeRealizado = new RealizadoDesossa();
            volumeRealizado.UnidadeNome = "Alegrete";
            volumeRealizado.Data = Convert.ToDateTime("17/02/2020 00:00:00");
            volumeRealizado.Valor = Convert.ToDecimal("25,62");
            realizadoAbate.Add(volumeRealizado);


            volumeRealizado = new RealizadoDesossa();
            volumeRealizado.UnidadeNome = "Alegrete";
            volumeRealizado.Data = Convert.ToDateTime("18/02/2020 00:00:00");
            volumeRealizado.Valor = Convert.ToDecimal("25,63");
            realizadoAbate.Add(volumeRealizado);

            volumeRealizado = new RealizadoDesossa();
            volumeRealizado.UnidadeNome = "Alegrete";
            volumeRealizado.Data = Convert.ToDateTime("19/02/2020 00:00:00");
            volumeRealizado.Valor = Convert.ToDecimal("25,64");
            realizadoAbate.Add(volumeRealizado);


            List<RealizadoDesossa> listaDiaValor = new List<RealizadoDesossa>();

            var filtroLista = realizadoAbate
                .Where(l => l.Data == data)
                .Where(l => l.UnidadeNome == unidadeNome)
                .Select(l => l.Valor);

            return Convert.ToDecimal(filtroLista.FirstOrDefault());
        }
    }
}
