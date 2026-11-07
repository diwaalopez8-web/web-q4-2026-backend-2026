namespace proyectq4backend760.models;

public class Taskitem
{
    public string Id { get; set; } = string.Empty;
    public string tittle { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public string priority { get; set; } = string.Empty;
    public string Userid { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
}