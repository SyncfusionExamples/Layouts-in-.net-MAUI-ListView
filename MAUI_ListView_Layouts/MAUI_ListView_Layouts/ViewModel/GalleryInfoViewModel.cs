using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

#nullable disable
namespace MAUI_ListView_Layouts
{
    public class GalleryInfoViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<ListViewGalleryInfo> galleryinfo;     
        private double imageHeightRequest;
        #endregion

        #region Constructor

        public GalleryInfoViewModel()
        {   
            GenerateSource();           
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewGalleryInfo> GalleryInfo
        {
            get { return galleryinfo; }
            set { this.galleryinfo = value; }
        }
     
        public double ImageHeightRequest
        {
            get { return imageHeightRequest; }
            set
            {
                this.imageHeightRequest = value;
                this.OnPropertyChanged(nameof(ImageHeightRequest));
            }
        }

        #endregion

        public void GenerateSource()
        {
            ListViewGalleryInfoRepository bookRepository = new ListViewGalleryInfoRepository();
            galleryinfo = bookRepository.GetGalleryInfo();
        }        

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
