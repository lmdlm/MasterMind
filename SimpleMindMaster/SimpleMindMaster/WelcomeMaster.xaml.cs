using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMindMaster
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomeMaster : ContentPage
	{
        // == global constants ==
        private const int NUMBER_ROW = 3;
        private const int NUMBER_COL = 3;
        
        public WelcomeMaster ()
		{
			InitializeComponent ();


            var grid = new Grid { ColumnSpacing = 150, RowSpacing = 150};

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var cell1 = new Frame { Content = new Entry { Text =""}, BorderColor = Color.Silver};
            var cell2 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver };
            var cell3 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver };
            var cell4 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver};
            var cell5 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver};
            var cell6 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver};
            var cell7 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver};
            var cell8 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver };
            var cell9 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver };
            var cell10 = new Frame { Content = new Entry { Text = "" }, BorderColor = Color.Silver };

            grid.Children.Add(cell1, 0, 0);
            grid.Children.Add(cell2, 0, 1);
            grid.Children.Add(cell3, 0, 2);
            grid.Children.Add(cell4, 1, 0);
            grid.Children.Add(cell5, 1, 1);
            grid.Children.Add(cell6, 1, 2);
            grid.Children.Add(cell7, 2, 0);
            grid.Children.Add(cell8, 2, 1);
            grid.Children.Add(cell9, 2, 2);
            grid.Children.Add(cell10, 0, 3);
            Grid.SetColumnSpan(cell10, 3);

            Content = grid;
        }
	}
}
