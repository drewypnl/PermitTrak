using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PermitTrak
{
    //Public variable class
    internal static class clsGlobal
    {
        public static string userName;
        public static string password;
        public static string configFileName;
        public static int SectionReached;
        public static string PermitType;
        public static string disLevel;
    }

    //Public MDI class to reference contrals on MDI form
    public class refPermitTrakMDI
    {
        public static frmPermitTrakParent mdi;
    }
}
