using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

using Controller;



namespace Views
{
    public class ListaProduto : Form 
    {
        private ListView lista;
        private ListBox listBox;
        private Button btnEditar;
        private Button btnDelete;
        private Button btnVoltar;
        private Button btnInserir;



        public ListaProduto()
        {

            Size = new Size(700,700);
            this.Text  = "Lista de Produtos";
            this.StartPosition = FormStartPosition.CenterScreen;

            lista = new ListView();
            lista.Location = new Point(10,20);
            lista.Size = new Size(660, 550);
            lista.View = View.Details;
            lista.FullRowSelect = true;

            lista.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lista.Columns.Add("Produto", -2, HorizontalAlignment.Left);
            lista.Columns.Add("Preço", -2, HorizontalAlignment.Left);

            this.Controls.Add(lista);
            this.LoadList();


            btnInserir = new Button();
            btnInserir.Text = "Inserir";
            btnInserir.Location = new Point(100, 600);
            btnInserir.Size =new Size(80, 30);
            btnInserir.Click += (sender, e) => 
            {
                CadastroProduto produto = new CadastroProduto(null);
                produto.ShowDialog();
                this.LoadList();
            };
            this.Controls.Add(btnInserir);

            btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Location = new Point(200, 600);
            btnEditar.Size =new Size(80, 30);
            btnEditar.Click += (sender, e) => 
            {
                Models.Produto produto = Controller.Produto.BuscarProdutoId(
                    lista.SelectedItems[0].Text
                );
                CadastroProduto prd = new CadastroProduto(produto);
                prd.ShowDialog();
                this.LoadList();
            };
            this.Controls.Add(btnEditar);
            
            btnDelete = new Button();
            btnDelete.Text = "Deletar";
            btnDelete.Location = new Point(300, 600);
            btnDelete.Size =new Size(80, 30);
            btnDelete.Click +=(sender, e) => {
                DialogResult result = MessageBox.Show("Você deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Controller.Produto.ExcluirProduto(
                    (lista.SelectedItems[0].Text));
                    this.LoadList();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            };
            this.Controls.Add(btnDelete);

            btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.Location = new Point(400, 600);
            btnVoltar.Size =new Size(80, 30);
            btnVoltar.Click += (sender, e) => {
            this.Close();
            };
            this.Controls.Add(btnVoltar);
        }

        private void LoadList() 
        {
            
            lista.Items.Clear();
            foreach(Models.Produto p in Controller.Produto.BuscarProdutos()) 
            {

                lista.Items.Add(
                    new ListViewItem(new [] { 
                        p.Id.ToString(), p.Nome, p.Preco.ToString()
                    })
                );
            }
            
        }  
    }
}

    

















        

       