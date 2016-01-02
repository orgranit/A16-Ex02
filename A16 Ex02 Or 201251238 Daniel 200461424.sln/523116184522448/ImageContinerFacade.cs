using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _EventFullyApp
{
    public class ImageContinerFacade
    {

        public ImageList ImageList { get; set; }
        public ListView ListView { get; set; }

        internal void ImagesAdd(Image i_Image)
        {
            ImageList.Images.Add(i_Image);
        }

        internal void InvokeImagesAdd(Image i_Image, string i_SelectedEventPhotosName, int i_ImageIndex)
        {
            ListView.Invoke(new Action(()=> ImageList.Images.Add(i_Image)));
            ListView.Invoke(new Action(() => ListView.Items.Add(i_SelectedEventPhotosName, i_ImageIndex)));
        }

        internal void ImagesClear()
        {
            ImageList.Images.Clear();
            ListView.Items.Clear();
        }

        internal int SelectedItemChanged()
        {
            int selectedIndex = -1;
            if (ListView.SelectedItems.Count > 0)
            {
                selectedIndex = ListView.SelectedItems[0].ImageIndex;
            }

            return selectedIndex;
        }
    }
}
