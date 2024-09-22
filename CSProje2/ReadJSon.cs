using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProje2
{
    public class ReadJSon
    {
        public static List<PersonDTO> Read(string path)
        { 
            if (!File.Exists(path)) 
                throw new Exception("Dosya adresi yanlış!");

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<PersonDTO>>(json);
        }
    }
}
