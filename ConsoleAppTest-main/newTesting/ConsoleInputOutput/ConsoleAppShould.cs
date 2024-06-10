using ConsoleAppTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleInputOutput
{
    [TestClass]
    public class ConsoleAppShould
    {
        // ���� �� ������ ����
        [TestMethod]
        public void ReturnErrorMessageForEmptyInput()
        {
            // ���������� ������
            string input = "";
            string expectedOutput = "������������ ����" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // ���������� �����
            ConsoleAppTesting.Program.Main(new string[] { });

            // �������� ����������
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        // ���� �� ���� �������������� ��������
        [TestMethod]
        public void ReturnErrorMessageForNegativeInput()
        {
            // ���������� ������
            string input = "-3\n0\n";
            string expectedOutput = "������������ ����" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // ���������� �����
            ConsoleAppTesting.Program.Main(new string[] { });

            // �������� ����������
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        // ���� �� ���� ����������� ��������
        [TestMethod]
        public void ReturnErrorMessageForNonNumericInput()
        {
            // ���������� ������
            string input = "abc";
            string expectedOutput = "������������ ����" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // ���������� �����
            ConsoleAppTesting.Program.Main(new string[] { });

            // �������� ����������
            Assert.AreEqual(expectedOutput, output.ToString());
        }

        // ���� �� ���������� ����
        [TestMethod]
        public void ReturnMultiplicationTableForValidInput()
        {
            // ���������� ������
            string input = "3\n4\n";
            string expectedOutput =
                "1 2 3 4 " + Environment.NewLine +
                "2 4 6 8 " + Environment.NewLine +
                "3 6 9 12 " + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            // ���������� �����
            ConsoleAppTesting.Program.Main(new string[] { });

            // �������� ����������
            Assert.AreEqual(expectedOutput, output.ToString());
        }
    }
}
