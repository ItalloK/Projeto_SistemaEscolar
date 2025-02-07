using System;
using System.IO;
using System.Text.Json;

public static class Configs
{
    private const string ConfigFilePath = "config.json";

    public class AppSettings
    {
        public string NomeEscola { get; set; } = "Padrão";
        public string FotoPrincipal { get; set; } = "";
        public string FundoCarteirinha { get; set; } = "";
    }

    public static AppSettings CarregarConfiguracoes()
    {
        if (File.Exists(ConfigFilePath))
        {
            string json = File.ReadAllText(ConfigFilePath); // Carregar configurações existentes
            return JsonSerializer.Deserialize<AppSettings>(json);
        }
        else
        {
            var defaultSettings = new AppSettings(); // Criar configurações padrão
            SalvarConfiguracoes(defaultSettings); // Salvar arquivo padrão
            return defaultSettings;
        }
    }

    public static void SalvarConfiguracoes(AppSettings settings)
    {
        string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(ConfigFilePath, json);
    }
}
