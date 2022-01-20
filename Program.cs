using System;
using System.IO;

namespace ExceptionHandle
{

    class ExceptionHandling
    {
        public static void Main(String[] args)
        {
            StreamReader streamReader = StreamReader.Null;

            try
            {
                streamReader = new StreamReader(@"D:\training\dotnet\Exception Handling\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());

            }
            catch (FileNotFoundException ex)
            {
                System.Console.WriteLine("Please Check if {0} File Exists? ", ex.FileName);
                System.Console.WriteLine("\n");

                string writeText = "File not Found..";
                File.AppendAllText(@"D:\training\dotnet\Exception Handling\Exceptions.txt", writeText);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                string writeText = e.Message;
                File.AppendAllText(@"D:\training\dotnet\Exception Handling\Exceptions.txt", writeText);
            }
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
                System.Console.WriteLine("Finally block Executed");

            }
        }

    }
}
