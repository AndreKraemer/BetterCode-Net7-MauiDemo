using BetterCode7MauiDemo.Models;
using BetterCode7MauiDemo.ViewModels;
using BetterCode7MauiDemo.Views;

namespace BetterCode7MauiDemo.ApplicationWindows
{
    public class SessionDetailWindow : Window
    {
        private Session _session;

        public SessionDetailWindow(Session session)
        {
            _session = session;
        }


        protected override void OnHandlerChanging(HandlerChangingEventArgs args)
        {
            base.OnHandlerChanging(args);

            if(Page == null)
            {
                var vm = new SessionDetailPageViewModel
                {
                    Session = _session
                };

                Page = new SessionDetailPage(vm);

            }
        }
    }
}
