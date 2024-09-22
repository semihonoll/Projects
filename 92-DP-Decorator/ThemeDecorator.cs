using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92_DP_Decorator
{
    public class ThemeDecorator : WindowDecorator
    {
        public ThemeDecorator(Window targetWindow, string title) : base(targetWindow, title)
        {
        }

        public override void Render()
        {
            TargetWindow.Render();
        }

        public void SetTheme(string name)
        {
            Console.WriteLine("{0} başlıklı pencere {1} teması uygulandı", TargetWindow.Title, name);
            Render();
        }
    }
}
