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
    public class ñarlsDeadException : ApplicationException
    {
        public ñarlsDeadException() { }
        public ñarlsDeadException(string message,string cause,DateTime dateTime):base(message) {
            ErrorTimeStamp = dateTime;
            CauseOfError = cause;
        }
        public ñarlsDeadException(string message) : base(message) { }
        public ñarlsDeadException(string message, System.Exception inner)
: base(message, inner) { }
        protected ñarlsDeadException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
        // Ëşáûå äîïîëíèòåëüíûå ñïåöèàëüíûå ñâîéñòâà, êîíñòğóêòîğû è ÷ëåíû äàííûõ...
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
    }



}
