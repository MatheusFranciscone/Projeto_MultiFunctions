﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06_Ex01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        int tentativa = 0;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login, senha;

            login = txtLogin.Text; 
            senha = txtSenha.Text; 

            if (login == "admin" & senha == "admin")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Digite o Login e a Senha corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                tentativa += 1;
            }
            if (tentativa == 3)
            {
                Application.Exit();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
