using System.Windows;
using System.Windows.Controls;

namespace WpfOO
{
    internal class ClickerPanel : StackPanel
    {
        private readonly Label _label;
        private int _counter;

        public ClickerPanel() 
        {
            var textBox = new TextBox();

            var button = new ClickerButton( );
            _label = new Label { Content = "0" };

            button.Click += ButtonClick;

            Orientation = Orientation.Horizontal;
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
    }
}
