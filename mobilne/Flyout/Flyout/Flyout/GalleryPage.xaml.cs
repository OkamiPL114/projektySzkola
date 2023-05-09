using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flyout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    class Photo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
    }
    public partial class GalleryPage : ContentPage
    {
        List<Photo> photos;
        int index = 0;
        public GalleryPage()
        {
            InitializeComponent();
            photos = new List<Photo>()
            {
                new Photo(){ FileName = "home.png", Title = "Domek"},
                new Photo(){ FileName = "gallery.png", Title = "Galeria"},
                new Photo(){ FileName = "about.png", Title = "Ikonka o mnie"},
            };
            PhotosCarouselView.ItemsSource = photos;
        }

        private void previousButton_Clicked(object sender, EventArgs e)
        {
            index--;
            if(index < 0)
            {
                index = photos.Count - 1;
            }
            PhotosCarouselView.Position = index;
        }

        private void nextButton_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index > photos.Count - 1)
            {
                index = 0;
            }
            PhotosCarouselView.Position = index;
        }
    }
}