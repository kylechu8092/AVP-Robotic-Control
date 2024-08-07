using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticControl
{
    public static class RobotCommands
    {
        public static string moveUp = "GOTO Z UP\r\n";

        public static string moveDown = "GOTO Z DN\r\n";

        public static string extend = "GOTO R EX\r\n";

        public static string retract = "GOTO R RE\r\n";

        public static string home = "HOME ALL\r\n";

        public static string contact = "HLLO\r\n";

        public static string moveTo = "GOTO N \r\n";
    }
}
