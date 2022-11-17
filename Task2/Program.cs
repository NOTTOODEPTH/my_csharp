using System;
namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать 30 переменных используя различные типы. ( Создание, инициализация, изменение значений, вывод на консоль. )
            Console.WriteLine("Создать 30 переменных используя различные типы. ( Создание, инициализация, изменение значений, вывод на консоль. )");
            bool myBool = false;
            Console.WriteLine("1) "+myBool);
            myBool = true;
            Console.WriteLine(myBool);// 1           
            sbyte mySbyte = 127;
            Console.WriteLine("2) " + mySbyte);
            mySbyte = -127;
            Console.WriteLine(mySbyte);// 2 
            short myShort = 32767;
            Console.WriteLine("3) " + myShort);
            myShort = -32767;
            Console.WriteLine(myShort);// 3 
            int myInt = -2147483647;
            Console.WriteLine("4) " + myInt);
            myInt = 2147483647;
            Console.WriteLine(myInt);// 4 
            long myLong = 999999999999999999;
            Console.WriteLine("5) " + myLong);
            myLong = -999999999999999999;
            Console.WriteLine(myLong);// 5
            byte myByte = 255;
            Console.WriteLine("6) " + myByte);
            myByte = 12;
            Console.WriteLine(myByte);// 6
            ushort myUshort = 65535;
            Console.WriteLine("7) " + myUshort);
            myUshort = 3333;
            Console.WriteLine(myUshort);// 7
            char myChar = '!';
            Console.WriteLine("8) " + myChar);
            myChar = '\u01FD';
            Console.WriteLine(myChar);// 8
            uint myUint = 444444444;
            Console.WriteLine("9) " + myUint);
            myUint = 444444;
            Console.WriteLine(myUint);// 9
            ulong myUlong = 11111111111111111111;
            Console.WriteLine("10) " + myUlong);
            myUlong = 111111;
            Console.WriteLine(myUlong);// 10
            float myFloat = 123.44f;
            Console.WriteLine("11) " + myFloat);
            myFloat = -13.4468f;
            Console.WriteLine(myFloat);// 11
            double myDouble = 123.444444444444;
            Console.WriteLine("12) " + myDouble);
            myDouble = -123.444444444444;
            Console.WriteLine(myDouble);// 12
            decimal myDecimal = 12222223.444444444444m;
            Console.WriteLine("13) " + myDecimal);
            myDecimal = -12222223.444444444444m;
            Console.WriteLine(myDecimal);// 13
            string myString = "string";
            Console.WriteLine("14) " + myString);
            myString = "New\nstring";
            Console.WriteLine(myString);// 14
            var myBoolVar = true;
            Console.WriteLine("15) " + myBoolVar);
            myBoolVar = false;
            Console.WriteLine(myBoolVar);// 15
            var mySbyteVar = -127;
            Console.WriteLine("16) " + mySbyteVar);
            mySbyteVar = 12;
            Console.WriteLine(mySbyteVar);// 16
            var myShortVar = -32000;
            Console.WriteLine("17) " + myShortVar);
            myShortVar = 3200;
            Console.WriteLine(myShortVar);// 17
            var myIntVar = -40000;
            Console.WriteLine("18) " + myIntVar);
            myIntVar = -400;
            Console.WriteLine(myIntVar);// 18
            var myLongVar = -444444444444;
            Console.WriteLine("19) " + myLongVar);
            myLongVar = 4444443334444;
            Console.WriteLine(myLongVar);// 19
            var myByteVar = 254;
            Console.WriteLine("20) " + myByteVar);
            myByteVar = 24;
            Console.WriteLine(myByteVar);// 20
            var myUshortVar = 65534;
            Console.WriteLine("21) " + myUshortVar);
            myUshortVar = 334;
            Console.WriteLine(myUshortVar);// 21
            var myCharVar = '4';
            Console.WriteLine("22) " + myCharVar);
            myCharVar = '%';
            Console.WriteLine(myCharVar);// 22
            var myUintVar = 3333333333;
            Console.WriteLine("23) " + myUintVar);
            myUintVar = 333323;
            Console.WriteLine(myUintVar);// 23
            var myUlongVar = 11111111111111111111;
            Console.WriteLine("24) " + myUlongVar);
            myUlongVar = 1;
            Console.WriteLine(myUlongVar);// 24
            var myFloatVar = 11.11f;
            Console.WriteLine("25) " + myFloatVar);
            myFloatVar = -11.11f;
            Console.WriteLine(myFloatVar);// 25
            var myDoubleVar = 11.1111d;
            Console.WriteLine("26) " + myDoubleVar);
            myDoubleVar = -11.1111d;
            Console.WriteLine(myDoubleVar);// 26
            var myDecimalVar = 11.11m;
            Console.WriteLine("27) " + myDecimalVar);
            myDecimalVar = -11.11214m;
            Console.WriteLine(myDecimalVar);// 27
            var myStringlVar = "stringVar";
            Console.WriteLine("28) " + myStringlVar);
            myStringlVar = "NewstringVar";
            Console.WriteLine(myStringlVar);// 28
            object myStringlObj = "stringObj";
            Console.WriteLine("29) " + myStringlObj);
            myStringlObj = 11;
            Console.WriteLine(myStringlObj);// 29
            object myCharObj = '\x35';
            Console.WriteLine("30) " + myCharObj);
            myCharObj = "not char";
            Console.WriteLine(myCharObj);// 30
            // Сделать вывод на консоль литералов различных видов
            Console.WriteLine("Сделать вывод на консоль литералов различных видов");
            Console.WriteLine(0b110);
            Console.WriteLine(0x110fd);
            Console.WriteLine(true);
            Console.WriteLine(-11213);
            Console.WriteLine('\u002b'); // +
            Console.WriteLine('\x3d'); // =
            Console.WriteLine(11.213);
            Console.WriteLine(11.2e213);
            Console.WriteLine('f');
            Console.WriteLine("literal");
            Console.WriteLine("hello\nPavel");
            Console.WriteLine("This movie is called \"The Thing\".");
            // Создать 5 констант.
            Console.WriteLine("Создать 5 констант.");
            const bool myConstBool = true;
            const int myConstInt = 3333;
            const char myConstChar = '0';
            const float myConstFloat = 3.333f;
            const string myConstString = "constString";
            Console.WriteLine(myConstBool + "\n" + myConstInt + "\n" + myConstChar + "\n" + myConstFloat + "\n" + myConstString);
        }

    }
}