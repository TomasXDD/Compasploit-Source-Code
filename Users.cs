using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compasploit
{
    class Users
    {
        public static string MainS(string user)
        {
            string t = "Tomas";
            string p = "Piza";
            string j = "Juan";
            string s = "Silva";
            if (user == t) 
            {
                 string Value = t;
                return Value;
            }
            else if(user == p)
            {
                string Value = p;
                return Value;
            }
            else if (user == s)
            {
                string Value = s;
                return Value;
            }
            else if (user == j)
            {
                string Value = j;
                return Value;
            }
            return "incorrect";
        }
    public static bool GetNames(string user)
        {
           if(Users.MainS(user) == user)
            {
                if(Users.MainS(user)=="incorrect")
                {
                    return false;
                }
                return true;
            }
           else
            {
                return false;
            }
        }
    }



}
