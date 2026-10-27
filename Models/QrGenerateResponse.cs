namespace QrMicroservice.Models;

public class QrGenerateResponse
{
    public string Policy { get; set; } = string.Empty;
    public string Base64 { get; set; } = string.Empty;
}
