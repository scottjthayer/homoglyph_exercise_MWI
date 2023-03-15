using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
namespace Fix_Homoglyphs_MWI_Homework
{
    internal class Program
    {

       
        [STAThread]
        static void Main(string[] args)
        {
            ConversionService.RunConversion();
        }

    }
}