using System.ComponentModel.DataAnnotations;
namespace QUALITE.Services.RegularServices;

public class ModelFpeServices
{
	[Required(ErrorMessage = "Code FPE obligatoire")]
	public int Code { get; set; }
	public string? Libelle { get; set; }
};