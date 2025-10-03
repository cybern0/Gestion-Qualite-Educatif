using System.ComponentModel.DataAnnotations;
namespace QUALITE.Models.RegularEntity;

public class Sexe
{
	[Required(ErrorMessage = "Code type Sexe obligatoire")]
	public int CodeTypeSexe { get; set; }
	[MinLength(1, ErrorMessage = "Type Sexe doit contenir 1 caractère")]
	public string? TypeSexe { get; set; }
};