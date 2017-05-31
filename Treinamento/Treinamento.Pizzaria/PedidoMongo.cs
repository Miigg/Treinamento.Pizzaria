using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization;

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

        public List<PedidoMongo> WherePedido(string nomepedido)
        {
            var listOfPedidowhere = new List<PedidoMongo>();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Treinamento");
            var collec = database.GetCollection<PedidoMongo>("Pedido");

            var results = collec.Find(x => x.NomePedido == nomepedido).ToList();
            listOfPedidowhere = results;

            return listOfPedidowhere;
            

        }

        public List<PedidoMongo> LoadPedido()
        {
            var listOfPedido = new List<PedidoMongo>();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Treinamento");
            var collec = database.GetCollection<PedidoMongo>("Pedido");

            var results = collec.Find(x => x.NomePedido == "a").ToList();
            listOfPedido = results;

            //var filter2 = new BsonDocument();
            //var count = 0;
            //using (var cursor = await collec.FindAsync(filter2))
            //{
            //    while (await cursor.MoveNextAsync())
            //    {
            //        var batch = cursor.Current;
            //        foreach (var document in batch)
            //        {
            //            //PedidoMongo ped = BsonSerializer.Deserialize<PedidoMongo>(document);
            //            //listOfPedido.Add(ped);
            //            // process document
            //            count++;
            //        }
            //    }
            //}

            return listOfPedido;
        }


    }

}


