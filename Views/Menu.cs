using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Views;

public class Menu : Form
{
    private Label lblTitulo;
    private Button btnProduto;
    private Button btnEstoque;
    private Button btnSaldo;
    private Button btnSair;

  

    public Menu()

    {
        // Tamanho da tela
        Size = new Size(400,500);

        // Define nome navbar
        this.Text = "Menu";

        //Define parametros da Label Menu

        lblTitulo = new Label();
        lblTitulo.Text = "Menu";
        lblTitulo.Location = new Point(160,20);
        lblTitulo.Size = new Size(80,20);
        lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(lblTitulo);

        // Define parametros do botão Produto
        
        btnProduto = new Button();
        btnProduto.Text = "Produto";
        btnProduto.Location = new Point(130, 80);
        btnProduto.Size = new Size(120, 30);
        btnProduto.Click += (sender, e) => {
        ListaProduto lista = new ListaProduto();
        lista.ShowDialog();
        };
        this.Controls.Add(btnProduto);


        btnEstoque = new Button();
        btnEstoque.Text = "Estoque";
        btnEstoque.Location = new Point(130, 140);
        btnEstoque.Size = new Size(120, 30);
        btnEstoque.Click += (sender, e) => {
        ListaEstoque lista = new ListaEstoque();
        lista.ShowDialog();
        };
        this.Controls.Add(btnEstoque);

        btnSaldo = new Button();
        btnSaldo.Text = "Saldo";
        btnSaldo.Location = new Point(130, 200);
        btnSaldo.Size = new Size(120, 30);
        btnSaldo.Click += (sender, e) => {
        ListaSaldo lista = new ListaSaldo();
        lista.ShowDialog();
        };
        this.Controls.Add(btnSaldo);

        // Define parametros do botão Sair

        btnSair = new Button();
        btnSair.Text = "Sair";
        btnSair.Location = new Point(130, 280);
        btnSair.Size =new Size(120, 30);
        btnSair.Click += (sender, e) => {
        Application.Exit();
        };
        this.Controls.Add(btnSair);
        
    }
        
}
