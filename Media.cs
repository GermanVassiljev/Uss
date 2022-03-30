/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss_1
{
    public class Media
    {
        private string resourcesFoler;
        public Media()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal); // Получаем индекс папки bin
            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                .ToString();
            resourcesFoler = binFolder + "resources\\"; // путь к указанной папке
        }
        public string GetResourceFolder()
        {
            return resourcesFoler;
        }
    }
}*/