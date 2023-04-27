using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

using Controller;


namespace Views
{
    public class CadastroEstoque : Form
    {
        private Label lblTitulo;
        private Label lblNome;
        private Label lblPreco;

        public TextBox txtNome;
        public TextBox txtPreco;

        private Button btnCancel;
        private Button btnSalvar;

        private Models.Estoque? Estoque;

        
        
        public CadastroEstoque(Models.Estoque? estoque)
        {
            this.Estoque = estoque;
            // Tamanho da tela
            Size = new Size(600,500);

            // Define nome navbar
            this.Text = "Estoque";

            //Define parametros da Label Cadastro de Produto

            lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Estoque";
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

            if (this.Estoque != null) {
                txtNome.Text = this.Estoque.Nome;
            }

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(450, 340);
            btnSalvar.Size = new Size(80, 30);
            btnSalvar.Click += (sender, e) => 
            {
                if (this.Estoque != null) {
                    Controller.Estoque.EditarEstoque(this.Estoque.Id, this.txtNome.Text);
                } else {
                    Controller.Estoque.CadastrarEstoque(this.txtNome.Text);
                }
                
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


