﻿using System;
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
        public static bool VerificarStrings(string msg, params string[] args) // Verifica as string, caso tenha uma vazia, gera o erro e retorna a mensagem definida pelo usuario.
        {   
            foreach (string arg in args)
            {
                if (string.IsNullOrEmpty(arg))
                {
                    MessageBox.Show(msg);
                    return false;
                }
            }
            return true;
        }

        public static void AtivarPainel(Form formulario, Panel painelAtivar, Point? localizacao = null)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is Panel painel && painel.Visible)
                {
                    painel.Visible = false;
                }
            }

            painelAtivar.Visible = true;
            painelAtivar.Location = localizacao ?? new Point(0, 0);
        }

        public static string FormatarTelefone(string telefone)
        {
            telefone = telefone.Trim();
            telefone = new string(telefone?.Where(char.IsDigit).ToArray());
            if (telefone.Length != 11)
            {
                Console.WriteLine("[FUNCOES] O telefone deve ter exatamente 11 dígitos.");
                return telefone; // Retorna o telefone original se não tiver 11 dígitos
            }
            return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 1)} {telefone.Substring(3, 4)}-{telefone.Substring(7, 4)}";
        }

        public static string FormatarCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                Console.WriteLine("[FUNCOES] O CPF deve ter exatamente 11 dígitos.");
                return cpf;
            }
            return String.Format("{0:000\\.000\\.000\\-00}", long.Parse(cpf));
        }
        /*public static string FormatarCodigo(int numero)
        {
            return numero.ToString().PadLeft(6, '0');
        }*/
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
                if (File.Exists(novoCaminho))
                {
                    File.Delete(novoCaminho);
                    Debug.WriteLine("Foto anterior deletada.");
                }

                File.Copy(fotoPath, novoCaminho, true);
                Debug.WriteLine("Foto salva com sucesso!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao salvar a foto: {ex.Message}");
            }
        }


        public static void DeletarFoto(string cpf, int tipo)
        {
            string tipoStr = tipo == Global.TIPO_ALUNO ? "Alunos" : tipo == Global.TIPO_PROFESSOR ? "Professores" : string.Empty;
            string localDeletar = "Fotos";
            string qrDeletar = "QrCodes";
            string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, localDeletar, tipoStr);
            string pastaDestinoQr = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, qrDeletar, tipoStr);

            if (string.IsNullOrEmpty(tipoStr))
            {
                Debug.WriteLine("Tipo inválido");
                return;
            }

            if (!Directory.Exists(pastaDestino) || !Directory.Exists(pastaDestinoQr))
            {
                Debug.WriteLine("Pasta não encontrada.");
                return;
            }

            string[] arquivos = Directory.GetFiles(pastaDestino, $"{cpf}.*");
            string[] arquivosQr = Directory.GetFiles(pastaDestinoQr, $"{cpf}.*");

            if (arquivos.Length > 0 || arquivosQr.Length > 0)
            {
                try
                {
                    if (arquivos.Length > 0)
                    {
                        File.Delete(arquivos[0]);
                        Debug.WriteLine($"Foto deletada com sucesso: {arquivos[0]}");
                    }
                    else
                    {
                        Debug.WriteLine("Foto não encontrada para deletar.");
                    }

                    if (arquivosQr.Length > 0)
                    {
                        File.Delete(arquivosQr[0]);
                        Debug.WriteLine($"QrCode deletado com sucesso: {arquivosQr[0]}");
                    }
                    else
                    {
                        Debug.WriteLine("QrCode não encontrado para deletar.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Erro ao deletar os arquivos: {ex.Message}");
                }
            }
            else
            {
                Debug.WriteLine("Nenhum arquivo encontrado para deletar.");
            }
        }

        public static bool ValidarTelefone(string telefone)
        {
            if (telefone.Length != 11)
            {
                MessageBox.Show("Digite os 11 numeros do Telefone!");
                return false;
            }
            else
            {
                return true;
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

        public static bool ValidarData(string data)
        {
            if (data.Length != 8)
            {
                MessageBox.Show("Digite a data corretamente!");
                return false;
            }

            if (DateTime.TryParseExact(data, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida))
            {
                if (dataConvertida.Year >= 1900)
                {
                    Debug.WriteLine("Data válida: " + dataConvertida.ToString("dd/MM/yyyy"));
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro a data não pode ser menor que 1900!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Erro: Data inválida!");
                return false;
            }
        }

        public static void CarregarImagem(string cpf, int tipo, PictureBox pb, bool? TemQRCode, PictureBox? pb_Qr)
        {
            string pastaDestino = "";
            string pastaDestQrCode = "";

            if (tipo == Global.TIPO_ALUNO)
            {
                pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos", "Alunos");
                pastaDestQrCode = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QrCodes", "Alunos");
            }
            else if (tipo == Global.TIPO_PROFESSOR)
            {
                pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos", "Professores");
                pastaDestQrCode = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QrCodes", "Professores");
            }

            if (!Directory.Exists(pastaDestino))
            {
                MessageBox.Show("A pasta de fotos não foi encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TemQRCode == true && !Directory.Exists(pastaDestQrCode))
            {
                MessageBox.Show("A pasta de QR Codes não foi encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] arquivos = Directory.GetFiles(pastaDestino, cpf + ".*"); // Procura a imagem com qualquer extensão

            if (arquivos.Length > 0)
            {
                try
                {
                    using (var stream = new FileStream(arquivos[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            stream.CopyTo(memoryStream);
                            pb.Image = Image.FromStream(memoryStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a foto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pb.Image = null;
                Debug.WriteLine("Imagem não encontrada, setada padrão.");
            }

            if (TemQRCode == true && pb_Qr != null)
            {
                string[] qrCodes = Directory.GetFiles(pastaDestQrCode, cpf + ".*");

                if (qrCodes.Length > 0)
                {
                    try
                    {
                        using (var stream = new FileStream(qrCodes[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                stream.CopyTo(memoryStream);
                                pb_Qr.Image = Image.FromStream(memoryStream);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar o QR Code: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pb_Qr.Image = null;
                    Debug.WriteLine("QR Code não encontrado, setado padrão.");
                }
            }
        }
    }
}
