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
        private Label lblEstoque;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxEstoque;

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
            lblNome.Text = "Produto";
            lblNome.Location = new Point(150,100);
            lblNome.Size = new Size(60,20);
            lblNome.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblNome);

            comboBoxProduto = new ComboBox();
            comboBoxProduto.Location = new Point (150,120);
            comboBoxProduto.Size = new Size(250,40);
            comboBoxProduto.Font = new Font("Arial", 10, FontStyle.Regular);
            comboBoxProduto.Font = new Font("Arial", 10, FontStyle.Regular);
              foreach (Models.Produto produto in Models.Produto.BuscarProdutos()) {
                Models.Produto prd = Controller.Produto.BuscarProdutoId(produto.Id.ToString());
                comboBoxProduto.Items.Add(produto.Nome);
           }
            this.Controls.Add(comboBoxProduto);


            lblEstoque = new Label();
            lblEstoque.Text = "Estoque";
            lblEstoque.Location = new Point(150,150);
            lblEstoque.Size = new Size(60,20);
            lblEstoque.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblEstoque);

            comboBoxEstoque = new ComboBox();
            comboBoxEstoque.Location = new Point (150,170);
            comboBoxEstoque.Size = new Size(250,40);
            comboBoxEstoque.Font = new Font("Arial", 10, FontStyle.Regular);
              foreach (Models.Estoque estoque in Models.Estoque.BuscarEstoque()) {
                Models.Estoque est = Controller.Estoque.BuscarEstoqueId(estoque.Id.ToString());
                comboBoxEstoque.Items.Add(est.Nome);
            }
            this.Controls.Add(comboBoxEstoque);

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
                Controller.Saldo.CadastrarSaldo(this.txtQuantidade.Text, this.comboBoxProduto.Text, this.comboBoxEstoque.Text);
                // this.LoadList();
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

        // private void LoadList() 
        // {
            
        //     comboBoxEstoque.Items.Clear();
        //     foreach(Models.Saldo s in Controller.Saldo.BuscarSaldos()) 
        //     {

        //         comboBoxEstoque.Items.Add(
        //             new ListViewItem(new [] { 
        //                 s.Id.ToString(), s.Produto.ToString(), s.Estoque.ToString(), s.Quantidade.ToString()
        //             })
        //         );
        //     }
            
        // } 

    }


}


