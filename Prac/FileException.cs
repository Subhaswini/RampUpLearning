using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Prac
{
    class FileException
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            
            try
            {
                streamReader = new StreamReader(@"C:\SampleFile\data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }

            //FileNotFoundException
            catch (FileNotFoundException ex)
            {
                /*Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);*/
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                
                Console.WriteLine("Finally block!");
            }
          
        }
    }
}
