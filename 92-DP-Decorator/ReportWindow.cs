using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92_DP_Decorator
{
    public class ReportWindow : Window
    {
        public ReportWindow()
        {
            
        }
        public ReportWindow(string title) : base(title)
        {
            
        }
        public override void Render()
        {
            Console.WriteLine("{0} Başlıklı rapor ekranı render edildi.", title);
        }
    }
}
