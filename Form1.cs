using Microsoft.Reporting.WinForms;
using ReportesAyD.Formularios;
using ReportesAyD.Modelos;
using ReportesAyD.PruebaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesAyD
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         List<Persona> lista = new List<Persona>();
         Persona pers1 = new Persona();
         pers1.Codigo = 1;
         pers1.Nombre = "Tania";
         pers1.FechaNac = new DateTime(2006, 06, 15);
         lista.Add( pers1 );

         ReportDataSource rds = new ReportDataSource("DsDatos", lista);

         FrmReporteCiudad frm = new FrmReporteCiudad();
         frm.reportViewer1.LocalReport.DataSources.Clear();
         frm.reportViewer1.LocalReport.DataSources.Add(rds);
         frm.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesAyD.Reportes.RptPersona.rdlc";
         frm.reportViewer1.Refresh();
         frm.Show();
      }
   }
}
