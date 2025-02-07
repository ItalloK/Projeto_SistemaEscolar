using System;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using QRCoder;

namespace Escola.Core.Utils
{
    public class QrCode
    {
        public static void GerarQRcode(string dadoUsuario, int tipo)
        {
            string pastaDestino = "";

            if (tipo == Global.TIPO_ALUNO)
            {
                pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QrCodes", "Alunos");
            }
            else if (tipo == Global.TIPO_PROFESSOR)
            {
                pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QrCodes", "Professores");
            }

            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(dadoUsuario, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                // Gerando QR Code com fundo branco (temporário)
                Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);

                // Tornando o fundo branco transparente
                qrCodeImage.MakeTransparent(Color.White);

                string caminhoArquivo = Path.Combine(pastaDestino, dadoUsuario + ".png");

                // Salvar a imagem como PNG para preservar a transparência
                qrCodeImage.Save(caminhoArquivo, System.Drawing.Imaging.ImageFormat.Png);

                Debug.WriteLine($"QR Code gerado e salvo em: {caminhoArquivo}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao gerar o QR Code: {ex.Message}");
            }
        }
    }
}
