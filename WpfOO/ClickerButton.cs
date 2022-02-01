using System.Windows.Controls;
using System.Windows.Media;

namespace WpfOO
{
    internal class ClickerButton : Button
    {
        public ClickerButton()
        {
            Foreground = new SolidColorBrush(Color.FromRgb(0, 31, 32));
            Content = "Trykk her";
        }
    }
}
