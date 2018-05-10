using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDrive
{
    //Classes by default have access privilege of private
    //you MUST add public to your classes

    public class Die
    {
        //create a new instance of the math object Random
        //this will be shared by each instance of Die
        //the instance of Random object will be created when
        //the first instance of Die is created
        private static Random _rnd = new Random();

        //class have three basic things
        // a)data members
        // b)properties
        // c)constructors
        // d)behaviours (methods)

        //data members may be private for the class for use only
        //      winthin the class

        //the interface with a class is done via properties and behaviours 

        //properties
        //can be fully implemented
        //      -a private data member
        //      -a public property
        private int _Sides;
        public int Sides
        {
            get
            {
                //this will return the private data member
                return _Sides;
            }
            set
            {

                //the reseverd key word "value " is used to 
                //obtain the incoming data value to your private
                // data member
                _Sides = value;
            }
        }

        //can be auto implemented
        //does not have a private data member
        //the system creates an internal data storage member
        //  for the property
        public int FaceValue{ get; set; }

    }
}
