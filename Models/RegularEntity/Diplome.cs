using System.ComponentModel.DataAnnotations;
namespace QUALITE.Models.RegularEntity;

public class Diplome
{
	[Required(ErrorMessage = "Code diplôme obligatoire")]
	public int Code { get; set; }
	public string? TypeDiplomeAcademique { get; set; }
};