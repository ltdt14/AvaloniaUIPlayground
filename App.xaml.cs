using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaUIPlayground
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}