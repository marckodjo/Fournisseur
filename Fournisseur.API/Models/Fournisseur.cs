using System.ComponentModel.DataAnnotations;

namespace Fournisseur.API.Models;

public class Fournisseur
{
    public int Id { get; set; }
    [Required]
    public string Nom { get; set; }
    [Required]
    public string Adresse { get; set; }
    public string Ville { get; set; }
    public string CodePostal { get; set; }
    public string Pays { get; set; }
    [Required]
    public string Téléphone { get; set; }
    public string Email { get; set; }

}

