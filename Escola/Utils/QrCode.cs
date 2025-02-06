using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using Escola.Config;

namespace Escola.Utils
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

                Bitmap qrCodeImage = qrCode.GetGraphic(20); // O número 20 define o tamanho do QR Code

                string caminhoArquivo = Path.Combine(pastaDestino, dadoUsuario + ".png");
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
