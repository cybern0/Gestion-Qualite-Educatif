using System.ComponentModel.DataAnnotations;
namespace QUALITE.Models.RegularEntity;

public class District
{
	[Required(ErrorMessage = "Code District obligatoire")]
	public int CodeTypeDistrict { get; set; }
	public string? TypeDistrict { get; set; }
};