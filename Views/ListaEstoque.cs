// using System;
// using System.Windows.Forms;
// using System.Drawing;
// using System.ComponentModel;
// using System.Diagnostics;
// using System.Threading;




// namespace Views
// {
//     public class ListaEstoque : Form 
//     {
//         private ListView listaEstoque;
//         private ListBox listBox;
//         private Button btnEditar;
//         private Button btnDelete;
//         private Button btnSair;
//         private Button btnInserir;



//         public ListaEstoque()
//         {

//             Size = new Size(700,700);
//             this.Text  = "Lista de Estoque";
//             this.StartPosition = FormStartPosition.CenterScreen;

//             listaEstoque = new ListView();
//             listaEstoque.Location = new Point(10,20);
//             listaEstoque.Size = new Size(660, 550);
//             listaEstoque.View = View.Details;
//             listaEstoque.FullRowSelect = true;

//             listaEstoque.Columns.Add("ID", -2, HorizontalAlignment.Left);
//             listaEstoque.Columns.Add("Produto", -2, HorizontalAlignment.Left);
//             listaEstoque.Columns.Add("Preço", -2, HorizontalAlignment.Left);

//             this.Controls.Add(listaEstoque);
//             // this.LoadList();


//             btnInserir = new Button();
//             btnInserir.Text = "Inserir";
//             btnInserir.Location = new Point(100, 600);
//             btnInserir.Size =new Size(80, 30);
//             btnInserir.Click += (sender, e) => 
//             //{
//             // CadastroProduto produto = new CadastroProduto();
//             //     produto.ShowDialog();
//             //     // this.LoadList();
//             // };
//             this.Controls.Add(btnInserir);

//             btnEditar = new Button();
//             btnEditar.Text = "Editar";
//             btnEditar.Location = new Point(200, 600);
//             btnEditar.Size =new Size(80, 30);
//             btnEditar.Click += (sender, e) => 
//             // {
//             //     Controller.Produto.EditarProduto(
//             //         int.Parse(this.lista.SelectedItems[0].SubItems[0].Text)
//             //     );
//             // }; 
//             this.Controls.Add(btnEditar);

//             btnDelete = new Button();
//             btnDelete.Text = "Deletar";
//             btnDelete.Location = new Point(300, 600);
//             btnDelete.Size =new Size(80, 30);
//             btnDelete.Click +=(sender, e) => 
//             //{
//             //     Controller.Produto.ExcluirProduto(
//             //    (this.lista.SelectedItems[0].SubItems[0].Text)
//             //     );
//             // };
//             this.Controls.Add(btnDelete);

//             btnSair = new Button();
//             btnSair.Text = "Sair";
//             btnSair.Location = new Point(400, 600);
//             btnSair.Size =new Size(80, 30);
//             btnSair.Click += (sender, e) => 
//             //{
//                 // Confirmacao confirmacao = new Confirmacao();
//                 // confirmacao.Show();
//                 // this.Close();
//                 // };
//             this.Controls.Add(btnSair);
//         }
//     }
// }

    

















        

       