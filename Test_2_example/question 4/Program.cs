using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // סעיף א.
            // : התבוננו בקטע הקוד הבא

            int[] arr = new int[] { 2, 3, 5, 1, 4 };
            Console.WriteLine("START");
            foreach (int num in arr)
            {
                num++;
                Console.Write(num + ", ");
            }
            Console.WriteLine("END");

            /*
             * האם הקוד הנל ירוץ ללא שגיאות?
             * אם נכון, נא לפרט מה יודפס.
             * אם לא נכון, נא לפרט מהי השגיאה בקוד.
             * 
             * תשובה:
             * לא נכון, לולאת "פוראיץ' " היא ריד אונלי
             * משמע אני לא יכול להעלות את ערכו של המשתנה.
             */




            // סעיף ב
            // קומפיילר היא תוכנית המתרגמת קוד משפה עילית לשפת מכונה
            // נכון או לא נכון?!

            /* תשובה :
             * נכון
             */
        }
    }
}
