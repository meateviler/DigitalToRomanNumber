using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalNumbetConverToRomanNumber
{
    public class DigitalToRomanConvert
    {
        private readonly Dictionary<int, string> _mapping = new Dictionary<int, string>
        {
            {1, "I"},
            {4,"IV" },
            {5,"V" },
            {9,"IX" },
            {10,"X" },
            {40,"XL" },
            {50,"L" },
            {90,"XC" },
            {100,"C" },
            {400,"CD" },
            {500,"D" },
            {900,"CM" },
            {1000,"M" },
        };

        public string Convert(int num)
        {
            int remain = num;
            StringBuilder result = new StringBuilder();
            var list = _mapping.Select(x => x.Key).OrderByDescending(x => x);
            foreach (var item in list)
            {
                remain = GetRemain(remain, item, result);
            }
            return result.ToString();
        }

        private int GetRemain(int remain, int value, StringBuilder result)
        {
            while (remain >= value)
            {
                result.Append(_mapping[value]);
                remain -= value;
            }
            return remain;
        }
    }
}