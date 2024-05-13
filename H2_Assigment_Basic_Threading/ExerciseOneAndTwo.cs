using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace H2_Assigment_Basic_Threading
{
    /// <summary>
    /// Represents the second assigment/exercise for basic threading
    /// </summary>
    public class ExerciseOneAndTwo
    {
        /// <summary>
        /// Runs exercise one and two
        /// </summary>
        public void RunExercise()
        {
            Thread easyThreading = new Thread(EasyThreading);
            Thread easyMultipleThreading = new Thread(EasyMultipleThreading);

            easyThreading.Start();
            easyMultipleThreading.Start();
        }

        /// <summary>
        /// Writes out threading is easy, 5 times
        /// </summary>
        public void EasyThreading()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt");
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Writes out that multiple threads is easy
        /// </summary>
        public void EasyMultipleThreading()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde ...");
                Thread.Sleep(1000);
            }
        }
    }
}
