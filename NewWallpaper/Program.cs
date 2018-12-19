using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewWallpaper
{
    class Program
    {

        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam,
            string pvParam, uint fWinIni);

        public static string Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}";

        static Random random = new Random();

        static int Numbers()
        {
            int number = random.Next(1, 500);
            return number;
        }

        static void Main(string[] args)
        {
            SystemParametersInfo(0x0014, 0, $@"{Path}\desktop\wallpapers\{Numbers()}.jpg", 0x0001);
        }
    }
}
