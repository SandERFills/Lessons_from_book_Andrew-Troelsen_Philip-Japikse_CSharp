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
    [Serializable]
    public class �arlsDeadException : ApplicationException
    {
        public �arlsDeadException() { }
        public �arlsDeadException(string message,string cause,DateTime dateTime):base(message) {
            ErrorTimeStamp = dateTime;
            CauseOfError = cause;
        }
        public �arlsDeadException(string message) : base(message) { }
        public �arlsDeadException(string message, System.Exception inner)
: base(message, inner) { }
        protected �arlsDeadException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
        // ����� �������������� ����������� ��������, ������������ � ����� ������...
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
    }



}
