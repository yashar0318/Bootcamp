﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesabla()
        {
            Console.WriteLine("Ihtiyac kredisi odeme plani hesablandi");
        }
    }
}
