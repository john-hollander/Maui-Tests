using System.ComponentModel;

namespace CollectionViewTest
{
    public class RowItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        private Brush _background = Brush.Yellow;
        private string _text = string.Empty;

        public string Text
        {
            get => _text; 
            set
            {
                if (_text != value)
                {
                    _text = value;
                    RaisePropertyChanged(nameof(Text));
                }
            }
        }

        public Brush Background
        {
            get => _background;
            set
            {
                if (_background != value)
                {
                    _background = value;
                    RaisePropertyChanged(nameof(Background));
                }
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
