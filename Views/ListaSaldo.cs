using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;




namespace Views
{
    public class ListaSaldo : Form 
    {
        private ListView listaSaldo;
        private ListBox listBox;
        private Button btnEditar;
        private Button btnDelete;
        private Button btnVoltar;
        private Button btnInserir;



        public ListaSaldo()
        {

            Size = new Size(700,700);
            this.Text  = "Lista de Saldo";
            this.StartPosition = FormStartPosition.CenterScreen;

            listaSaldo = new ListView();
            listaSaldo.Location = new Point(10,20);
            listaSaldo.Size = new Size(660, 550);
            listaSaldo.View = View.Details;
            listaSaldo.FullRowSelect = true;

            listaSaldo.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listaSaldo.Columns.Add("Produto", -2, HorizontalAlignment.Left);
            listaSaldo.Columns.Add("Estoque", -2, HorizontalAlignment.Left);
            listaSaldo.Columns.Add("Quantidade", -2, HorizontalAlignment.Left);

            this.Controls.Add(listaSaldo);
            this.LoadList();


            btnInserir = new Button();
            btnInserir.Text = "Inserir";
            btnInserir.Location = new Point(100, 600);
            btnInserir.Size =new Size(80, 30);
            btnInserir.Click += (sender, e) => 
            {
            CadastroSaldo saldo = new CadastroSaldo();
                saldo.ShowDialog();
                this.LoadList();
            };
            this.Controls.Add(btnInserir);

            btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Location = new Point(200, 600);
            btnEditar.Size =new Size(80, 30);
            btnEditar.Click += (sender, e) => 
            // {
            //     Controller.Produto.EditarProduto(
            //         int.Parse(this.lista.SelectedItems[0].SubItems[0].Text)
            //     );
            // }; 
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
                    Controller.Saldo.ExcluirSaldo(
                    (listaSaldo.SelectedItems[0].Text));
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
            
            listaSaldo.Items.Clear();
            foreach(Models.Estoque e in Controller.Estoque.BuscarEstoque()) 
            {

                listaSaldo.Items.Add(
                    new ListViewItem(new [] { 
                        e.Id.ToString(), e.Nome
                    })
                );
            }
            
        }  
    }
}

    

















        

       