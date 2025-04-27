namespace All_CSharp_Basics
{
    /* 
       ************************* Inside nameSpace *****************************
            * Value Types
                   * Struct 
                   * Enum
            * Referenece Types
                   *Class
                   *Interface
       */

    internal class Program
    {
        /* 
        ******** Inside Class **********
                * Functions [Methods]
                * Data
        */



        /*  Notes For Studing Throw This File 
            * unComment Each Regeion and Read it then Excute to Test Your Thouaght
            * There is Comments Of Each Line To Show The Uses 
            * The Hashed Line After UnComment Mean => this is wrong way or not optimized 
            *
         */


        #region Functions Def and Types

        // Function => Block Of Code

        /* 
            ****************** Function ************
                * Prototype (Signuture[Return type - Name - Parameters] - Body)
                * Calling (Name - Arguments)
        */

        // Types Of Functions 
        // 1. Object Member Function => calling by object of specific class
        // 2. Class Member Function => calling By the name of the class


        #endregion

        #region Create Functions

        //public static void Print()
        //{ 
        //   for (int i = 0; i < 10; i++) 
        //        Console.Write("*"); 
        //}

        // =======================================

        //public static void PrintWithPatternGiven(char pattern)
        //{
        //    for (int i = 0; i < 10; i++)
        //        Console.Write(pattern);
        //}

        //// Function Overloading 

        //public static void PrintWithPatternGiven(char pattern = '#', int count = 10)
        //{
        //    for (int i = 0; i < count; i++)
        //        Console.Write(pattern);
        //}

        // ===================================================

        //public static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //===================================================

        //public static void Swap2(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //======================================================

        //public static int SumArray(int[] Array)
        //{
        //    int Sum = 0;
        //    Array[0] = 100;
        //    for (int i = 0; i < Array?.Length; i++)                    
        //        Sum += Array[i];

        //    return Sum;
        //}

        // ======================================================

        //public static int SumArrrayRef(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //}

        // ========================================================

        //public static void SumMul(int x, int y, out int sum, out int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}

        // ========================================================
        //public static void SumMulRef(int x, int y, ref int sum, ref int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}

        // =======================================================


        // Params Parameter must be the last parameter
        //public static int SumArr(params int[] Arr) // May Be elements Instead of Arr
        //{
        //    int sum = 0;
        //    foreach (int i in Arr) 
        //        sum += i; 

        //    return sum;

        //}

        #endregion

        /// <main_method>
        /// Entry Point  => ClR Excute this method first
        /// </main>
        static void Main()
        {
            #region Naming Conventions 

            // 1. PascalCase => AhmedRefat [C#]
            // 2. camalCase => ahmedRefat  [JavaScript]
            // 3. Kapap-Case => Kapap-Case [HTML, CSS, AngularComponents]
            // 4. Snake_Case => Ahmed_Refat [C++, Python]


            //------------ C# Naming Conventions---------------

            // 1. PascalCase => ClassNames, MethodNames, PropertyNames, Namespaces, Events, Enums, ConstantNames, 

            // 2. camalCase => localVariables, privateAttributes, functionParameters

            #endregion

            #region Errors
            // Errors
            // 1. Syntax Error [Complilation Time]
            // 2. Logical Error [Not be Shown]
            // 3. RunTime Erorr 
            // 4. Warinning 
            #endregion

            #region Declaring Variables 

            //int x = 10;
            //x = 20;
            //Console.WriteLine(x); // 20
            //Console.WriteLine(x.GetHashCode()); // Get Address At Memory

            #endregion

            #region Data Types in .NET
            // Data Types in .Net
            // 1. Value Type  [struct, Enum]  ==> its size known at compilation time [stored at stack]
            // 2. Referenece Type [Class, Interface] ==> size not known [data stored at heap, and its reference at stack]

            #endregion

            #region Data Types 

            #region CTS & CLS

            // 1. CTS => Common Type System 
            // Container Of All datatypes at DotNet
            // have Component Called [CLS]

            // 2. CLS => Common Language Specifications 
            // Common DataTypes Between All Languages 
            // We Can Code C# & F# and So on At the Same File Because They have CLS

            #endregion

            // DataTypes in .NET Divided into 2 Categories : ValueTypes & ReferenceTypes

            #region ValueTypes & ReferenceTypes

            // 1. Value Types (Primitive DataTypes) 
            // Size is Determined
            // Stored At Stack [LIFO]
            // Examples : Struct [Built In => INT, Double,....], Enum

            // 2. Reference Types 
            // Size not Determined 
            // Stored At Heap
            // Examples : Class [Built in => Object, String, Array, Delegate], Interface


            #region Built In Value Types [Struct]

            /*  Numeric DataTypes and its Size Allocations 
                   *  byte, sbyte [1 Byte] => sbyte : Signed + - 
                   *  short, ushort [2 Byte]
                   *  int, uint [4 Byte]
                   *  long, ulong [8 Byte]
            */


            /*  Fraction DataTypes and its Size Allocations 
                 *  float [4 Byte] 
                 *  double [8 Byte]
                 *  decimal [16 Byte]
             */


            /*  Othor DataTypes and its Size Allocations 
                 *  char [2 Byte] 
                 *  bool [1 Byte]
                 *  Date Time [8 Byte]
                 *  DateOnly DotNet 6.0
                 *  TimeOnly  DoteNet 6.0
             */

            #endregion



            #endregion

            #region String As A Refernce Type

            //string S = "Ahmed"; // 10 Byte
            //S = "Ali"; // 6 Byte

            // Refernce Address At Stack 
            // Object At Heap 

            #endregion

            #region BCL DataTypes [OLD] still Work

            // Int16, Int32, Int64, Double, Decimal, Byte .....and so on 
            // Inside struct itself these Names Exist not [C# Names]

            #endregion

            #endregion

            #region Object DataType

            /// Every Data Type inherit From Object DataType
            /// To inherit Set of Common Functions [ToString(), GetHashCode(), Equals(object), GetType()]
            /// Apply Generic Concept wich appear after 2005
            /// from 2002 to 2005 there is object dataType

            //object O1;
            ////O1 = "Ahmed";
            ////O1 = 1;
            ////O1 = new Point();

            //O1 = new object();
            //object O2 = new object();
            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());
            //O2 = O1;
            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode()); // The Same HashCode Of 1 

            #endregion

            #region Object Vs Generic [Interview Question]
            // Object => 1. is a datatype work as generic concept
            // 2002 : 2005 => Generic concept is not exist in .Net, So they were use [Object]

            // 2. Set Of Behaviours (Functions) should be existed at any data type
            // 2.1 : ToString() => convert evry thing to string
            // 2.2 : GetHashCode() => get the address in the memory
            // 2.3 : Equals(Object) => Compare two objects
            // 2.4 : GetType() => Get Type of Object

            // 1. Generic 
            //public static void Print <T> (T item)
            //{
            //    Console.WriteLine (item);
            //} 
            #endregion

            #region Fractions && Discards

            //// Default Data Type Of Fraction is => Double
            //double X = 11222222222.12122121212;
            //float Y = 2.2f;
            //decimal Z = 2.2m;

            //// Discard
            //int Num1 = 20;
            //long Num2 = 1_000_000;
            //Console.WriteLine(Num2);

            #endregion

            #region Value Type Casting

            // 1. Implicit Casting [Safe]
            // 2. Explicit Casting [UnSafe]
            // 3. Parse [string -> AnyDataType]
            // 4. Convert [DataType -> DaataType]

            #region Implicit Casting & Explicit Casting 
            //int X = 5;
            //long Y = X; // => Implicit Casting : Safe Casting 

            //checked // to throw exception if can not casting [System.OverflowException]
            //{
            //    long Num1 = 12345678911;
            //    int Num2 = (int)Num1;   // Explicit Casting => Unsafe Casting
            //    Console.WriteLine(Num1);
            //    Console.WriteLine(Num2);
            //}

            //int X = 88;
            //double Y = X; // Implicit Casting : Safe Casting

            //double Num1 = 12234.2;
            //int Num2 = (int)Num1;  // Explicit Casting : UnSafe Casting
            //Console.WriteLine(Num1); // 12234.2
            //Console.WriteLine(Num2); // 12234 
            #endregion

            #region Parse 

            // Parse => Cast From String To Any Data Type
            //Console.Write("Please Enter Your Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Please Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter Your Salary : ");
            //double Salary = double.Parse(Console.ReadLine());

            //Console.WriteLine("==============================");
            //Console.WriteLine("You Data is : ");
            //Console.WriteLine($"Name: {Name}, Age : {Age}, Salary : {Salary}");

            #endregion

            #region Convert Class

            //// Convert From Any Data Type To Onther

            //string falg = "false";
            //bool flag2 = Convert.ToBoolean(falg);

            //Console.WriteLine(flag2);

            //string Num = "33";
            ////Num = "ahmed"; // will throw Exception after Convert 
            //int Num2 = Convert.ToInt32(Num);
            //Console.WriteLine(Num2);

            #endregion

            #endregion

            #region Operators

            // Uncomment These 2 Variables then Excute Each Region 

            //int x = 5;
            //int y = 10;

            #region 1. Unary Operators
            //// one operand
            //// ++ , --
            //Console.WriteLine(x++); // 5
            //Console.WriteLine(x--); // 6

            //Console.WriteLine(++x); // 6
            //Console.WriteLine(--x); // 5
            #endregion

            #region 2. Binary Operators
            //// two operands 
            //// + , - , *, / , %
            //Console.WriteLine(x + y); // 15
            //Console.WriteLine(x - y); // -5
            //Console.WriteLine(x * y); // 50
            //Console.WriteLine(x / y); // 0
            //Console.WriteLine((float)x / y); // 0.5
            //Console.WriteLine(x % y); // 5
            #endregion

            #region 3. Assignment Operators
            //// = , +=, -= ,*=, /= ,%=
            //x = y; // x = 10 , y = 10

            //x += 10; // x = 10 + 10 = 20
            //Console.WriteLine(x);
            //x -= 10; // x = 20 - 10 = 10
            //Console.WriteLine(x);
            //x *= 10; // x = 10 * 10 = 100
            //Console.WriteLine(x);
            #endregion

            #region 4. Reletional Operators
            //// For Comprasion
            //// ==, != , >=, <= , > , <

            //Console.WriteLine(x > y); // false 

            //if (x > y)
            //    Console.WriteLine("X is greater than y");
            //else if (x < y)
            //    Console.WriteLine("X is less than y");
            //else if(x == y)
            //    Console.WriteLine("X is equal to y");

            //if (x != y)
            //    Console.WriteLine("x != y");
            #endregion

            #region 5. Logical Operators
            //// Logic Gates
            //// ! , && , ||

            //Console.WriteLine(!true);  // false
            //Console.WriteLine(true && false);  // false => 1 AND 0
            //Console.WriteLine(true || false);  // true => 1 OR 0
            #endregion

            #region Diffrenece Between [&& , ||] , [& , |]
            // && , || => work as short circuit : Best Performance
            // & , | => complete all conditions
            #endregion

            #region 6. Bitwise Operators
            //// | , & , ^ , << , >>

            //Console.WriteLine(true & false); // false
            //Console.WriteLine(true | false); // true

            #endregion

            #region 7. Ternary Operators
            // Conditional operator
            // = ? :

            //int num1 = 10, num2 = 5;
            //string Message;

            ////if (num1 > num2)
            ////    Message = "num1 is greater than num2";
            ////else
            ////    Message = "num1 is less than num2";

            //Message = (num1 > num2) ? "num1 is greater than num2" : "num1 is less than or equal num2";

            //Console.WriteLine(Message);

            #endregion

            #endregion

            #region Operators Periorty [Precedence] or [Assoctivity]
            //Console.WriteLine(7 + 5 * 3); // 22
            //Console.WriteLine((7 + 5) * 3); // 36


            /*
                    1. Unary Operators [PreFix]
                    2. Round Braces ()
                    3. * / %
                    4. +-
             */
            #endregion

            #region String Formatting
            //// Print => Equation : 4 + 2 = 6
            //int X = 4 ,Y = 2;

            //// 1. + concatination
            //string Message = "Equation : " + X + " + " + Y + " = " + (X + Y); 
            //Console.WriteLine(Message);
            //// Note that : Concatination by (+) not the best because creating new variable for concatenation
            //// [String Is Immutable] => Can Not Be Changed After Creation

            //// 2. Composite Formating
            // .Net 6

            //Message = string.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Message);

            //Console.WriteLine("Equation : {0} + {1} = {2}", X, Y, X + Y);

            //// 3. String InterPolation
            ///// $ : string manipulation

            //Message = $"Equation : {X} + {Y} = {X + Y:C}";
            //Console.WriteLine(Message);

            #endregion

            /// Control Statements  
            /// Change The Flow Of The Program 
            /// 1. Conditional Statements
            /// 2. Loop Statments

            #region Conditional Statements [If - Switch]

            #region Ex 01

            #region If Statment
            //Console.WriteLine("Enter Number of month Existed at First quarter ?");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //if (MonthNumber == 1)
            //    Console.WriteLine("January");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("february");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("March");
            //else 
            //    Console.WriteLine("This is not A month at frist quarter!!!");
            #endregion

            #region Switch

            //Console.WriteLine("Enter Number of month Existed at First quarter ?");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    default:
            //        Console.WriteLine("Enter A month at first quarter !!");
            //        break;
            //}


            #endregion

            // if You Condition on A Number => The Best way is switch
            // Switch => Jumb Table 

            #endregion

            #region Ex 02

            #region IF
            //Console.Write("Enter Your Name : ");
            //string Name = Console.ReadLine();

            //if (Name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed!");
            //else if (Name == "Mai")
            //    Console.WriteLine("Hello Mai");
            //else if (Name == "Ali")
            //Console.WriteLine("Hello Ali");

            #endregion

            #region Switch
            //Console.Write("Enter Your Name : ");
            //string? Name = Console.ReadLine();

            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "Mohamed":
            //        Console.WriteLine($"Hello {Name}");
            //        break;
            //    case "Mai":
            //        Console.WriteLine("Hello Mai");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("Hello Ali");
            //        break;
            //    default:
            //        Console.WriteLine("Hello unknown Man");
            //        break;
            //}

            #endregion

            #endregion

            #region Ex 03 Switch
            //int Budget = 3000;
            //switch (Budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;
            //}
            #endregion

            #endregion

            #region Loop Statments [For, Foreach]

            /// For => for read and update
            /// foreach => for read only
            /// The foreach loop works with an enumerator (via the IEnumerable or IEnumerable<T> interface), which provides a read-only view of the collection.

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //===========================================================

            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine(i);


            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (int num in Numbers)
            //    Console.WriteLine(num);


            //for (int i = 0; i < Numbers.Length; i++)
            //    Numbers[i] *= 10; // Update is Valid

            ////foreach (int num in Numbers)
            ////    Console.WriteLine(num += 1); //  Update is Invalid


            #endregion

            #region Loop Statments [While, Dowhile]

            // DoWhile : Exception Handling technique 

            //int Number;
            //bool Check;
            //do
            //{
            //    Console.WriteLine("Enter An Even Number ? ");
            //    //Number = int.Parse(Console.ReadLine());
            //    Check = int.TryParse(Console.ReadLine(), out Number);

            //}
            //while (!Check|| Number % 2 == 1);

            //Console.WriteLine($"{Number} is an even Number !!");

            //=============================================================

            //int Num = 2;
            //bool flag = true;
            //while (Num % 2 == 0)
            //{
            //    if (flag == true)
            //        Console.WriteLine("Even Number");
            //    else
            //        Console.WriteLine("This is not a number !!!! ");
            //    flag = int.TryParse(Console.ReadLine(), out Num);
            //}

            #endregion

            #region String [Reference Type] [Immutable]

            //// String Is A Reference Type But Act Like Value Type
            //// Stirng is Immutable Type

            //string Name;
            //// Declare for Reference from type [string]
            //// Referening to the defualt value of Reference Type = NULL
            //// CLR allocate 4 Bytes at Stack For The Reference
            //// CLR allocate 0 Bytes at Heap

            ////Name = "Ahmed"; // CLR allocate 10 Bytes at Heap [Syntax Sugar]
            //Name = new string("Ahmed");
            //Console.WriteLine(Name); // Ahmed
            //Console.WriteLine($"Hash Code: {Name.GetHashCode()}");

            //Name += " Refat";
            //Console.WriteLine(Name);
            //Console.WriteLine($"Hash Code: {Name.GetHashCode()}"); // New Hash Code because string is Immutable

            //Name = "Ahmed Maher";
            //Console.WriteLine(Name); // Ahmed Maher
            //Console.WriteLine($"Hash Code: {Name.GetHashCode()}"); // New Hash Code because string is Immutable

            #region How String Act as Value Type

            //string Name1 = "Ahmed"; // 10 Bytes 
            //string Name2 = "Sohila"; // 12 Bytes

            //Console.WriteLine($"Name 1 = {Name1}"); // Ahmed
            //Console.WriteLine($"Code of Name 1 = {Name1.GetHashCode()}");
            //Console.WriteLine("--------------------------------------");

            //Console.WriteLine($"Name 2 = {Name2}"); // Sohila
            //Console.WriteLine($"Code of Name 2 = {Name2.GetHashCode()}");
            //Console.WriteLine("--------------------------------------");

            //Name2 = Name1;

            //Console.WriteLine($"Name 1 = {Name1}"); // Ahmed
            //Console.WriteLine($"Code of Name 1 = {Name1.GetHashCode()}"); 

            //Console.WriteLine($"Name 2 = {Name2}"); //Ahmed
            //Console.WriteLine($"Code of Name 2 = {Name2.GetHashCode()}"); // The Same hash Code Of Name 1 because [Name2 = Name1]
            //Console.WriteLine("--------------------------------------");

            //Name1 = "Osama";

            //Console.WriteLine($"Name 1 = {Name1}"); // Osama
            //Console.WriteLine($"Code of Name 1 = {Name1.GetHashCode()}"); // new hash code 

            //Console.WriteLine($"Name 2 = {Name2}"); // Ahmed
            //Console.WriteLine($"Code of Name 2 = {Name2.GetHashCode()}");
            #endregion


            ///// Summary: String Is Immutable [Any Update lead to create new string]
            ///// String Builder Is Mutable [No Need For Creating Extra string]


            #endregion

            #region String Builder [Mutable Type] [Interview Question] 

            //// String Builder Is A Reference Type
            //// StirngBuilder is Mutable Type

            //StringBuilder Message = new StringBuilder("Tarek");
            //Console.WriteLine(Message); // Tarek
            //Console.WriteLine(Message.GetHashCode());  // X Hash Code

            //Message.Append(" Elsapagh");
            //Console.WriteLine(Message); // Tarek Elsapagh
            //Console.WriteLine(Message.GetHashCode());  // The Same Hash Code

            //Message = new StringBuilder("Ahmed Osama");
            //Console.WriteLine(Message); // Ahmed Osama
            //Console.WriteLine(Message.GetHashCode());  // New Hash Code because [new keyword]

            /// Summary : StringBuilder Is Mutable type [any Update On The Same String Does`t Require new String 

            #endregion

            #region Block Scope

            //{
            //    int x = 5;
            //}
            ////Console.WriteLine(x); // invalid


            //int y;
            //{
            //    y = 5;
            //} 

            ////Console.WriteLine(y); // Valid

            #endregion

            #region Array
            //// Array is Reference Type
            //// Array Fixed Size
            //// Array is easy to access any element by one satement
            //// Array Start with index 0
            //// Array Have Two Types
            //// One Dimential Array, Multiple Dimential Array

            //int[] Numbers;
            //// Declare a reference from Type Array int 
            //// Now This Reference is Refere To Null
            //// CLR allocate 4 Bytes at Stack for the Reference
            //// 0 Bytes Allocated At Heap

            //Numbers = new int[3]; // Allocate 12 Bytes at Heap for 3 cell of int
            //                      // Intialized By the default value of int = 0

            //Console.WriteLine($"The First Element Now : {Numbers[0]}"); // 0

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //Console.WriteLine($"The First Element Now : {Numbers[0]}"); // 1

            ////-----------------------------------------------------------------------

            //int[] Numbers2 = new int[5] { 10, 20, 30, 40, 50 };
            //int[] Numbers3 = new int[] { 10, 20, 30 };
            //int[] Numbers4 = { 10, 20, 30 };
            //Console.WriteLine($"The First Element Now in Numbers2 : {Numbers2[0]}"); // 10

            //Console.WriteLine($"The Lenght of Array Numbers2 : {Numbers2.Length}, Array Rank = {Numbers2.Rank}");

            //// Print the elements of array with Loop

            //foreach(int item in Numbers2)
            //    Console.WriteLine(item);

            //Console.WriteLine("================================================");

            //for (int i = 0; i < Numbers2.Length; i++)
            //    Console.WriteLine(Numbers2[i]);

            #endregion

            #region Shallow Copy On Array

            //// Shallow Copy : Copies references (same memory) 
            //// Changes affect both copies

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine($"Loction Of Array 1 : {Arr01.GetHashCode()}");
            //Console.WriteLine(Arr02[0]);
            //Console.WriteLine($"Loction Of Array 2 : {Arr02.GetHashCode()}"); // Diffrent Location of Arr01

            //Arr02 = Arr01;
            //// this object { 1, 2, 3 } has now two references  Arr01, Arr02

            //Console.WriteLine(Arr01[0]); // 1
            //Console.WriteLine($"Loction Of Array 1 : {Arr01.GetHashCode()}");
            //Console.WriteLine(Arr02[0]); // 1
            //Console.WriteLine($"Loction Of Array 2 : {Arr02.GetHashCode()}"); //same location Arr01

            //Arr02[0] = 10;
            //Console.WriteLine(Arr01[0]); // 10
            //Console.WriteLine(Arr02[0]); // 10


            #endregion

            #region Deep Copy Use Clone Method [Shallow Copy] at this Case Only

            //// Deep Copy take copy of data only
            //// There are 3 Wayes To Do a Deep Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 }; // Different Location 

            //// 1. Iterate On Arr01
            //Arr02 = new int[Arr01.Length];
            //for (int i = 0; i < Arr01.Length; i++)
            //    Arr02[i] = Arr01[i];  // Copy elements one by one

            //// 2. CopyTo

            //Arr01.CopyTo(Arr02, 0);

            //// 3. Clone Method [Shallow Copy] Do Deep Copy At this Case
            //// Case : Array Elements Is Value Type

            //Arr02 = (int[])Arr01.Clone(); // Explict Casting from [object] to int[]
            //// Clone : Create new Array with new address and with the same data of Array01

            //Console.WriteLine(Arr01[0]); // 1
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02[0]); // 1
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02[0] = 10;
            //Console.WriteLine(Arr01[0]); // 1
            //Console.WriteLine(Arr02[0]); // 10


            #endregion

            #region 2 Diemential Array [Rectangular]

            //int[,] StudentsMarks = new int[3, 5];
            //{ { 100, 90, 100, 90, 89},
            //{ 99, 88, 100, 70, 90}, 
            //{ 80, 75, 89, 78, 100} };

            //// new : Allocate Required Bytes at heap = (3 * 5) * 4 = 60 Bytes
            //// intialize each element by 0

            //Console.WriteLine(StudentsMarks[0, 1]); // 90
            //Console.WriteLine(StudentsMarks[1, 0]); // 99

            //StudentsMarks[0, 1] = 200;
            //StudentsMarks[1, 0] = 100;

            //Console.WriteLine(StudentsMarks[0, 1]); // 200
            //Console.WriteLine(StudentsMarks[1, 0]); // 100

            //Console.WriteLine($"Size Of array = {StudentsMarks.Length}, " +
            //    $"{StudentsMarks.Rank} Dim Array");

            //==============================================================


            //int[,] Grades = new int[2, 3];
            //bool Flag = false;

            //int Max = 0;
            //int Min = int.MaxValue;
            //for (int i = 0; i < Grades.GetLength(0); i++) // Rows = 2
            //{
            //    Console.WriteLine($"Enter Marks Of Student Number : {i + 1}");
            //    for (int j = 0; j < Grades.GetLength(1);/* j++*/) // Columns = 3
            //    {
            //        Console.Write($"Subject {j + 1} : ");
            //        //Grades[i, j] = int.Parse(Console.ReadLine());
            //        Flag = int.TryParse(Console.ReadLine(), out Grades[i, j]);

            //        //if (Flag && Grades[i, j] >= 0)
            //        //    ++j;

            //        Max = Math.Max(Max, Grades[i, j]);
            //        Min = Math.Min(Min, Grades[i, j]);


            //        j = Flag && Grades[i, j] >= 0 ? ++j : j;

            //    }
            //}

            //Console.Clear();

            //Console.WriteLine($"Max Value in this 2 Dim Array : {Max}");
            //Console.WriteLine($"Min Value in this 2 Dim Array : {Min}");

            //foreach (var item in Grades)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();

            //Console.Clear();

            //for (int i = 0; i < Grades.GetLength(0); i++) // Rows = 2
            //{
            //    Console.WriteLine($"Grades for Student Number {i + 1}");
            //    for (int j = 0; j < Grades.GetLength(1); j++) // Columns = 3
            //        Console.WriteLine($"Sub Number{j + 1} = {Grades[i, j]}");
            //}


            #endregion

            /// Protective Code : 
            /// Handling Exception Of input String or Negtive(TryParse, Do While, try Catch)

            #region Iterate on 2 Dim Array with one Loop

            //int[,] StudentsMarks = new int[3, 5]
            //{ { 100, 90, 100, 90, 89},
            //{ 99, 88, 100, 70, 90},
            //{ 80, 75, 89, 78, 100} };


            //for (int i = 0; i< StudentsMarks.Length; i++)
            //{
            //    Console.WriteLine(StudentsMarks[i / StudentsMarks.GetLength(1), i % StudentsMarks.GetLength(1)]);
            //}

            // Time Complixty = N

            #endregion

            #region 2 Dim Array Judged Array

            //// Judged Array => one Dim Array of Arrays [][]
            //// With Different Sizes

            //int[][] Numbers = new int[3][];

            //Numbers[0] = new int[3] { 1, 2, 3 };
            //Numbers[1] = new int[2] { 10, 20 };
            //Numbers[2] = new int[1] { 100 };

            //// Print
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"---- array {i + 1}------");
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //        Console.WriteLine(Numbers[i][j]);
            //}
            #endregion

            #region Array Functions

            //// 1. Static Function [class member function] => called by its class
            //// 2. Object Member function => called by its object of class

            //int[] Numbers = new int[] { 5, 7, 1, 3, 2, 9, 4, 6, 8, 10 };
            //int[] Numbers2 = new int[] { 10, 20, 30 };
            //int[] Numbers3 = new int[5];

            #region Class Member Methods [Static Methods]

            //Array.Sort(Numbers);  // sort Array in Asc order

            //Console.WriteLine(string.Join(", ", Numbers)); 

            // ==============================================

            //Array.Copy(Numbers2, Numbers3, 3); // Numbers3 = {10, 20, 30, 0, 0}

            //Console.WriteLine(string.Join(", ", Numbers3));

            // ==============================================

            //Array.Clear(Numbers3); // Set all values with 0
            //Console.WriteLine(string.Join(", ", Numbers3));



            // ==============================================

            //Array.ConstrainedCopy(Numbers2, 1, Numbers3, 1, 2); //Numbers3 = {0, 20, 30, 0, 0}
            //foreach (int num in Numbers3)
            //{
            //    Console.WriteLine(num);
            //}

            // ================================================

            //int[] Arr01 = (int[])Array.CreateInstance(typeof(int), 10); // new int [10]
            //// Create 3 Dim Array
            //int[,,] Dim3Arr = (int[,,])Array.CreateInstance(typeof(int), 2, 3, 4);

            // ===============================================

            //Console.WriteLine(Array.LastIndexOf(Numbers2, 20)); // the last index of value 20

            //Console.WriteLine(Array.IndexOf(Numbers3, 10)); // -1 not found 10 in this array

            // ===============================================

            //Array.Reverse(Numbers2);

            //foreach (var item in Numbers2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Object Member Method

            //Numbers2.CopyTo(Numbers3, 1);

            //foreach (var item in Numbers3)
            //{
            //    Console.WriteLine(item);
            //}

            //Numbers3.SetValue(200, 1);
            //Console.WriteLine(Numbers3[1]);


            //Console.WriteLine(Numbers3.GetHashCode());

            //Console.WriteLine($"Max value = {Numbers3.Max()}");

            //Console.WriteLine(Numbers3.GetLength(1)); // Exception
            #endregion


            #endregion

            #region Boxing - Interview Question

            /* Boxing => Casting From value type To reference type
                Safe Casting
                Parent = Child
                Animal = Cat
                Implicit Casting
            */

            //object O1;
            //O1 = new object();

            //O1 = "Ahmed"; // Reference Type To Reference Type [No Casting]
            //O1 = 1;      //  Boxing => Int[Value Type] To Object [Reference Type]
            //O1 = true;

            //O1 = new DateTime(); // Boxing => [ValueType] to [ReferneceType]
            //O1 = new DateOnly(); // .Net 6 C#10

            //int x = 10;
            //object o1 = /*(object)*/ x; // Implicit Casting

            #endregion

            #region UnBoxing

            /* UnBoxing => Casting From Reference type To Value type
                 Explicit Casting
                 UnSafe Casting
                 Child = Parent
                 Cat = Animal
            */

            //object O2 = 2;

            //int x = (int)O2; // unBoxing => [int] to [object], Need Explicit Casting

            //Console.WriteLine(x);

            //object O3 = "Ali";
            //int y = (int)O3; // Exception At Run Time [InvalidCastException]
            //Console.WriteLine(y);

            #endregion

            #region Nullable Types

            /*
              * Nullable Types => Value Types Allow Null Value
              * Reference Types onle Allow [Null] value by default
              * Default of value types Doesnt Allow [Null] as value
            */

            //int[] test = null; // valid because Array is Refernece Type

            //string word = null; // valid because string is Reference Type

            ////int x = null; // invalid

            //int X = 20; // X => Allow Int Values only
            ////x = null; // Invalid

            //int? Y = 20; // Y => Allow Int Values and [Null]
            //Y = null; // Valid 

            //double Num1 = 33.3; // Allow Double Values only
            ////Num1 = null; // Invalid

            //double? Num2 = null; // Valid;

            // =====================================================

            //int X = 5;
            //int? Y = X; // Valid => Implicit Casting [Safe]

            ////X = Y; // Invalid 

            //X = (int)Y;// Valid => Explicit Casting [Unsafe]

            //int? Num1 = null;
            //int Num2 = (int)Num1; // Exception at Run Time 

            // =========================================================

            #region Protective Code

            ////int? L = null;
            ////int M = (int) L; // Un Protective Code


            //int? L = null;
            //int M;

            //if (L is not null)
            //    M = (int)L;
            //else
            //    M = 0;
            //Console.WriteLine(M);

            ///////////////////////////////////////////

            //if (L.HasValue)
            //    M = L.Value;
            //else
            //    M = 0;

            //////////////////////////////////////////

            #region Null Coalescing Operator

            //// Ternary Operator

            //M = L.HasValue ? L.Value : 0;

            // ===============================

            //// Null Coalescing Operator [Like Colease at Sql] ??

            //M = L ?? 0; // Syntax Sugar of Ternary Operator

            #endregion

            #region Null Propagation Operator 

            //double x = default; // 0

            //int[] Arr = default; // Null

            ////for (int i = 0; Arr != null && (i < Arr.Length); i++)
            ////    Console.WriteLine(Arr[i]);  

            //// Null Propagation operator ?
            //for (int i = 0; i < Arr?.Length; i++)
            //    Console.WriteLine(Arr[i]);

            //// Arr?.Length // Syntax Sugar
            //// Arr != null? Arr.Length : null

            //int? length = Arr?.Length; // Protective Code not the better

            //int Length = Arr?.Length ?? 0;  // Null Propagation with Null Coalesing operators   

            //// Employee?.Department?.Name
            #endregion


            #endregion

            #endregion

            #region Functions Calling

            // Print();

            //PrintWithPatternGiven('a');
            //Console.WriteLine();
            //PrintWithPatternGiven('a', 20); // Passing Prameters Using Order

            //PrintWithPatternGiven(count: 10, pattern: 'h');// Passing Prametres By Name 
            //PrintWithPatternGiven(count: 20); // Valid Because pattern is optional

            //PrintWithPatternGiven('\\', 20); //To skip the meaning of the \


            //string FolderPath = "E:\\Asp.Net C40\\Aliaa Tarek(Route)\\Aliaa Tarek\\3.C#\\videos\\04";

            //Console.WriteLine(FolderPath);


            //// Best War

            //string FolderPath2 = @"E:\Asp.Net C40\Aliaa Tarek(Route)\Aliaa Tarek";
            //Console.WriteLine(FolderPath2);

            #endregion

            #region Passing Parameters 

            /// Passing Parameters: 
            /// By Value => Read Only
            /// By Ref => Read First then Write (Parameters Passed By ref Must be Intialized Before Passing)
            /// By Out => Write First then Read (Parmeters Passed By Out Must Be Intialized Inside Function) 

            #endregion

            #region Passing Value Types

            #region Passing By Value

            //int A = 10, B = 20;
            //Console.WriteLine($"Value Of A = {A}");
            //Console.WriteLine($"Value Of B = {B}");


            //Swap(A, B);

            //Console.WriteLine("After Swapping : ");

            //Console.WriteLine($"Value Of A = {A}");
            //Console.WriteLine($"Value Of B = {B}");
            #endregion

            #region Passing By referenece
            //int A = 10, B = 20;
            //Console.WriteLine($"Value Of A = {A}");
            //Console.WriteLine($"Value Of B = {B}");


            //Swap2(ref A, ref B);

            //Console.WriteLine("After Swapping : ");

            //Console.WriteLine($"Value Of A = {A}");
            //Console.WriteLine($"Value Of B = {B}");
            #endregion

            #endregion

            #region Passing Reference Types

            #region By Value


            //int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            //int Sum = SumArray(Numbers);

            //Console.WriteLine($"The Sum Of the Elements At Array : {Sum}"); // 120

            //Console.WriteLine(Numbers[0]); // 100
            //Console.WriteLine(Numbers[1]); // 2


            #endregion

            #region By Refrernce
            //int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            //int sum = SumArrrayRef(ref Numbers);
            //Console.WriteLine(sum); // 120

            //Console.WriteLine(Numbers[0]); // 100


            #endregion


            #endregion

            #region Passing By Out 

            //int A = 10, B = 20, SumResult, MulResult;

            //SumMul(A, B, out SumResult, out MulResult);
            ////SumMul(A, B, out int SumResult, out int MulResult);

            //Console.WriteLine($"Sum Result = {SumResult}");
            //Console.WriteLine($"Mul Result = {MulResult}");

            //int.TryParse( Console.ReadLine(), out int C );

            // ===============================================

            //// 2. Passing By Ref
            //int A = 10, B = 20, SumResult = 0, MulResult = 0;

            //SumMulRef(A, B, ref SumResult, ref MulResult);

            //Console.WriteLine($"Sum Result = {SumResult}");
            //Console.WriteLine($"Mul Result = {MulResult}");
            #endregion

            #region Params

            //int[] Numbers = { 1, 2, 3 };

            //int Sum = SumArr(Numbers); // 6
            //int Sum2 = SumArr(1, 2, 3); // 6

            //Console.WriteLine(Sum);
            //Console.WriteLine(Sum2);

            #endregion


            // ----------------- End Of C# Basics
            // ----------------- Thank You For Your Efforts and Wish You The Best

            /*  Ahmed Refat : .NET Developer
                لاتنسونا من صالح دعائكم 
             */

        }

    }
}
