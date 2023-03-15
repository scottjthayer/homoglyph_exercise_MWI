using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Homoglyphs_MWI_Homework
{
    internal static class CharactersRepository
    {
        public static Dictionary<char, char> GetDictionary()
        {
            Dictionary<char, char> homoglyphsToConvert = new Dictionary<char, char>()
            {
                {'Ä' ,'A' },
                {'Å' ,'A' },
                {'Á' ,'A' },
                {'Â' ,'A' },
                {'À' ,'A' },
                {'Ã' ,'A' },
                {'â' ,'a' },
                {'ä' ,'a' },
                {'à' ,'a' },
                {'å' ,'a' },
                {'á' ,'a' },
                {'ã' ,'a' },
                {'ß' ,'B' },
                {'þ' ,'b' },
                {'Þ' ,'b' },
                {'Ç' ,'C' },
                {'ç' ,'c' },
                {'Ð' ,'D' },
                {'É' ,'E' },
                {'Ê' ,'E' },
                {'Ë' ,'E' },
                {'È' ,'E' },
                {'é' ,'e' },
                {'ê' ,'e' },
                {'ë' ,'e' },
                {'è' ,'e' },
                {'ƒ' ,'f' },
                {'Í' ,'I' },
                {'Î' ,'I' },
                {'Ï' ,'I' },
                {'ï' ,'i' },
                {'î' ,'i' },
                {'ì' ,'i' },
                {'í' ,'i' },
                {'ı' ,'i' },
                {'Ñ' ,'N' },
                {'ñ' ,'n' },
                {'Ö' ,'O' },
                {'Ó' ,'O' },
                {'Ô' ,'O' },
                {'Ò' ,'O' },
                {'Õ' ,'O' },
                {'ô' ,'o' },
                {'ö' ,'o' },
                {'ò' ,'o' },
                {'ó' ,'o' },
                {'ø' ,'o' },
                {'ð' ,'o' },
                {'õ' ,'o' },
                {'Ü' ,'U' },
                {'Ú' ,'U' },
                {'Û' ,'U' },
                {'Ù' ,'U' },
                {'ü' ,'u' },
                {'û' ,'u' },
                {'ù' ,'u' },
                {'ú' ,'u' },
                {'µ' ,'u' },
                {'Ý' ,'y' },
                {'ÿ' ,'y' },
                {'ý' ,'y' },
                {'Ø' ,'0' },
            };
            return homoglyphsToConvert;
        }

    }
}
