using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MongoDB.Bson.Serialization.Attributes;

namespace Treinamento.Pizzaria
{
    public class PedidoMongo
    {
        [BsonId]
        public ObjectId IdPedido { get; set; }
        [BsonElement("NomePedido")]
        public string NomePedido { get; set; }
        [BsonElement("TipoPedido")]
        public string TipoPedido { get; set; }
        [BsonElement("StatusPedido")]
        public string StatusPedido { get; set; }

        public bool AdicionaPedido(PedidoMongo pedido)
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Treinamento");
            var collec = database.GetCollection<BsonDocument>("Pedido");

            BsonDocument documento = pedido.ToBsonDocument();

            collec.InsertOne(documento);

            return true;
        }

        public PedidoMongo WherePedido(int id)
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
                PedidoMongo pedido = null;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pedido = new PedidoMongo();
                 //       pedido.IdPedido = reader["idpedido"].to);
                        pedido.NomePedido = reader["nome"].ToString();
                        pedido.TipoPedido = reader["tipo"].ToString();
                        pedido.StatusPedido = reader["status"].ToString();

                    }
                }

                return pedido;
            }

        }

        public List<PedidoMongo> LoadPedido()
        {
            var listOfPedido = new List<PedidoMongo>();

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
                            var pedido = new PedidoMongo();
                           // pedido.IdPedido = Convert.ToInt32(reader["idpedido"]);
                            pedido.NomePedido = reader["nome"].ToString();
                            pedido.TipoPedido = reader["tipo"].ToString();
                            pedido.StatusPedido = reader["status"].ToString();
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


