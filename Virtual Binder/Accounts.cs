﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Binder
{

    class Accounts
    {
        public string username, email, password, class1, class2, class3, class4, class5;
        public int newClass1Average, newClass2Average, newClass3Average, newClass4Average, newClass5Average;

        public Accounts(string _username, string _email, string _password, string _class1, string _class2, string _class3, string _class4, string _class5, int _newClass1Average, int _newClass2Average, int _newClass3Average, int _newClass4Average, int _newClass5Average)
        {
            username = _username;
            email = _email;
            password = _password;
            class1 = _class1;
            class2 = _class2;
            class3 = _class3;
            class4 = _class4;
            class5 = _class5;

            newClass1Average = _newClass1Average;
            newClass2Average = _newClass2Average;
            newClass3Average = _newClass3Average;
            newClass4Average = _newClass4Average;
            newClass5Average = _newClass5Average;
        }
    }
}
