using System.Collections.ObjectModel;

namespace ListViewInsertTest
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> TestItems { get; } = [];

        public MainPage()
        {
            InitializeComponent();
            view.ItemsSource = TestItems;
        }

        private void AddClicked(object sender, EventArgs e)
        {
            TestItems.Add("Test 1");
            TestItems.Insert(1, "Test 3");
            TestItems.Insert(1, "Test 2");
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            if (TestItems.Count > 1)
                TestItems.RemoveAt(1);
            else if (TestItems.Count > 0)
                TestItems.RemoveAt(0);
        }
    }
}
