using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using TCCEsportivo.Data;
using TCCEsportivo.Models;

namespace TCCEsportivo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        DTO dt = new DTO();
        DAO da = new DAO();

        [HttpPost]
        public ActionResult CadastroCli(DTO resposta)
        {
            try
            {
                return RedirectToAction("ObrigadoCliente");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult CadastroFunc(FormCollection frm)
        {
            if ((frm["txtnomefunc"] != null) && (frm["txtcpffunc"] != null) && (frm["txttelfunc"] != null) && (frm["txtdatafunc"] != null) && (frm["txtcargofunc"] != null))
            {
                dt.CodFunc1 = null;
                dt.NomeFunc1 = frm["txtnomefunc"];
                dt.CpfFunc1 = frm["txtcpffunc"];
                dt.TelFunc1 = frm["txttelfunc"];
                dt.DTFunc1 = frm["txtdatafunc"];
                dt.CarFunc1 = frm["txtcargofunc"];
                da.InserirFunc(dt);
                return View();
            }
            return View();
        }
        public ActionResult ObrigadoCliente(FormCollection frm)
        {
            
            dt.NomeCli = frm["NomeCli"];
            dt.CpfCli = frm["CpfCli"];
            dt.EmailCli = frm["EmailCli"];
            dt.TelCli = frm["TelCli"];
            dt.DataCli = frm["DataCli"];
            dt.GeneCli = frm["GeneCli"];
            da.InserirCli(dt);
            return View();
        }
        public ActionResult CadastroCli()
        {
            return View();
        }
    }
}