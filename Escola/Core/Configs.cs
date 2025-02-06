using System;
using System.IO;
using System.Text.Json;

public static class Configs
{
    private const string ConfigFilePath = "config.json";

    public class AppSettings
    {
        public string NomeEscola { get; set; } = "Padrão";
    }

    public static AppSettings CarregarConfiguracoes()
    {
        if (File.Exists(ConfigFilePath))
        {
            // Carregar configurações existentes
            string json = File.ReadAllText(ConfigFilePath);
            return JsonSerializer.Deserialize<AppSettings>(json);
        }
        else
        {
            // Criar configurações padrão
            var defaultSettings = new AppSettings();
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
