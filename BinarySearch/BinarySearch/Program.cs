using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BinarySearch bt = new BinarySearch();

            bt.Insert(42);
            bt.Insert(25);
            bt.Insert(65);
            bt.Insert(12);
            bt.Insert(37);
            bt.Insert(13);
            bt.Insert(30);
            bt.Insert(43);
            bt.Insert(87);
            bt.Insert(99);
            bt.Insert(9);

            Console.WriteLine("Inorder");
            bt.Inorder();

            Console.WriteLine(" ");
             
            Console.ReadLine();

            Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
