using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Pizzaria
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string DescricaoProduto { get; set; }

        public bool Ativo { get; set; }

        public bool AdicionaProduto(Produto produto)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO produto VALUES (@nome, @descricao, @ativo)";

                cmd.Parameters.AddWithValue("@nome", produto.NomeProduto);
                cmd.Parameters.AddWithValue("@descricao", produto.DescricaoProduto);
                cmd.Parameters.AddWithValue("@ativo", produto.Ativo);
                cn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
        }

        public Produto WhereProduto(int id)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM produto where idproduto = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                Produto produto = null;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produto = new Produto();
                        produto.IdProduto = Convert.ToInt32(reader["idproduto"]);
                        produto.NomeProduto = reader["nome"].ToString();
                        produto.DescricaoProduto = reader["descricao"].ToString();
                        produto.Ativo = Convert.ToBoolean(reader["ativo"]);

                    }
                }

                return produto;
            }

        }
        public List<Produto> LoadProduto()
        {
            var listOfProduto = new List<Produto>();

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM produto";
                {
                    cn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var produto = new Produto();
                            produto.IdProduto = Convert.ToInt32(reader["idproduto"]);
                            produto.NomeProduto = reader["nome"].ToString();
                            produto.DescricaoProduto = reader["descricao"].ToString();
                            produto.Ativo = Convert.ToBoolean(reader["ativo"]);
                            listOfProduto.Add(produto);
                            //Console.Write("{0}\t{1}\t{2}\t{3} \n", reader[0], reader[1], reader[2], reader[3]);
                        }
                    }
                }
            }

            return listOfProduto;
        }
    }
}
