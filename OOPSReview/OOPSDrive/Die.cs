﻿using System;
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

        //within a property you can validate that
        //the incoming data value is "what is expected"
        private string _Color;
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                //sample validation
                //there MUST be data within the incoming value
                //so an empty string is invalid
                if(string.IsNullOrEmpty(value))
                //if (value == null) will inclue " "
                //if (value ==" ") will have null
                {
                    //incoming data value is incorrect
                    // a) you could send a error message to the outside user
                    //throw new Exception("Color must have a value");
                     
                    //OR 
                    // b) you could allow the storage of a null value
                    //    within the string data member
                    _Color = null;
                }
                else
                {
                    _Color = value;
                }
            }
        }

    }
}
