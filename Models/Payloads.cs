using QUALITE.Models.WeakEntity;
using QUALITE.Models.PrincipalEntity;
using QUALITE.Models.RegularEntity;
namespace QUALITE.Models;

public class Payloads
{
    public Etablissement? Etablissement { get; set; }
    public Personnel? Personnel { get; set; }
    public M1? M1 { get; set; }
    public E1? E1 { get; set; }
    public E4? E4 { get; set; }
    public K1? K1 { get; set; }
    public G1? G1 { get; set; }
    public J1? J1 { get; set; }
    public L1? L1 { get; set; }
    public ModelFpe? ModelFpe { get; set; }
}