namespace Weather.Data.Nws;

public class ErrorResponse
{
    public string CorrelationId { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public int Status { get; set; }
    public string Detail { get; set; }
    public string Instance { get; set; }
}
