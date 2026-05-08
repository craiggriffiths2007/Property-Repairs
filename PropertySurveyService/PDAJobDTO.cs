using PropertySurveyService.Models;

internal class PDAJobDTO
{
    public JobDTO Job { get; set; }

    public Header Head { get; set; }
    public List<ItemTable> Items { get; set; }
    public List<PanelTable> Panels { get; set; }
    public List<AluminiumTable> Aluminia { get; set; }
    public List<BifoldTable> Bifolds { get; set; }
    public List<CompositeTable> Composites { get; set; }
    public List<ConsTable> Cons { get; set; }
    public List<GarageTable> Garages { get; set; }
    public List<GlassTable> Glass { get; set; }
    public List<GreenTable> Greens { get; set; }
    public List<LockingTable> Locks { get; set; }
    public List<TimberTable> Timbers { get; set; }
    public List<UPVCTable> UPVCs { get; set; }
    public List<string> Images { get; set; }

}