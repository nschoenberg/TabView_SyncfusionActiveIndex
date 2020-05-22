using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Prism_TabView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
		private void CreateTabView()
		{
			SfTabView tabView = new SfTabView();
			var TabItems = new TabItemCollection();
			TabItems.Add(new SfTabItem() { Title = "Tab 1", Content = new Datagrid() });
			TabItems.Add(new SfTabItem() { Title = "Tab 2", Content = new TreeView() });
			TabItems.Add(new SfTabItem() { Title = "Tab 3", Content = new TabContent() });
			TabItems.Add(new SfTabItem() { Title = "Tab 4", Content = new StackLayout { BackgroundColor = Color.LightGreen } });
			TabItems.Add(new SfTabItem() { Title = "Tab 5", Content = new StackLayout { BackgroundColor = Color.LightSkyBlue } });
			tabView.Items = TabItems;
			stack.Children.Add(tabView);
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			CreateTabView();
		}
	}
}