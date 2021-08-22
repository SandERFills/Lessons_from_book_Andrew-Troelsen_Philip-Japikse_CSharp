using System;

namespace SimpleFinalize
{
    class MyResourceWrapper
    {
        object[] objMass = { "SDAD", "SDAD", "SDAD", "SDAD", "SDAD", "SDAD", "SDAD", "SDAD", "SDAD" };
        
        ~MyResourceWrapper()=>Console.Beep();
    }
}