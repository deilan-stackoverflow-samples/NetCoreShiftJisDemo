using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreShiftJisDemo.ClassLib;

namespace NetCoreShiftJisDemo.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var encoding = EncodingHelpers.GetShiftJis();
        }
    }
}
