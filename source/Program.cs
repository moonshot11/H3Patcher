using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3Patcher
{
    public class Program
    {
        public static void Main()
        {
            const long BASE = 0x140000000;
            const long ADDR = BASE + 0x136E383;
            var proc = new ManagedProcess("HITMAN3", scan: true);
            System.Threading.Thread.Sleep(1000);
            //proc.WriteNops(ADDR, 6);
            proc.Write(ADDR, new byte[] { 0xE9, 0x8E, 0x00, 0x00, 0x00, 0x00 });
        }
    }
}
