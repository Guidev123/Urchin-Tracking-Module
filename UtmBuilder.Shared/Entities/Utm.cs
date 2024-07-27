using UtmBuilder.Shared.ValueObjects;

namespace UtmBuilder.Shared.Entities;

public class Utm
{
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }
    public Url Url { get; private set; } 
    public Campaign Campaign { get; private set; } 
}
