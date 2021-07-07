using System;
// using System.Exception;
// using System.ApplicationException;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace ProcessMultipleExpception
{
    [Serializable]
    class carIsDeadException : ApplicationException
    {
        private string messageDetails=String.Empty;
        public DateTime ErrorTimeStamp{get;set;}
public string CauseOfError{get;set;}
//Третий способ основывается на следующих характеристиках: 
// • является производным от класса Exception/ApplicationException; 
// • помечен атрибутом [System.Serializable]: 
// • определяет стандартный конструктор: 
// • определяет конструктор, который устанавливает значение унаследованного свойства Message: 
// • определяет конструктор для обработки “внутренних исключений”: 
// • определяет конструктор для поддержки сериализации типа.
public carIsDeadException(){}
public carIsDeadException(string message):base(message){}
public carIsDeadException(string message,System.Exception inner):base(message,inner){}
protected carIsDeadException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
):base(info,context){}
public carIsDeadException(string message,string cause,DateTime time):base(message){
    //Второй способ заключается в передаче сообщения базовому классу
    // messageDetails=message;
    CauseOfError=cause;
    ErrorTimeStamp=time;
    }
    // public override string Message=>$"Car Error Message: {messageDetails}";
=======

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
>>>>>>> 14cdd096fce860d8062ba954576932d0419973bc
    }



}
