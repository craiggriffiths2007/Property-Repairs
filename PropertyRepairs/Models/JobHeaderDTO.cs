using PropertyRepairs.Models;

public class JobHeaderDTO
{
    public JobHeader Head { get; set; }
    public List<ItemAssembly> Assembly { get; set; } = new List<ItemAssembly>();
    public List<Panel> Panel { get; set; } = new List<Panel>();
    public List<Bifolding> Bifolding { get; set; } = new List<Bifolding>();
    public List<Composite> Composite { get; set; } = new List<Composite>();
    public List<Conservatory> Conservatory { get; set; } = new List<Conservatory>();
    public List<Garage> Garage { get; set; } = new List<Garage>();
    public List<Glass> Glass { get; set; } = new List<Glass>();
    public List<Greenhouse> Greenhouse { get; set; } = new List<Greenhouse>();
    public List<Lockmech> Lockmech { get; set; } = new List<Lockmech>();
    public List<string> Images { get; set; } = new List<string>();
}
