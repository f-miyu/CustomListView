using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomListView.Controls
{
    public class CustomListView : ListView
    {
        public CustomListView() : base()
        {
        }

        public CustomListView(ListViewCachingStrategy cachingStrategy) : base(cachingStrategy)
        {
        }
    }
}
