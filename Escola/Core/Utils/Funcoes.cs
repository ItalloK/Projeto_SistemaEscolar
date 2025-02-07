using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Utils
{
    public class Funcoes
    {
        public static string FormatarCodigo(int numero)
        {
            return numero.ToString().PadLeft(6, '0');
        }
        public static string FormatarData(string data)
        {
            data = data.Trim();
            if (data.Length == 8)
            {
                return data.Insert(2, "/").Insert(5, "/");
            }
            else
            {
                Debug.WriteLine("[FUNCOES] A data deve ter exatamente 8 caracteres (ddMMyyyy).");
                return data;
            }
        }

        public static void SalvarFoto(string cpf, string fotoPath, int tipo)
        {
            string tipoStr = string.Empty;
            string localSalvar = string.Empty;

            if (tipo == Global.TIPO_ALUNO)
            {
                tipoStr = "Alunos";
                localSalvar = "Fotos";
            }
            else if (tipo == Global.TIPO_PROFESSOR)
            {
                tipoStr = "Professores";
                localSalvar = "Fotos";
            }
            else if (tipo == Global.TIPO_CONFIG)
            {
                tipoStr = "Principal";
                localSalvar = "Configuracoes";
            }
            else if (tipo == Global.TIPO_CARTEIRINHA)
            {
                tipoStr = "Carteirinha";
                localSalvar = "Configuracoes";
            }

            string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, localSalvar, tipoStr);
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            string extensao = Path.GetExtension(fotoPath);
            string novoCaminho = Path.Combine(pastaDestino, $"{cpf}{extensao}");
            try
            {
                File.Copy(fotoPath, novoCaminho, true);
                Debug.WriteLine("Foto salva com sucesso!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao salvar a foto: {ex.Message}");
                return;
            }
        }


        public static bool ValidarCPF(string cpf)
        {
            if(cpf.Length != 11)
            {
                MessageBox.Show("Digite os 11 numeros do CPF!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool VerificarSeCarregouFoto(string fotopath)
        {
            if (string.IsNullOrWhiteSpace(fotopath) || !File.Exists(fotopath))
            {
                MessageBox.Show("Por favor, carregue uma foto antes de salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
