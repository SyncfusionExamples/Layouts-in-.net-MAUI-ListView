using System;
using System.Collections.ObjectModel;

namespace MAUI_ListView_Layouts
{
    public class ListViewGalleryInfoRepository
    {
        #region Constructor

        public ListViewGalleryInfoRepository()
        {

        }

        #endregion

        #region GetGalleryInfo

        internal ObservableCollection<ListViewGalleryInfo> GetGalleryInfo()
        {
            var galleryInfo = new ObservableCollection<ListViewGalleryInfo>();          
            for (int i = 0; i < ImageTitles.Length; i++)
            {
                var gallery = new ListViewGalleryInfo()
                {
                    Image = Images[i],
                    ImageTitle = ImageTitles[i],
                    ImageCount = ImagesCount[i],
                };
                galleryInfo.Add(gallery);
            }
            return galleryInfo;
        }

        #endregion
        #region GalleryInfo

        readonly string[] ImageTitles = new string[]
        {
            "Places",
            "Food",
            "Art",
            "Fashion",
            "Books",
            "Footwear",
            "Animals",
            "Jewelry",
            "Watches",
            "Kids",
        };
        readonly string[] ImagesCount = new string[]
        {
            "10 images",
            "15 images",
            "13 images",
            "134 images",
            "10 images",
            "20 images",
            "10 images",
            "30 images",
            "10 images",
            "50 images",
            
        };

        readonly string[] Images = new string[]
        {
            "places.png",
            "food.png",
            "art.png",
            "fashion.png",
            "books.png",
            "footware.png",
            "animals.png",
            "jewelry.png",
            "watches.png",
            "kids.png",
            
        };
        #endregion
    }
}
