using System.Collections.ObjectModel;

namespace CollectionViewTest
{
    public partial class MainPage : ContentPage
    {
        private readonly List<RowItem> _rowItems =
        [
            new() {Background = Brush.Green, Text = "Row Number 1" },
            new() {Background = Brush.Green, Text = "Row Number 2" },
            new() {Background = Brush.Red, Text = "Row Number 3" },
            new() {Background = Brush.Red, Text = "Row Number 4" },
            new() {Background = Brush.Green, Text = "Row Number 5" },
            new() {Background = Brush.Green, Text = "Row Number 6" },
            new() {Background = Brush.Red, Text = "Row Number 7" },
            new() {Background = Brush.Red, Text = "Row Number 8" },
            new() {Background = Brush.Green, Text = "Row Number 9" },
            new() {Background = Brush.Green, Text = "Row Number 10" },
        ];

        internal ObservableCollection<RowItem> ListItems { get; } = [];

        public MainPage()
        {
            InitializeComponent();

            // Can't do with BindingContext because of nesting.
            testList.ItemsSource = ListItems;
        }

        private void HandleTestClicked(object sender, EventArgs e)
        {
            ListItems.Clear();

            for (int index = 0; index < _rowItems.Count;  index++)
                ListItems.Add(_rowItems[index]);
        }
    }
}
