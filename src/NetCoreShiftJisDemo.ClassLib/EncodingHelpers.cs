using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreShiftJisDemo.ClassLib
{
    public static class EncodingHelpers
    {
        static EncodingHelpers()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public static Encoding GetShiftJis()
        {
            return Encoding.GetEncoding("Shift-JIS");
        }
    }
}
