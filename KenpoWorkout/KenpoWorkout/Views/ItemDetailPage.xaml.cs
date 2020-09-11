using KenpoWorkout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KenpoWorkout.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {


        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();


        }
    }
}