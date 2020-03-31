﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;

namespace Views
{
    public partial class Formdashboard : Form
    {
        const decimal Desconto = 0;
        const int Qtd = 1;

        public Formdashboard()
        {
            InitializeComponent();
        }

        private void Formdashboard_Load(object sender, EventArgs e)
        {
            
        }
        private void OpenFormPanel(object form)
        {
            if (this.container.Controls.Count > 0)
                this.container.Controls.RemoveAt(0);
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.container.Controls.Add(frm);
            this.container.Tag = frm;
            frm.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFormPanel(new Formdashboard());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroProduto frm = new FormCadastroProduto();
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormPDV frm = new FormPDV();
            frm.Show();
        }
    }
}