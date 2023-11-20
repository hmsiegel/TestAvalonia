using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using DynamicData;

using ReactiveUI;

using TestAvalonia.Models;
using TestAvalonia.Services;

namespace TestAvalonia.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly ObservableCollection<SiteIdModel>? _siteIds;

    private SiteIdModel? _siteId;

    public MainWindowViewModel()
    {
        _siteIds = new ObservableCollection<SiteIdModel>();

        Activate();
    }

    public IEnumerable<SiteIdModel>? SiteIds => _siteIds;

    public SiteIdModel? SiteId
    {
        get => _siteId;
        set
        {
            _siteId = value;
            this.RaiseAndSetIfChanged(ref _siteId, value);
        }
    }

    private void Activate()
    {
        var service = new SiteIdService();
        _siteIds!.AddRange(service.GetSiteIds());

        _siteId = SiteId = _siteIds![0];
    }
}
