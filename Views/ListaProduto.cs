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
        private Button btnSair;
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
            // this.LoadList();


            btnInserir = new Button();
            btnInserir.Text = "Inserir";
            btnInserir.Location = new Point(100, 600);
            btnInserir.Size =new Size(80, 30);
            btnInserir.Click += (sender, e) => {
            CadastroProduto produto = new CadastroProduto();
                produto.ShowDialog();
                // this.LoadList();
            };
            this.Controls.Add(btnInserir);

            btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Location = new Point(200, 600);
            btnEditar.Size =new Size(80, 30);
            // btnEditar.Click += (sender, e) => {
            //     Controller.Produto.EditarProduto(
            //         int.Parse(this.lista.SelectedItems[0].SubItems[0].Text)
            //     );
            // }; 
            this.Controls.Add(btnEditar);

            btnDelete = new Button();
            btnDelete.Text = "Deletar";
            btnDelete.Location = new Point(300, 600);
            btnDelete.Size =new Size(80, 30);
            btnDelete.Click +=(sender, e) => {
                Controller.Produto.ExcluirProduto(
               (this.lista.SelectedItems[0].SubItems[0].Text)
                );
            };
            this.Controls.Add(btnDelete);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Location = new Point(400, 600);
            btnSair.Size =new Size(80, 30);
            btnSair.Click += (sender, e) => {
                Confirmacao confirmacao = new Confirmacao();
                confirmacao.Show();
                this.Close();
            };
            this.Controls.Add(btnSair);
        }

        // private void LoadList() 
        // {
            
        //     lista.Items.Clear();
        //     foreach(Models.Produto p in Controller.Produto.BuscarProdutoId(id)) 
        //     {

        //         lista.Items.Add(
        //             new ListViewItem(new [] { 
        //                 p.Id.ToString(), p.Nome, p.Preco.ToString()
        //             })
        //         );
        //     }
            
        // }  
    }
}

    

















        

       