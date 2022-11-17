using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region variable
            ////variables=containers that store values inside of
            //string characterName = "Tom";
            //int characterAge;
            //characterAge = 26; //two ways of cretaing variable


            //Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //characterName = "Mike";
            //Console.WriteLine("He really liked the named " + characterName);
            //Console.WriteLine("But didn't like being "+ characterAge);
            #endregion
            #region datatypes
            //string phrase = "Giraffe Academy";
            //char grade = 'A';//cannot put a bunch of stuff
            //int age = -30;
            //double gpa = 3.2; //float and decimal
            //bool isMale = true;
            #endregion
            #region string
            //string phrase = "Giraffe Academy"+" is cool";
            //Console.WriteLine(phrase);
            //Console.WriteLine( phrase.Substring(phrase.IndexOf("Academy")) );
            //Console.WriteLine(phrase.Substring(8,3));//divide and write the selected range 
            //Console.WriteLine(phrase.IndexOf("Academy"));//tells where the seleceted data start
            //Console.WriteLine(phrase[0]);//shows seleceted number in sentc.

            //Console.WriteLine(phrase.Contains("Academy"));//it checks given data 
            //Console.WriteLine(phrase.ToUpper());//uppercase all word, ToLower()
            //Console.WriteLine(phrase.Length); //how many data includes 
            //Console.WriteLine("Giraffe \nAcademy"); //\n next line 
            //Console.WriteLine("Giraffe \"Academy"); //quotation in sentence
            #endregion
            #region numbers
            //Console.WriteLine( Math.Abs(-40) );
            //Console.WriteLine( Math.Pow(3,2) );
            //Console.WriteLine( Math.Sqrt(36) );
            //Console.WriteLine( Math.Max(4,90) );
            //Console.WriteLine( Math.Min(4,90) );
            //Console.WriteLine( Math.Round(4.6) );
            //int num = 6;
            //num++;//num--;
            //Console.WriteLine( num );
            //Console.WriteLine( 5 + 8 );//can calculate numbers in cw
            #endregion
            #region GettingUserinput
            //Console.Write("Enter your name: ");//prompt for user
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + " you are " + age );
            //Console.ReadLine();//waits for the users enter something
            #endregion
            #region BuildingaCalculator
            //int num = Convert.ToInt32(45);//(56asfas) doesn't work,data that ve give must be number
            //Console.WriteLine(num + 6);
            //Console.WriteLine("43" + "56");//write 4356
            //Console.WriteLine("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine() );
            //Console.WriteLine("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num1 + num2);
            #endregion
            #region BuildingaMadLibsGame
            //string color, pluralNoun, celebrity;

            //Console.WriteLine("Enter a color: ");
            //color = Console.ReadLine();

            //Console.WriteLine("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.WriteLine("Enter a celeberity: ");
            //celebrity = Console.ReadLine(); 


            //Console.WriteLine("Roses are " + color );
            //Console.WriteLine( pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);
            #endregion
            #region Arrays
            //int[] luckyNumbers = {4 , 8, 15, 16, 23, 42 };
            //luckyNumbers[1] = 900;
            //string[] friends = new string[5];// 5 means how many data holds in that array
            //friends[0] = "Jim";
            //friends[1] = "Kelly";
            //Console.WriteLine(luckyNumbers[1]);
            #endregion
            #region Methods
            //Main is a method,method defines that they do spesific jobs
            //SayHi("Mike", 33);
            //Console.ReadLine();
            #endregion
            #region ReturnStatement
            //Console.WriteLine(cube(5)); //1st way of return a statement

            //int cubedNumber = cube(5); //2nd way of return a statement
            //Console.WriteLine(cubedNumber);
            //Console.ReadLine();
            #endregion
            #region if statements
            ////bool isMale = false ; //if it would be true,console writes "you are male"
            //bool isMale = false;
            //bool isTall = true;

            //if (isMale && isTall) // || is or 
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if(isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if(!isMale && isTall)
            //{
            //    Console.WriteLine("You are not male but you are tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male or not tall");
            //    //Console.WriteLine("You are not male");
            #endregion
            #region BuildingABetterCalculator

            //Console.WriteLine("Enter  a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Operator");
            //string op = Console.ReadLine();

            //Console.WriteLine("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if(op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if(op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if(op=="/")
            //{
            //    Console.WriteLine(num1/num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}

            #endregion
            #region SwitchStatement
            //Console.WriteLine(GetDay(4));
            //Console.WriteLine(GetDay(80));
            #endregion
            #region WhileLoops
            // int index = 6;
            //do
            // {
            //     Console.WriteLine(index);
            //     index++;
            // } while (index <= 5) ;

            #endregion
            #region BuildingGuessingGame
            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while(guess != secretWord && !outOfGuesses)
            //{
            //    if(guessCount <guessLimit)
            //    {
            //        Console.WriteLine("Enter guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;

            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }

            //}
            //if(outOfGuesses)
            //{
            //    Console.WriteLine("You Lose!");
            //}
            //else
            //{
            //    Console.WriteLine("You Win!");
            //}
            #endregion
            #region BuildingGuessingGameWithDoWhile
            //string secretWord = "giraffe";
            //string guess = "";
            //int guessLimit = 3;
            //int guessCount = 0;
            //bool outOfGuesses = false;
            //do
            //{
            //    Console.WriteLine("Enter your guess: ");
            //    guess = Console.ReadLine();
            //    if (guess != secretWord)
            //    {
            //        guessCount++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You Win!");
            //    }
            //}
            //while (guessCount < guessLimit && !outOfGuesses);
            //Console.WriteLine("You Lose!");
            #endregion
            #region ForLoop
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            //for(int i = 1; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}
            //Console.ReadLine();
            #endregion
            #region BuildingAnExponentMethod
            //Console.WriteLine(GetPow(3 ,2));
            //Console.ReadLine();
            #endregion
            #region 2dArray

            //int[,] numberGrid = {
            // {1, 2 },
            // {3, 4 },
            // {5, 6 },
            //};
            //int[,] myArray = new int[2, 3]; // it's an array that i will fill the array later 
            //                                // [2,3] means row 

            //Console.WriteLine(numberGrid[1, 1]);
            #endregion
            #region ExceptionHandling

            //try
            //{
            //    Console.WriteLine("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch (DivideByZeroException e) //(Exception e) cw("Error")
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally //always execute
            //{

            //}

            #endregion
            #region Classes
            //Book book1 = new Book(); //creating book object, class object = new class
            //book1.title = "Dune";
            //book1.author = "Frank Herbert"; //that's how "call" variable 
            //book1.pages =  600;

            //Book book2 = new Book(); //creating book object, class object = new class
            //book2.title = "Lord of the Rings";
            //book2.author = "Tolkien"; //that's how "call" variable 
            //book2.pages = 700;

            //Console.WriteLine(book1.title);
            //Console.WriteLine(book2.author);
            #endregion
            #region Consturctors
            //Book book1 = new Book("Dune","Frank Herbert", 600); //creating book object, class object = new class
            ////book1.title = "Dune";
            ////book1.author = "Frank Herbert"; //that's how you can "call" variable 
            ////book1.pages = 600;

            //Book book2 = new Book("Lord of the Rings", "Tolkien", 700);
            ////book2.title = "Lord of the Rings";
            ////book2.author = "Tolkien"; 
            ////book2.pages = 700;  // without constructors we wrote 3 lines of codes for each variable
            //book2.title = "Hobbit";
            //Console.WriteLine(book2.title);
            //Console.WriteLine(book1.author);

            #endregion
            #region ObjectMethods

            //Student student1 = new Student("Jim", "Businnes", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors()); //second: call method
            #endregion
            #region Getters&Setters
            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //// G, PG ,PG-13, R, NR other ratings
            //shrek.Rating = "R";
            //Console.ReadLine();
            #endregion
            #region StaticClassAttribute

            // Song holiday = new Song("Holiday", "Green Day", 200);
            // Console.WriteLine(Song.songCount);
            // Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            // Console.WriteLine(kashmir.getSongCount());//or you can use song count as a method 

            //// Console.WriteLine(Song.songCount);//with static atr.you can call the class, not the object in class
            //// basically,we use Song.songCount instead of kashmir.songCount
            // Console.WriteLine(kashmir.artist);

            // Console.ReadLine();

            #endregion
            #region StaticMethods&Classes

            //Math mymMath = new Math(); //can't create this because Math class is static class
            //UsefulTools.SayHi("Mike");

            //Console.ReadLine();


            #endregion
            #region Inheritance
           // Chef chef = new Chef(); 
           // chef.MakeSpecialDish();
           ///* chef.MakePasta();*///can't do tihs because of making pasta is special method of ItalianChef 

           // ItalianChef italianChef = new ItalianChef();
           // italianChef.MakeSpecialDish();

           // Console.ReadLine();
            #endregion
        }
        #region Methods
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age);
        //}
        #endregion
        #region ReturnStatement
        //static int cube(int num)
        //{
        //    int result = num * num * num; 
        //    return result;
        //}
        #endregion
        #region
        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;
        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //    else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;
        #endregion
        #region SwitchStatement
        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //        switch (dayNum)
        //        {
        //            case 0:
        //                dayName = "Sunday";
        //                break;
        //            case 1:
        //                dayName = "Monday";
        //                break;
        //            case 2:
        //                dayName = "Tuesday";
        //                break;
        //            case 3:
        //                dayName = "Wednesday";
        //                break;
        //            case 4:
        //                dayName = "Thursday";
        //                break;
        //            case 5:
        //                dayName = "Friday";
        //                break;
        //            case 6:
        //                dayName = "Saturday";
        //                break;
        //            default:
        //                dayName = "Invalid Day Number";
        //                break;

        //         }
        //    return dayName;
        //}
        #endregion
        #region ForLoop
        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }
        //    return result;
        //}
        #endregion

    }



}