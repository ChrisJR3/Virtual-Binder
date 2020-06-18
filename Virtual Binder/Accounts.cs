using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Binder
{

    class Accounts
    {
        public string username, email, password, class1, class2, class3, class4, class5;
        public int classNumber;

        public Accounts(string _username, string _email, string _password, int _classNumber, string _class1, string _class2, string _class3, string _class4, string _class5)
        {
            username = _username;
            email = _email;
            password = _password;
            classNumber = _classNumber;
            class1 = _class1;
            class2 = _class2;
            class3 = _class3;
            class4 = _class4;
            class5 = _class5;
        }
    }
}
