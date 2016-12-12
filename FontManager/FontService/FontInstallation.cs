using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FontManager.FontService
{
    public class FontInstallation
    {
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceW", SetLastError = true)]
        public static extern int RemoveFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                            string lpFileName);
    }
}
