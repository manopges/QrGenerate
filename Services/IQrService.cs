using QrMicroservice.Models;

namespace QrMicroservice.Services;

public interface IQrService
{
    QrGenerateResponse Generate(QrGenerateRequest request);
}
