using System;

using Models;

namespace Controller
{

    public class Saldo
    {

        public static List<Models.Saldo>  BuscarSaldos() {
            return Models.Saldo.BuscarSaldos();
        }

        public static void CadastrarSaldo(string quantidade, string produtoId, string estoqueId)
        {
           new Models.Saldo(int.Parse(quantidade), int.Parse(produtoId), int.Parse(estoqueId));
        }

        public static Models.Saldo BuscarSaldoId(string id) {
            return Models.Saldo.BuscarSaldoId(int.Parse(id));
        }

        public static void ExcluirSaldo(string id) {
            Models.Saldo.ExcluirSaldo(int.Parse(id));
        }

        public static void EditarSaldo(int id, string quantidade, string produtoId, string estoqueId) {
            // Models.Produto.EditarProduto(id,nome, Double.Parse(preco));
            Models.Saldo saldo = Models.Saldo.BuscarSaldoId(id);
            saldo.Quantidade = int.Parse(quantidade);
            saldo.ProdutoId = int.Parse(produtoId);
            saldo.EstoqueId = int.Parse(estoqueId);
        }

        // public static List<Models.Saldo> BuscarSaldoId(string id)
        // {
        //     return Models.Saldo.BuscarSaldos().Where(s => s.EstoqueId.Id == id).ToList();
        // }

        public static List<Models.Saldo> BuscarSaldoId(int id)
        {
            return Models.Saldo.BuscarSaldos().Where(s => s.Produto.Id == id).ToList();
        }

    }
    

}