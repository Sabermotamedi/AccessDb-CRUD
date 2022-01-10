using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class GeneralEnum
    {
        public enum Msg
        {
            FailedLogin = 0,
            SuccesLogin = 1,
           FailedBackUp = 2,
            SuccesBackUp =3,
            DeleteAlert =4,
            SuccesInsertDataBase = 5,
            FailedInsertDatabase = 6
        }

        public enum Caption
        {
            DeleteAlert = 4
        }
        public enum Button
        {
            DeleteAlert = 4
        }
    }
}
