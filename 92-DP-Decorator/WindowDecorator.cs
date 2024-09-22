using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92_DP_Decorator
{
    public abstract class WindowDecorator : Window
    {
		private Window targetWindow;

		public Window TargetWindow
		{
			get { return targetWindow; }
			set { targetWindow = value; }
		}

        protected WindowDecorator(Window targetWindow, string title)
        {
            this.targetWindow = targetWindow;
            this.targetWindow.Title = title;
        }
    }
}
