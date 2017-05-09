using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedido ped = new Pedido();
            while (true)
            {
                Console.WriteLine("\nEscolha a operação");
                Console.WriteLine("1 - PEDIDO");
                Console.WriteLine("2 - PRODUTO");
                var menu = Console.ReadKey();
                switch (menu.KeyChar)
                {
                    #region Bloco Pedido
                    case '1':
                        string retorno = string.Empty;
                        Console.WriteLine("\nEscolha a operação");
                        Console.WriteLine("1 - INSERIR PEDIDO");
                        Console.WriteLine("2 - CONSULTAR TODOS PEDIDOS");
                        Console.WriteLine("3 - CONSULTAR IDPEDIDO");

                        var opcao = Console.ReadKey();

                        switch (opcao.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("\nInserindo Pedido");

                                ped.NomePedido = "Pedido123";
                                ped.TipoPedido = "pedido1232";
                                ped.StatusPedido = 'F';
                                ped.AdicionaPedido(ped);

                                Console.WriteLine("Pedido Inserido");

                                break;

                            case '2':
                                Console.WriteLine("\n");
                                List<Pedido> lstPed1 = new List<Pedido>();
                                lstPed1 = ped.LoadPedido();

                                foreach (Pedido item in lstPed1)
                                {
                                    Console.WriteLine($"{item.IdPedido}\t{item.NomePedido}\t{item.TipoPedido}\t{item.StatusPedido}\t");

                                }
                                break;

                            case '3':
                                Console.WriteLine("\nDIGITA O QUAL IDPEDIDO SE QUE PROCURA");

                                var idpedido = Convert.ToInt32(Console.ReadLine());

                                switch (Type.GetTypeCode(idpedido.GetType()))
                                {
                                    case TypeCode.Int32:
                                        Pedido item = ped.WherePedido(Convert.ToInt32(idpedido));
                                        if (item != null)
                                        {
                                            Console.WriteLine($"{item.IdPedido}\t{item.NomePedido}\t{item.TipoPedido}\t{item.StatusPedido}\t\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("NAO TEM O IDPEDIDO SOLICITADO\n");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("DIGITA UM NUMERO IMBECIL");
                                        return;
                                }
                                break;

                        }

                        Console.WriteLine("\nPRECIONE ENTER PARA CONTINUAR\n");
                        //Console.ReadKey();
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                        break;
                    #endregion

                    #region Bloco Produto
                    case '2':
                        Produto prd = new Produto();
                        string retorno1 = string.Empty;
                        Console.WriteLine("\nEscolha a operação");
                        Console.WriteLine("1 - INSERIR PRODUTO");
                        Console.WriteLine("2 - CONSULTAR TODOS PRODUTOS");
                        Console.WriteLine("3 - CONSULTAR IDPRODUTO");

                        var opcao1 = Console.ReadKey();

                        switch (opcao1.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("\nInserindo Produto");

                                prd.NomeProduto = "ProdutoTeste123";
                                prd.DescricaoProduto = "qualquercoisa123";
                                prd.Ativo = false;
                                prd.AdicionaProduto(prd);

                                Console.WriteLine("Produto Inserido");

                                break;

                            case '2':
                                Console.WriteLine("\n");
                                List<Produto> lstProduto = new Produto().LoadProduto();
                                foreach (Produto item in lstProduto)
                                {
                                    Console.WriteLine($"{item.IdProduto}\t{item.NomeProduto}\t{item.DescricaoProduto}\t{Convert.ToInt32(item.Ativo)}\t");
                                }

                                break;

                            case '3':
                                Console.WriteLine("\nDIGITA O QUAL IDPRODUTO SE QUE PROCURA");

                                var idproduto = Convert.ToInt32(Console.ReadLine());


                                switch (Type.GetTypeCode(idproduto.GetType()))
                                {
                                    case TypeCode.Int32:
                                        Produto item = prd.WhereProduto(Convert.ToInt32(idproduto));
                                        if (item != null)
                                        {
                                            Console.WriteLine($"{item.IdProduto}\t{item.NomeProduto}\t{item.DescricaoProduto}\t{Convert.ToInt32(item.Ativo)}\t\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("NAO TEM O IDPRODUTO SOLICITADO\n");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("DIGITA UM NUMERO IMBECIL");
                                        return;
                                }
                                break;

                        }
                        Console.WriteLine("\nPRECIONE ENTER PARA CONTINUAR\n");
                        //Console.ReadKey();
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                        break;
                        #endregion
                }
            }
        }
    }
}