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
        public WelcomeMaster()
        {
            InitializeComponent();




            var orangeButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#E8AD00") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.White },
                    new Setter { Property = Button.BorderRadiusProperty, Value = 50 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }
                }
            };



            var grid = new Grid { ColumnSpacing = 150, RowSpacing = 150 };

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var cell1 = new Button { Text = "'='", BackgroundColor = Color.White };
            cell1.Clicked += (object sender, EventArgs e) =>
                {
                    DisplayAlert("Alert", "You have been alerted", "OK");
                };
            var cell2 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell3 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell4 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell5 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell6 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell7 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell8 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell9 = new Button { Text = "'='", BackgroundColor = Color.White };
            var cell10 = new Button { Text = "CHECK", Style = orangeButton };
            cell10.Clicked += (object sender, EventArgs e) =>
            {
                DisplayAlert("Alert", "You have been alerted", "OK");
            };



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
