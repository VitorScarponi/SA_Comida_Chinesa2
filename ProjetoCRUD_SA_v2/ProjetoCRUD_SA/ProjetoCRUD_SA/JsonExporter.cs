using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ProjetoCRUD_SA
{
    internal static class JsonExporter
    {
        private static readonly JsonSerializerOptions Opcoes = new JsonSerializerOptions
        {
            WriteIndented = true,
            // mantém acentos e emojis legíveis no arquivo
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        // Gera o produtos.json (só pratos ATIVOS) com os nomes que o site já usa.
        public static string Exportar(DataTable tabela, string pastaSite)
        {
            var lista = new List<object>();
            foreach (DataRow r in tabela.Rows)
            {
                if (!Convert.ToBoolean(r["ativo"])) continue;

                lista.Add(new
                {
                    id = Convert.ToInt32(r["id"]),
                    name = r["nome"].ToString(),
                    desc = r["descricao"].ToString(),
                    price = Convert.ToDecimal(r["preco"]),
                    emoji = r["emoji"].ToString(),
                    tag = r["tag"].ToString(),
                    category = r["categoria"].ToString()
                });
            }

            string caminho = Path.Combine(pastaSite, "produtos.json");
            File.WriteAllText(caminho, JsonSerializer.Serialize(lista, Opcoes), new UTF8Encoding(false));
            return caminho;
        }
    }
}
