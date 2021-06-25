using System;
// using System.Exception;
// using System.ApplicationException;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptoin
{
    class carIsDeadException : ApplicationException
    {
        private string messageDetails=String.Empty;
        public DateTime ErrorTimeStamp{get;set;}
public string CauseOfError{get;set;}
public carIsDeadException(){}
public carIsDeadException(string message,string cause,DateTime time):base(message){
    // messageDetails=message;
    CauseOfError=cause;
    ErrorTimeStamp=time;
    }
    // public override string Message=>$"Car Error Message: {messageDetails}";
    }




}
