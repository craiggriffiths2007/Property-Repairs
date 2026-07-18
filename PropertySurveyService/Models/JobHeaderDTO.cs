using PropertySurveyService.Models;

public class JobHeaderDTO
{
    public JobHeader Head { get; set; }
    public List<Material> Material { get; set; } = new List<Material>();
    public List<Panel> Panel { get; set; } = new List<Panel>();
    public List<Aluminium> Aluminium { get; set; } = new List<Aluminium>();
    public List<Bifolding> Bifolding { get; set; } = new List<Bifolding>();
    public List<Composite> Composite { get; set; } = new List<Composite>();
    public List<Conservatory> Conservatory { get; set; } = new List<Conservatory>();
    public List<Garage> Garage { get; set; } = new List<Garage>();
    public List<Glass> Glass { get; set; } = new List<Glass>();
    public List<Greenhouse> Greenhouse { get; set; } = new List<Greenhouse>();
    public List<Lockmech> Lockmech { get; set; } = new List<Lockmech>();
    public List<Timber> Timber { get; set; } = new List<Timber>();
    public List<UPVC> UPVC { get; set; } = new List<UPVC>();
    public List<string> Images { get; set; } = new List<string>();
}
