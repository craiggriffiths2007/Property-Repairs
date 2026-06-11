using PropertySurveyService.Models;

internal class FitJobDTO
{
    public JobDTO Job { get; set; }

    public JobHeader Head { get; set; }
    public List<Material> Items { get; set; }
    public List<Panel> Panels { get; set; }
    public List<Aluminium> Aluminia { get; set; }
    public List<Bifolding> Bifolds { get; set; }
    public List<Composite> Composites { get; set; }
    public List<Conservatory> Cons { get; set; }
    public List<Garage> Garages { get; set; }
    public List<Glass> Glass { get; set; }
    public List<Greenhouse> Greens { get; set; }
    public List<Lockmech> Locks { get; set; }
    public List<Timber> Timbers { get; set; }
    public List<UPVC> UPVCs { get; set; }
    public List<string> Images { get; set; }

}