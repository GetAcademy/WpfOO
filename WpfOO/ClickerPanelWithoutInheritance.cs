using System.Windows;
using System.Windows.Controls;

namespace WpfOO
{
    internal class ClickerPanelWithoutInheritance
    {
        private readonly Label _label;
        private int _counter;
        public StackPanel Panel { get; }

        public ClickerPanelWithoutInheritance()
        {

            var button = new Button { Content = "Trykk her" };
            _label = new Label { Content = "0" };

            button.Click += ButtonClick;

            Panel = new StackPanel{Orientation = Orientation.Horizontal};
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
    }
}
