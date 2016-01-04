using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _523116184522448
{
    public class ImageContainerFacade
    {
        public ImageList ImageList { get; set; }

        public ListView ListView { get; set; }

        private void imagesAdd(Image i_Image, string i_ImageName, int i_ImageIndex)
        {
            ImageList.Images.Add(i_Image);
            ListView.Items.Add(i_ImageName, i_ImageIndex);
        }

        internal void ImagesClear()
        {
            ImageList.Images.Clear();
            ListView.Items.Clear();
        }

        internal void InvokeImagesAdd(Image i_Image, string i_ImageName, int i_ImageIndex)
        {
            ListView.Invoke(new Action(() => imagesAdd(i_Image, i_ImageName, i_ImageIndex)));
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
