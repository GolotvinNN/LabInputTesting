using ConsoleAppTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleInputOutput
{
    [TestClass]
    public class ConsoleAppShould
    {
        // Тест на пустой ввод
        [TestMethod]
        public void ReturnErrorMessageForEmptyInput()
        {
            // Подготовка данных
            string input = "";
            string expectedOutput = "некорректный ввод" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // Выполнение теста
            ConsoleAppTesting.Program.Main(new string[] { });

            // Проверка результата
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        // Тест на ввод отрицательного значения
        [TestMethod]
        public void ReturnErrorMessageForNegativeInput()
        {
            // Подготовка данных
            string input = "-3\n0\n";
            string expectedOutput = "некорректный ввод" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // Выполнение теста
            ConsoleAppTesting.Program.Main(new string[] { });

            // Проверка результата
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        // Тест на ввод нечислового значения
        [TestMethod]
        public void ReturnErrorMessageForNonNumericInput()
        {
            // Подготовка данных
            string input = "abc";
            string expectedOutput = "некорректный ввод" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // Выполнение теста
            ConsoleAppTesting.Program.Main(new string[] { });

            // Проверка результата
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        // Тест на корректный ввод
        [TestMethod]
        public void ReturnMultiplicationTableForValidInput()
        {
            // Подготовка данных
            string input = "3\n4\n";
            string expectedOutput =
                "1 2 3 4 " + Environment.NewLine +
                "2 4 6 8 " + Environment.NewLine +
                "3 6 9 12 " + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // Выполнение теста
            ConsoleAppTesting.Program.Main(new string[] { });

            // Проверка результата
            Assert.AreEqual(expectedOutput, output.ToString());
        }
    }
}
