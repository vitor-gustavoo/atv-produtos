using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;




namespace Views
{
    public class ListaEstoque : Form 
    {
        private ListView listaEstoque;
        private ListBox listBox;
        private Button btnEditar;
        private Button btnDelete;
        private Button btnVoltar;
        private Button btnInserir;



        public ListaEstoque()
        {

            Size = new Size(700,700);
            this.Text  = "Lista de Estoque";
            this.StartPosition = FormStartPosition.CenterScreen;

            listaEstoque = new ListView();
            listaEstoque.Location = new Point(10,20);
            listaEstoque.Size = new Size(660, 550);
            listaEstoque.View = View.Details;
            listaEstoque.FullRowSelect = true;

            listaEstoque.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listaEstoque.Columns.Add("Estoque", -2, HorizontalAlignment.Left);

            this.Controls.Add(listaEstoque);
            this.LoadList();


            btnInserir = new Button();
            btnInserir.Text = "Inserir";
            btnInserir.Location = new Point(100, 600);
            btnInserir.Size =new Size(80, 30);
            btnInserir.Click += (sender, e) => 
            {
            CadastroEstoque estoque = new CadastroEstoque(null);
                estoque.ShowDialog();
                this.LoadList();
            };
            this.Controls.Add(btnInserir);

            btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Location = new Point(200, 600);
            btnEditar.Size =new Size(80, 30);
            btnEditar.Click += (sender, e) => 
            {
               Models.Estoque estoque = Controller.Estoque.BuscarEstoqueId(
                    listaEstoque.SelectedItems[0].Text
                );
                CadastroEstoque est = new CadastroEstoque(estoque);
                est.ShowDialog();
                this.LoadList();
            }; 
            this.Controls.Add(btnEditar);

            btnDelete = new Button();
            btnDelete.Text = "Deletar";
            btnDelete.Location = new Point(300, 600);
            btnDelete.Size =new Size(80, 30);
            btnDelete.Click +=(sender, e) => 
            {
                DialogResult result = MessageBox.Show("Você deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Controller.Estoque.ExcluirEstoque(
                    (listaEstoque.SelectedItems[0].Text));
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
            btnVoltar.Click += (sender, e) => 
            {
            this.Close();
            };
            this.Controls.Add(btnVoltar);
        }


        private void LoadList() 
        {
            
            listaEstoque.Items.Clear();
            foreach(Models.Estoque e in Controller.Estoque.BuscarEstoque()) 
            {

                listaEstoque.Items.Add(
                    new ListViewItem(new [] { 
                        e.Id.ToString(), e.Nome
                    })
                );
            }
            
        }  
    }
}

    

















        

       