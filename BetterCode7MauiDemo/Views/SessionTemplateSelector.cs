using BetterCode7MauiDemo.Models;

namespace BetterCode7MauiDemo.Views;


public class SessionTemplateSelector : DataTemplateSelector
{
    public DataTemplate SessionTemplate { get; set; }
    public DataTemplate BreakTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        switch ((item as Session).SessionType)
        {
            case SessionType.Session:
                return SessionTemplate;
            case SessionType.Break:
                return BreakTemplate;
            default:
                return SessionTemplate;

        }

    }
}