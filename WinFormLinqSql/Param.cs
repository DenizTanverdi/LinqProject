using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLinq
{
    public static class Param
    {
        private static string username;

        private static string Username
        {
            get { return username; }
            set { username = value; }
        }

        private static int userId;

        private static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }



    }
}
