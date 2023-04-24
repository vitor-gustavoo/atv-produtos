using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

using Controller;


namespace Views
{
    public class CadastroProduto : Form
    {
        private Label lblTitulo;
        private Label lblNome;
        private Label lblPreco;

        public TextBox txtNome;
        public TextBox txtPreco;

        private Button btnCancel;
        private Button btnSalvar;

        
        
        public CadastroProduto()
        {
            // Tamanho da tela
            Size = new Size(600,500);

            // Define nome navbar
            this.Text = "Produto";

            //Define parametros da Label Cadastro de Produto

            lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Produto";
            lblTitulo.Location = new Point(170,50);
            lblTitulo.Size = new Size(350,20);
            this.StartPosition = FormStartPosition.CenterScreen;
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Controls.Add(lblTitulo);

            //Define parametros da Label Nome

            lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Location = new Point(150,100);
            lblNome.Size = new Size(50,20);
            lblNome.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblNome);

            txtNome = new TextBox();
            txtNome.Location = new Point (150,120);
            txtNome.Size = new Size(250,40);
            txtNome.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(txtNome);


            lblPreco = new Label();
            lblPreco.Text  = "Preço";
            lblPreco.Location = new Point(150,180);
            lblPreco.Size = new Size(50, 20);
            lblPreco.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblPreco);


            txtPreco = new TextBox();
            txtPreco.PlaceholderText = "R$";
            txtPreco.Location = new Point(150,200);
            txtPreco.Size = new Size(250,40);
            txtPreco.Font = new Font("Arial",10, FontStyle.Regular);
            this.Controls.Add(txtPreco);


            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(450, 340);
            btnSalvar.Size = new Size(80, 30);
            btnSalvar.Click += (sender, e) => {

                Controller.Produto.CadastrarProduto(this.txtNome.Text, this.txtPreco.Text);
                this.Close();
            };
            this.Controls.Add(btnSalvar);
            

            btnCancel = new Button();
            btnCancel.Text = "Cancelar";
            btnCancel.Location = new Point(350, 340);
            btnCancel.Size =new Size(80, 30);
            btnCancel.Click += (sender, e) => {this.Close();};
            this.Controls.Add(btnCancel);
        }


    }


}


