using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Event_App.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        public EventsViewModel()
        {
            Title = "Events";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.driessengroep.nl/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}