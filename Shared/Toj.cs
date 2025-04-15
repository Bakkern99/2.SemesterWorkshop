using System;
namespace Shared;

public class Toj
{
    public string OwnerId { get; set; }
    public string Type { get; set; } = String.Empty;

    public int size { get; set; } 

    public string farve { get; set; } = string.Empty;

    public bool status { get; set; } = true;

    public int Id { get; set; }

    public string? imageUrl { get; set; } = string.Empty;

    public int pris { get; set; } = 0; 
    
    public string Beskrivelse { get; set; } = string.Empty;
    
}
