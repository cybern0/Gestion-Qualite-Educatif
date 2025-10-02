using System.ComponentModel.DataAnnotations;
namespace QUALITE.Models.RegularEntity;

public class Secteur
{
	[Required(ErrorMessage = "Code SECTEUR obligatoire")]
	public int Code { get; set; }
	public string? SECTEUR { get; set; }
};