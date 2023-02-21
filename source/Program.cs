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
            var proc = new ManagedProcess("HITMAN3", scan: true);
            proc.WriteNops(BASE + 0x0136D6A1, 6);
        }
    }
}
