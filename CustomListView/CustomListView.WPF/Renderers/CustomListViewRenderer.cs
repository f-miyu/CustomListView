using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: ExportRenderer(typeof(CustomListView.Controls.CustomListView), typeof(CustomListView.WPF.Renderers.CustomListViewRenderer))]
namespace CustomListView.WPF.Renderers
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override void UpdateWidth()
        {
            base.UpdateWidth();

            if (Control != null && Control.ItemsSource != null)
            {
                foreach (var item in Control.ItemsSource)
                {
                    if (item is ViewCell viewCell)
                    {
                        var element = Platform.GetRenderer(viewCell.View)?.GetNativeElement();
                        if (element != null)
                        {
                            element.Width = Control.Width - 36;
                        }
                    }
                }
            }
        }
    }
}
