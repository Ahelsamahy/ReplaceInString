using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceString
{
    [Serializable]
    public class myIllegalParamException : Exception
    {
        //for the word exception
        public myIllegalParamException()
            : base("the word is null, please try again with differnet one")
        {
        }

    }


    [Serializable]
    public class myNegativeParamException : Exception
    {
        //for the occurrence exception
        public myNegativeParamException()
    : base("the number of occurrence is less than zero, please try again with differnet one")
        {
        }
    }
}
