using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

using MongoDB.Bson.Serialization.Attributes;


namespace Treinamento.Pizzaria
{
    public class ProdutoMongo
    {
        [BsonId]
        public ObjectId IdProduto { get; set; }
        [BsonElement("NomeProduto")]
        public string NomeProduto { get; set; }
        [BsonElement("DescricaoProduto")]
        public string DescricaoProduto { get; set; }
        [BsonElement("Ativo")]
        public bool Ativo { get; set; }
               

        public bool AdicionaProduto(ProdutoMongo produto)
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Treinamento");
            var collec = database.GetCollection<BsonDocument>("Produto");

            BsonDocument documento = produto.ToBsonDocument();

            collec.InsertOne(documento);

            return true;
        }

        public List<ProdutoMongo> WhereProduto(string nomeproduto)
        {
            var listOfProdutowhere = new List<ProdutoMongo>();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Treinamento");
            var collec = database.GetCollection<ProdutoMongo>("Produto");

            var results = collec.Find(x => x.NomeProduto == nomeproduto).ToList();
            listOfProdutowhere = results;

            return listOfProdutowhere;
            

        }

        public List<ProdutoMongo> LoadProduto()
        {
            var listOfProduto = new List<ProdutoMongo>();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Treinamento");
            var collec = database.GetCollection<ProdutoMongo>("Produto");

            var results = collec.Find(x => true).ToList();
            listOfProduto = results;

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

            return listOfProduto;
        }


    }

}


