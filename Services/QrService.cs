using QRCoder;
using QrMicroservice.Models;

namespace QrMicroservice.Services;

public class QrService : IQrService
{
    public QrGenerateResponse Generate(QrGenerateRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Policy))
        {
            throw new ArgumentException("Policy is required.");
        }

        if (string.IsNullOrWhiteSpace(request.File))
        {
            throw new ArgumentException("File is required.");
        }

        string payload = $"{request.Policy}|{request.Type}|{request.File}";

        QRCodeGenerator qrGenerator = new();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
        PngByteQRCode pngQrCode = new(qrCodeData);
        byte[] qrBytes = pngQrCode.GetGraphic(20);

        return new QrGenerateResponse
        {
            Policy = request.Policy,
            Base64 = Convert.ToBase64String(qrBytes)
        };
    }
}
