using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace H2_Assigment_Basic_Threading
{
    /// <summary>
    /// Represents the fourth assigment/exercise for basic threading
    /// </summary>
    public class ExerciseFour
    {
        private Printer _printer = new Printer();

        /// <summary>
        /// Runs exercise four
        /// </summary>
        public void RunExercise()
        {
            Thread thread = new Thread(ReadPressedKey);
            thread.Start();

            _printer.Print();
        }

        /// <summary>
        /// Read the last pressed key after pressing enter
        /// </summary>
        public void ReadPressedKey()
        {
            char lastPressedKey = '*';

            // Read the last pressed key after pressing enter
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    _printer.ch = lastPressedKey;
                }
                else
                {
                    lastPressedKey = keyInfo.KeyChar;
                }
            }
        }
    }

    /// <summary>
    /// Creates a printer which can print a chosen char, multiple times 
    /// </summary>
    public class Printer
    {
        private char _ch = '*';

        public char ch
        {
            get
            {
                return _ch;
            }
            set
            {
                _ch = value;
            }
        }

        /// <summary>
        /// Print out the chosen char, multiple times
        /// </summary>
        public void Print()
        {
            while (true)
            {
                Console.Write(_ch);
                Thread.Sleep(100);
            }
        }
    }
}
