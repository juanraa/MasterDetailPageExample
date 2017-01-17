using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailPageExample
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();

            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "HomePage",
                IconSource = "Icon.png",
                TargetType = typeof(HomePage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "CSSPage",
                IconSource = "ic_action_css.png",
                TargetType = typeof(CSSPage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "JavascriptPage",
                IconSource = "ic_action_javascript.png",
                TargetType = typeof(JavascriptPage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "HtmlPage",
                IconSource = "ic_action_html.png",
                TargetType = typeof(HtmlPage)
            });

            listView.ItemsSource = masterPageItem;
        }
    }
}
