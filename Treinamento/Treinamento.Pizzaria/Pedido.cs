using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Pizzaria
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public string NomePedido { get; set; }

        public string TipoPedido { get; set; }

        public char StatusPedido { get; set; }

        public bool AdicionaPedido(Pedido pedido)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO pedido VALUES (@nome, @tipo, @status)";

                cmd.Parameters.AddWithValue("@nome", pedido.NomePedido);
                cmd.Parameters.AddWithValue("@tipo", pedido.TipoPedido);
                cmd.Parameters.AddWithValue("@status", pedido.StatusPedido);
                cn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }

        }

        public bool ModificaPedido(Pedido pedido)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE pedido SET nome = @nome,tipo = @tipo,status = @status WHERE idpedido = @idpedido";

                cmd.Parameters.AddWithValue("@idpedido", pedido.IdPedido);
                cmd.Parameters.AddWithValue("@nome", pedido.NomePedido);
                cmd.Parameters.AddWithValue("@tipo", pedido.TipoPedido);
                cmd.Parameters.AddWithValue("@status", pedido.StatusPedido);
                cn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }

        }

        public bool DeletaPedido(Pedido pedido)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE pedido WHERE idpedido = @idpedido";

                cmd.Parameters.AddWithValue("@idpedido", pedido.IdPedido);
                cn.Open();
                cmd.ExecuteNonQuery();
                
                
                return true;
            }

        }


        public Pedido WherePedido(int id)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM pedido where idpedido = @id";

                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                Pedido pedido = null;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pedido = new Pedido();
                        pedido.IdPedido = Convert.ToInt32(reader["idpedido"]);
                        pedido.NomePedido = reader["nome"].ToString();
                        pedido.TipoPedido = reader["tipo"].ToString();
                        pedido.StatusPedido = Convert.ToChar(reader["status"]);

                    }
                }

                return pedido;
            }

        }

        public List<Pedido> LoadPedido()
        {
            var listOfPedido = new List<Pedido>();

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; ;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM pedido";
                {
                    cn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pedido = new Pedido();
                            pedido.IdPedido = Convert.ToInt32(reader["idpedido"]);
                            pedido.NomePedido = reader["nome"].ToString();
                            pedido.TipoPedido = reader["tipo"].ToString();
                            pedido.StatusPedido = Convert.ToChar(reader["status"]);
                            listOfPedido.Add(pedido);
                            //Console.Write("{0}\t{1}\t{2}\t{3} \n", reader[0], reader[1], reader[2], reader[3]);
                        }
                    }
                }
            }

            return listOfPedido;
        }


    }

}


