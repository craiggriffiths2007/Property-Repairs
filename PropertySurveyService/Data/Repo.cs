

using Microsoft.EntityFrameworkCore;
using PropertyRepairs.Data;
using PropertyRepairs.Models;
using PropertyRepairs.ViewModels;
using SQLitePCL;

namespace PropertyRepairs.Data
{
    public interface IRepo // no real need for this interface
    {
        AppDBContext Db { get; }

        IEnumerable<PhotoImage> GetSurveyItemImages(string contractCode, int itemNumber);
    }
    public class Repo : IRepo
    {
        private readonly AppDBContext _context;

        public AppDBContext Db => _context;

        public Repo(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<PhotoImage> GetSurveyItemImages(string contractCode, int itemNumber)
        {
            string pattern = $"{contractCode:00000000}____{itemNumber:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

            var photoimages = _context.Images
                .Where(x => EF.Functions.Like(x.Filename, pattern))
                .OrderByDescending(x => x.Filename.Substring(9, 1))
                .ToList();

            return photoimages ?? new List<PhotoImage>();
        }



        public VehicleCheckDetailsViewModel GetVehicleCheckDetailsViewModel(int id, enum_vehicle_type vehicle_type)
        {
            var viewModel = new VehicleCheckDetailsViewModel();
            string paddedItemNumber = "";
            string pattern = "";

            switch (vehicle_type)
            {
                case enum_vehicle_type.delivery_hgv:
                    viewModel.DeliveryHGV = _context.DeliveryHGVs.FirstOrDefault(m => m.Id == id);
                    if (viewModel.DeliveryHGV == null) return viewModel;

                    paddedItemNumber = viewModel.DeliveryHGV.item_number.ToString("D8");
                    pattern = $"{viewModel.DeliveryHGV.CheckID}_{paddedItemNumber}_dhgv%";
                    break;
                case enum_vehicle_type.delivery_van:
                    viewModel.DeliveryVan = _context.DeliveryVans.FirstOrDefault(m => m.Id == id);
                    if (viewModel.DeliveryVan == null) return viewModel;

                    paddedItemNumber = viewModel.DeliveryVan.item_number.ToString("D8");
                    pattern = $"{viewModel.DeliveryVan.CheckID}_{paddedItemNumber}_dvan%";
                    break;
                case enum_vehicle_type.fitter_van:
                    viewModel.FitterVan = _context.FitterVans.FirstOrDefault(m => m.Id == id);
                    if (viewModel.FitterVan == null) return viewModel;

                    paddedItemNumber = viewModel.FitterVan.item_number.ToString("D8");
                    pattern = $"{viewModel.FitterVan.CheckID}_{paddedItemNumber}_fvan%";
                    break;
                case enum_vehicle_type.sales_car:
                    viewModel.SalesCar = _context.SalesCars.FirstOrDefault(m => m.Id == id);
                    if (viewModel.SalesCar == null) return viewModel;

                    paddedItemNumber = viewModel.SalesCar.item_number.ToString("D8");
                    pattern = $"{viewModel.SalesCar.CheckID}_{paddedItemNumber}_scar%";
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }

            var photoimages = _context.Images
                .Where(x => EF.Functions.Like(x.Filename, pattern))
                .ToList();

            viewModel.photoLeft = photoimages.Where(i => i.Filename.Substring(43, 3) == "pas").FirstOrDefault() ?? new PhotoImage();
            viewModel.photoRight = photoimages.Where(i => i.Filename.Substring(43, 3) == "drv").FirstOrDefault() ?? new PhotoImage();
            viewModel.photoFront = photoimages.Where(i => i.Filename.Substring(43, 3) == "fro").FirstOrDefault() ?? new PhotoImage();
            viewModel.photoBack = photoimages.Where(i => i.Filename.Substring(43, 3) == "rea").FirstOrDefault() ?? new PhotoImage();

            viewModel.diagramLeft = photoimages.Where(i => i.Filename.Substring(43, 3) == "pad").FirstOrDefault() ?? new PhotoImage();
            viewModel.diagramRight = photoimages.Where(i => i.Filename.Substring(43, 3) == "drd").FirstOrDefault() ?? new PhotoImage();
            viewModel.diagramFront = photoimages.Where(i => i.Filename.Substring(43, 3) == "frd").FirstOrDefault() ?? new PhotoImage();
            viewModel.diagramBack = photoimages.Where(i => i.Filename.Substring(43, 3) == "red").FirstOrDefault() ?? new PhotoImage();

            viewModel.drv_signature = photoimages.Where(i => i.Filename.Substring(43, 3) == "dsi").FirstOrDefault() ?? new PhotoImage();
            viewModel.chk_signature = photoimages.Where(i => i.Filename.Substring(43, 3) == "csi").FirstOrDefault() ?? new PhotoImage();

            viewModel.insidePhotos = photoimages.Where(i => i.Filename.Substring(43, 1) == "i").ToList() ?? new List<PhotoImage>();

            return viewModel;
        }
}
}
