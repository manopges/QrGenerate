namespace QrMicroservice.Models;

public class QrGenerateRequest
{
    public string Policy { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
}
