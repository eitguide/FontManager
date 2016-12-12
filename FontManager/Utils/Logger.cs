using FontManager.Model;
using SharpFont;
using SharpFont.TrueType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontManager.Utils
{
    public class Logger
    {
        public static void FontInfomation(FontInfo info)
        {
            Console.WriteLine("###Font Info###");

            Console.WriteLine("CopyRight: " + info.Copyright == null ? "" : info.Copyright);
            Console.WriteLine("FontFamily: " + info.FontFamily == null ? "" :info.FontFamily);
            Console.WriteLine("FontSubFamily: " + info.FontSubFamily == null ? "" : info.FontSubFamily);
            Console.WriteLine("UniqueId: " + info.UniqueId == null ? "" : info.UniqueId);
            Console.WriteLine("FullName: "+ info.FullName == null ? "" : info.FullName);
            Console.WriteLine("Version: " + info.Version == null ? "" : info.Version);
            Console.WriteLine("PostscriptName: " + info.PostscriptName == null ? "" : info.PostscriptName);
            Console.WriteLine("TradeMark: " + info.TradeMark == null ? "" : info.TradeMark);

            Console.WriteLine("Manufacturer: " + info.Manufacturer == null ? "" : info.Manufacturer);
            Console.WriteLine("Designer: " + info.Designer == null ? "" : info.Designer);
            Console.WriteLine("Description: " + info.Description == null ? "" : info.Description);
            Console.WriteLine("Vender URL: " + info.VendorURL == null ? "" : info.VendorURL);
            Console.WriteLine("Designer URL: " + info.DesignerURL == null ? "" : info.DesignerURL);
            Console.WriteLine("License: " + info.License == null ? "" : info.License);

            Console.WriteLine("Preperred Family: " + info.PreferredFamily == null ? "" : info.PreferredFamily);
            Console.WriteLine("Preperred SubFamily: " + info.PreferredSubFamily == null ? "" : info.PreferredSubFamily);
            Console.WriteLine("Mac FullName: " + info.MacFullName == null ? "" : info.MacFullName);
        }


        public static void CodeIdsFont(Face face)
        {
            int count = (int)face.GetSfntNameCount();
            for (int i = 0; i < count; i++)
            {
                SfntName sfnt = face.GetSfntName((uint)i);
                d("Platform: " + sfnt.PlatformId + ", Encoding ID: " + sfnt.EncodingId + "Language Id:  " + sfnt.LanguageId + ", NameId: " + sfnt.NameId);
            }
        }

        public static void d(String str)
        {
            Console.WriteLine(str);
        }
    }
}
