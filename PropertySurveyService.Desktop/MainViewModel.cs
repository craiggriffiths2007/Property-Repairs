using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using Microsoft.Extensions.DependencyInjection;
using PropertySurveyService.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PropertySurveyService.Desktop
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IServiceProvider _services;

        public ObservableCollection<Customer> Customers { get; } = new();

        private string? _filterText;
        public string? FilterText
        {
            get => _filterText;
            set { _filterText = value; OnPropertyChanged(); }
        }

        private int _pageNumber = 1;
        public int PageNumber
        {
            get => _pageNumber;
            set { _pageNumber = value; OnPropertyChanged(); }
        }

        private int _totalPages = 1;
        public int TotalPages
        {
            get => _totalPages;
            set { _totalPages = value; OnPropertyChanged(); }
        }

        public int PageSize { get; set; } = 10;

        public ICommand NextPageCommand { get; }
        public ICommand PrevPageCommand { get; }
        public ICommand SearchCommand { get; }

        public MainViewModel(IServiceProvider services)
        {
            _services = services;
            NextPageCommand = new RelayCommand(async _ => await ChangePage(PageNumber + 1), _ => PageNumber < TotalPages);
            PrevPageCommand = new RelayCommand(async _ => await ChangePage(PageNumber - 1), _ => PageNumber > 1);
            SearchCommand = new RelayCommand(async _ => await LoadPageAsync(1));
        }

        public async Task ChangePage(int newPage)
        {
            if (newPage < 1) newPage = 1;
            await LoadPageAsync(newPage);
        }

        public async Task LoadPageAsync(int page)
        {
            using var scope = ((IServiceScopeFactory?)_services.GetService(typeof(IServiceScopeFactory)))?.CreateScope();
            var db = (PropertySurveyService.Data.AppDBContext?)scope?.ServiceProvider.GetService(typeof(PropertySurveyService.Data.AppDBContext));
            if (db == null) return;

            var query = db.Customer.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(FilterText))
            {
                var f = FilterText.Trim();
                query = query.Where(c => c.Name.Contains(f));
            }

            var totalCount = await query.CountAsync();
            TotalPages = Math.Max(1, (int)Math.Ceiling(totalCount / (double)PageSize));
            if (page < 1) page = 1;
            if (page > TotalPages) page = TotalPages;

            var items = await query.OrderBy(c => c.Name).Skip((page - 1) * PageSize).Take(PageSize).ToListAsync();
            Customers.Clear();
            foreach (var c in items) Customers.Add(c);
            PageNumber = page;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
