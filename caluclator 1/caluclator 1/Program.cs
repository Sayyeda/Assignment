using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using System.Reflection;
using System.IO;


namespace caluclator_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
              
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [STAThread]
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(); //only once
 
            Log.Debug("Application is starting");
            Console.WriteLine("Test Line");
            var testClass = new TestClass();
            testClass.LogSomething();
 
            Log.Debug("Application is ending");
            Console.Read();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string strLogText = "log filed.";

            // Create a writer and open the file:
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }

            // Write to the file:
            log.WriteLine(DateTime.Now);
            log.WriteLine(strLogText);
            log.WriteLine();

            // Close the stream:
            log.Close();

            

            
        }
    }
 
    public class TestClass
    {
 
        private static readonly ILog Log = LogManager.GetLogger
                                (MethodBase.GetCurrentMethod().DeclaringType);
 
        public void LogSomething()
        {
            for (int i = 0; i < 100; i++)
            {
                Log.InfoFormat("CurrentTime is [{0}]", DateTime.Now.ToString
                                ("yyyy.MM.dd-hh.mm.ss~fff"));
                
            }
 
        
           
        }
    }

   
}

