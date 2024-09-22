using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91_DP_Adapter
{
    public class Adapter
    {
        private Adapte adapte;
        public Adapter()
        {
            adapte = new Adapte();
        }

        public void Message(string title, string text, Buttons button)
        {
            adapte.Alert(title, text, button);
        }
    }
}
