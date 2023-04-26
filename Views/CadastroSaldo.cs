using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

using Controller;


namespace Views
{
    public class CadastroSaldo : Form
    {
        private Label lblTitulo;
        private Label lblNome;
        private Label lblPreco;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        public ComboBox comboBoxNome;
        public ComboBox comboBoxPreco;

        private Button btnCancel;
        private Button btnSalvar;

        
        
        public CadastroSaldo()
        {
            // Tamanho da tela
            Size = new Size(600,500);

            // Define nome navbar
            this.Text = "Saldo";

            //Define parametros da Label Cadastro de Produto

            lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Saldos";
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

            comboBoxNome = new ComboBox();
            comboBoxNome.Location = new Point (150,120);
            comboBoxNome.Size = new Size(250,40);
            comboBoxNome.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(comboBoxNome);


            lblPreco = new Label();
            lblPreco.Text = "Preço";
            lblPreco.Location = new Point(150,150);
            lblPreco.Size = new Size(50,20);
            lblPreco.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblPreco);

            comboBoxPreco = new ComboBox();
            comboBoxPreco.Location = new Point (150,170);
            comboBoxPreco.Size = new Size(250,40);
            comboBoxPreco.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(comboBoxPreco);

            lblQuantidade = new Label();
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.Location = new Point(150,200);
            lblQuantidade.Size = new Size(80,20);
            lblQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblQuantidade);

            txtQuantidade = new TextBox();
            txtQuantidade.Location = new Point (150,220);
            txtQuantidade.Size = new Size(250,40);
            txtQuantidade.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(txtQuantidade);

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(450, 340);
            btnSalvar.Size = new Size(80, 30);
            btnSalvar.Click += (sender, e) => 
            {

                // Controller.Saldo.CadastrarSaldo(this.txtQuantidade.Text, );
                // this.Close();
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


