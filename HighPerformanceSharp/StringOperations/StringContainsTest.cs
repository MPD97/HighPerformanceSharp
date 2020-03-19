using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
    public class StringContainsTest : ITestString
    {
        private StringBuilder StringBuilder { get; set; }
        private bool LastTestResult { get; set; }
        private string LastArgument { get; set; }
        private Random Generator { get; set; } =  new Random();


        public char ExistingChar { get; set; }
        public char NotExistingChar { get; set; } 
        public string ExistingString { get; set; } 
        public string NotExistingString { get; set; } 

        public void Initialize(long size)
        {
            StringBuilder = new StringBuilder();


            for (int i = 0; i < size; i++)
            {
                GenerateAlphabetAndNumber(StringBuilder);
            }
            AssignExistingChar();
            AssignNotExistingChar();
            AssignExistingString();
            AssignNotExistingString();
        }

        private void GenerateAlphabetAndNumber(StringBuilder stringBuilder)
        {
            var uppercaseChar = GetUppercaseChar(Generator);
            var lowercaseChar = GetLowercaseChar(Generator);
            var number = GetNumber(Generator);

            var random = Generator.NextDouble();
            if (random < 0.33)
            {
                stringBuilder.Append(uppercaseChar);
            }
            else if (random < 0.66)
            {
                stringBuilder.Append(lowercaseChar);
            }
            else
            {
                stringBuilder.Append(number);
            }
        }

        private static int GetNumber(Random generator)
        {
            return generator.Next(0, 10);
        }

        private static char GetLowercaseChar(Random generator)
        {
            return (char)generator.Next(97, 123);
        }

        private static char GetSymbol(Random generator)
        {
            return (char)generator.Next(33, 48);
        }
        private static char GetUppercaseChar(Random generator)
        {
            return (char)generator.Next(65, 91);
        }

        public virtual bool Test(string text)
        {
            LastArgument = text;

            bool result = StringBuilder.ToString().Contains(text);

            LastTestResult = result;

            return result;
        }

        public virtual bool Test(char text)
        {
            LastArgument = text.ToString();

            bool result = StringBuilder.ToString().Contains(text);
            
            LastTestResult = result;

            return result;
        }

        public bool Validate()
        {
            bool realResult = StringBuilder.ToString().Contains(LastArgument);

            return LastTestResult == realResult;
        }

        public void AssignExistingChar()
        {
            char result;
            while (StringBuilder.ToString().Contains(result = GetLowercaseChar(Generator)) == false) ;
           
            ExistingChar = result;
        }
        public void AssignNotExistingChar()
        {
            char result;
            while (StringBuilder.ToString().Contains(result = GetSymbol(Generator)) == true) ;

            NotExistingChar = result;
        }
        public void AssignExistingString()
        {
            string result;
            do
            {
                int startIndex = Generator.Next(0, StringBuilder.Length - 2);
                int maxToTake = StringBuilder.Length - startIndex - 1;
                int take = 0;
                if (maxToTake < 20)
                {
                    take = Generator.Next(2, 20);
                }
                else
                {
                    take = Generator.Next(2, maxToTake);
                }
                int howManyTake = Generator.Next(1, take);

                result = StringBuilder.ToString().Substring(startIndex, howManyTake);

            } while (StringBuilder.ToString().Contains(result) == false);

            ExistingString = result;
        }
        public void AssignNotExistingString()
        {
            StringBuilder result;
            do
            {
                result = new StringBuilder();
                for (int i = 0; i < Generator.Next(2,20); i++)
                {
                    GenerateAlphabetAndNumber(result);
                }

            } while (StringBuilder.ToString().Contains(result.ToString()) == true);

            NotExistingString = StringBuilder.ToString();
        }

        public char GetExistingChar()
        {
            if (string.IsNullOrEmpty(ExistingChar.ToString()))
            {
                AssignExistingChar();
            }
            return ExistingChar;
        }

        public char GetNotExistingChar()
        {
            if (string.IsNullOrEmpty(NotExistingChar.ToString()))
            {
                AssignNotExistingChar();
            }
            return NotExistingChar;
        }

        public string GetExistingString()
        {
            if (string.IsNullOrEmpty(ExistingString.ToString()))
            {
                AssignExistingString();
            }
            return ExistingString;
        }

        public string GetNotExistingString()
        {
            if (string.IsNullOrEmpty(NotExistingString.ToString()))
            {
                AssignNotExistingString();
            }
            return NotExistingString;
        }
    }
}
