﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SeuCanto
{
    public partial class frmRelatorioReserva : Form
    {
        public frmRelatorioReserva()
        {
            InitializeComponent();
        }

        private void frmRelatorioReserva_Load(object sender, EventArgs e)
        {
            // cria uma lista de objetos "Cliente",
            // com dados provenientes do banco de dados
            Reserva_QuartoDAO reserva_quartoDao = new Reserva_QuartoDAO();

            repReserva objRpt = new repReserva();
            //objRpt.SetDataSource();
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
