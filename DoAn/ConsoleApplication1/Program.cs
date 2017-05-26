using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }
        public static string auto()
        {
            NganHangEntities ctx = new NganHangEntities();

            var count = ctx.SoTietKiems.Count();
            var temp = (from c in ctx.SoTietKiems orderby c.MaSoTietKiem descending select c).First().MaSoTietKiem;
            var temp3 = "null";
            while (ctx.SoTietKiems.Any(o => o.MaSoTietKiem == temp3) && temp3.CompareTo("null") == 0)
            {
                var temp2 =int.Parse(temp.Trim().Remove(0,3));
                temp2 += 1;
                temp3 = "STK" + temp2.ToString();
            }            
            return temp3;
        }
        public static void test()
        {
            var a = "null";
            if (a.CompareTo("null") == 0)
                Console.WriteLine("bang");
        }
    }
}
