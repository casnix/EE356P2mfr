using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE356P2mfr
{
    // This is a class
    // It's reaaaally hard to make a class
    // But this class is special too.
    // It's metamorphic in the same sense of as sophisticated malware.
    // The purpose of this class is a personal experiment to learn how this can be applied.
    // When user code interacts with this class, it appears to just hold a string.
    // Behind the scene, everytime the string is read or written, this class creates a "puzzle" to store
    // in memory that can be solved to generate the stored string.  After the initial creation of the string,
    // the metamorphic engine rewrites the operations that, when executed, create the string of ascii bytes.
    // --
    // There are three main parts to this class:
    //      1) There is a VERY rudimentary virtual machine which can perform elementary arithmetic
    //      2) There is the metamorphic byte code generator that is itself metamorphic so each string
    //          has its own unique metamorphic engine
    //      3) Access and construction generation that is simply the C# source code.
    // A look to the future
    //      If possible, I want to figure out a way to make the CIL bytecode of one of these projects
    //      to be metamorphic for the entire executable.  We will see if I have time for that though, because
    //      I'll have to not just figure out CIL bytecode formats, but I'll have to figure out the structure
    //      of the .EXE archive for .NET, what must be uniform, etc.  A good exercise in wasting my time however.
    class RienzoMetamorphicString
    {
        
        //-- VMExecute(string) -- Execute the passed string
        //-- args: Accepts a string of bytes -- Either this object's metamorphic engine, or the string cdata
        //rr rets: Returns an ascii string
        public string VMExecute(string code)
        {
            return null;
        }

        //-- GenMetamorphicEngine(void) -- Generates the metamorphic engine for this particular instance
        //-- args: None
        //rr rets: None (but does access private variables)
        public void GenMetamorphicEngine()
        {
            // Use random numbers to decide this first generate of replacement pairs
            // Us an array with offsets, so you can do {"XOR":"
            // Ex:
            //      org $eDATA :offsets_marked
            //          as %0       cbyte   XOR
        }

        //-- GenStringCDATA(string) -- Generates the initial byte code that results in the passed ascii string
        //-- args: Accepts a string of bytes (presumed to be ascii chars)
        //rr rets: None (but does access private variables)
        public void GenStringCDATA(string original)
        {
            // Use random numbers to decide which operations to use to generate (add 1, sub 1, xor 0xFF, and 0xFF, etc)

        }
    }
}
