using MockingApp.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MockingApp.ViewModels
{
    public class DogsPageViewModel : BasePageViewModel
    {
        public ICommand GetDogsCommand { get; set; }
        public ObservableCollection<Dog> Dogs { get; set; }
        private ObservableCollection<Dog> items;
        public ObservableCollection<Dog> Items
        {
            get { return items; }
            set
            {
                if (items != value)
                {
                    items = value;
                    OnPropertyChanged("Items");
                }
               
            }
        }

        public DogsPageViewModel()
        {
            GetDogsCommand = new Command(async () => await GetDogs());
            GetDogsCommand.Execute(null);
        }

        async Task GetDogs()
        {
            IsBusy = true;
            var dogs = await Api.GetDogs();
            if (dogs != null)
            {
                Items = new ObservableCollection<Dog>(dogs);
            }
            IsBusy = false;
        }
    }
}
