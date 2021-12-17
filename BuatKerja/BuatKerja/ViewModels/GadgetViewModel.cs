using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BuatKerja.Models;
using Xamarin.Forms;

namespace BuatKerja.ViewModels
{
    public class GadgetViewModel
    {
        public ObservableCollection<Gadget> Gadget { get; private set; } = new ObservableCollection<Gadget>();
        public GadgetViewModel()
        {
            CreateGadgetCollections();
        }

        async Task CreateGadgetCollections()
        {
            Gadget.Add(new Gadget
            {
                Name = "Mi TV P1 32 inch",
                Display = ""
            });

            await Task.Delay(2000);
        }
    }
}