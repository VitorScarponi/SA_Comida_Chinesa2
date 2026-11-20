using System;
using System.IO;
using System.Text.Json;

namespace ProjetoCRUD_SA
{
    // Guarda só a pasta do site (config.json ao lado do .exe)
    internal class AppConfig
    {
        public string PastaSite { get; set; } = "";

        private static string Caminho => Path.Combine(AppContext.BaseDirectory, "config.json");

        public static AppConfig Load()
        {
            try
            {
                if (File.Exists(Caminho))
                    return JsonSerializer.Deserialize<AppConfig>(File.ReadAllText(Caminho)) ?? new AppConfig();
            }
            catch { /* arquivo inválido: começa vazio */ }
            return new AppConfig();
        }

        public void Save()
        {
            File.WriteAllText(Caminho, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
