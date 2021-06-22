using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Loops_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While Loop
            int currentHour = DateTime.Now.Hour;
            while (currentHour < 19)
            {
                Console.WriteLine("Learn More");
                currentHour = DateTime.Now.Hour;
            }
            Console.WriteLine("Go Home Chukupim");

            #endregion

            #region do while Loop

            string userName = "Moshe";
            string password = "123321";
            bool isUserExist;
            bool isPasswordMatch;
            do
            {
                string inputUserName = Console.ReadLine();
                string inputPassword = Console.ReadLine();

                isUserExist = userName == inputUserName;
                isPasswordMatch = password == inputPassword;
            }
            while (!isUserExist || !isPasswordMatch);


            #endregion

            #region for Loop

            //From Zero To Ten
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("123");
            }

            // From Ten To Zero
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //Complex Loop
            for (int i = 0, j = 10; i < j && j != 4; i++, j--)
            {

            }

            #endregion

            #region Break & Continue

            while (true)                             // לולאה אין סופית
            {
                string s = Console.ReadLine();      // קבלת קלט מהמשתמש
                if (s == "Q")
                    break; 					        // צא מהלולאה

                else if (s == "C")
                    continue;					    //המשך לאיטרציה הבאה
                else
                    Console.WriteLine(s);           // אחרת תדפיס את הערך
            }

            Console.WriteLine("End Program");		// יקרה רק אחרי שהלולאה תסתיים


            #endregion
        }
    }
}
