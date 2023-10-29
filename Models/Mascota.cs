#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstConnection.Models;
public class Mascota
{
    [Key]
    public int MascotaId { get; set; }
    public string Nombre { get; set; } 
    public int Edad { get; set; }
    public bool Pelo { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
    