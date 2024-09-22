using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92_DP_Decorator
{
    //Sayfa özelliklerini taşıyan soyut bir base sınıf inşa ediyoruz.
    public abstract class Window
    {
		protected string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

        protected Window()
        {
           
        }

        protected Window(string title)
        {
            this.title = title;
        }

        public abstract void Render();
    }
}
