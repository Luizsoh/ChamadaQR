namespace ResctrictedAccess.Web.Domain.Admin
{
    using MessagingToolkit.QRCode.Codec;
    using System;
    using System.Drawing;

    public class QR
    {
        public string Chave { get; set; }
        public Evento Evento { get; set; }
        public Tempo Tempo { get; set; }

        internal static byte[] Criar(string texto)
        {
            QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
            qrCodecEncoder.QRCodeBackgroundColor = Color.White;
            qrCodecEncoder.QRCodeForegroundColor = Color.Black;
            qrCodecEncoder.CharacterSet = "UTF-8";
            qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodecEncoder.QRCodeScale = 6;
            qrCodecEncoder.QRCodeVersion = 0;
            qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
            Image img;

            img = qrCodecEncoder.Encode(texto);
            var imgconv = new ImageConverter().ConvertTo(img, typeof(byte[]));
            return (byte[])imgconv;
        }
    }
}