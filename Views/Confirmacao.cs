using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Views
{
    public class Confirmacao : Form
    {
        private Label lblTitulo;
        private Button btnSim;
        private Button btnNao;


        public Confirmacao()
        {
            Size = new Size(350,200);

            this.Text = "Aviso";

            lblTitulo = new Label();
            lblTitulo.Text = "Deseja realmente excluir?";
            lblTitulo.Location = new Point(50, 50);
            lblTitulo.Size = new Size(250, 50);
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(lblTitulo);


            btnSim = new Button();
            btnSim.Text = "Sim";
            btnSim.Location = new Point(80, 100);
            btnSim.Size =new Size(70, 30);
            btnSim.Click += (sender, e) => {
                this.Close();
            };
            this.Controls.Add(btnSim);

            btnNao = new Button();
            btnNao.Text = "Não";
            btnNao.Location = new Point(200, 100);
            btnNao.Size =new Size(70, 30);
            btnNao.Click += (sender, e) => {
                ListaProduto lista = new ListaProduto();
                lista.Show();
                this.Close();
            };
            this.Controls.Add(btnNao);

        }

    }

}


