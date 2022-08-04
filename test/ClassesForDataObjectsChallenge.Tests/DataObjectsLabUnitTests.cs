using System;
using Xunit;
using ClassesForDataObjects;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

namespace DataObjectsLabTests
{
    public class DataObjectsLabUnitTests
    {
        TextWriter m_normalOutput;
        StringWriter m_testingConsole;
        StringBuilder m_testingSB;

        //User input
        List<string> gritters = new List<string>();
        public DataObjectsLabUnitTests()
        {
            // Set current folder to testing folder
            //string assemblyCodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string assemblyCodeBase = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dirName = Path.GetDirectoryName(assemblyCodeBase);

            if (dirName.StartsWith("file:\\"))
                dirName = dirName.Substring(6);

            Environment.CurrentDirectory = dirName;

            m_testingSB = new StringBuilder();
            m_testingConsole = new StringWriter(m_testingSB);
            m_normalOutput = System.Console.Out;
            System.Console.SetOut(m_testingConsole);
        }

        [Fact]
        public void Task1ListTheNameAndAgeOfFemaleStudentsWhoAreUnder21Test()
        {
            //int i = 0;
            Assert.Equal(0, StartConsoleApplication(""));

            string actual = m_testingSB.ToString().Replace( "\r", "").ToUpper();

            Assert.Contains(("Doina Precup is 20 years old\n"
                            ).ToUpper(), actual);
            Assert.Contains(("Marissa Mayer is 20 years old\n"
                            ).ToUpper(), actual);
        }

        [Fact]
        public void Task2ListTheSurnameAndAgeOfFemaleStudentsWhoAre21OrOverTest()
        {
            //int i = 0;
            Assert.Equal(0, StartConsoleApplication(""));

            string actual = m_testingSB.ToString().Replace("\r", "").ToUpper();

            Assert.Contains(("Ehmke is 22 years old\n"
                            ).ToUpper(), actual);
            Assert.Contains(("Chang is 21 years old\n"
                            ).ToUpper(), actual);
        }

        [Fact]
        public void Task2ThePopularityOfHobbiesInDescendingSequenceWithinGenderTest()
        {
            //int i = 0;
            Assert.Equal(0, StartConsoleApplication(""));

            string actual = m_testingSB.ToString().Replace("\r", "").ToUpper();

            Assert.Contains(("Gender: F, Hobby: Sport, Count: 2\n" +
                             "Gender: F, Hobby: Films, Count: 1\n" +
                             "Gender: F, Hobby: Music, Count: 1\n" +
                             "Gender: M, Hobby: Music, Count: 1\n" +
                             "Gender: M, Hobby: Sport, Count: 1\n" +
                             "Gender: U, Hobby: Music, Count: 1\n"
                            ).ToUpper(), actual);
        }

        private int StartConsoleApplication(string arguments)
        {
            //Program.Main(arguments.Split(' '));
            Process proc = new Process();
            proc.StartInfo.FileName = "ClassesForDataObjectsChallenge.Code.exe";
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.Start();
            proc.WaitForExit();
            System.Console.WriteLine(proc.StandardOutput.ReadToEnd());
            System.Console.Write(proc.StandardError.ReadToEnd());
            return proc.ExitCode;
        }
    }
}
