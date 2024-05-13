using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace H2_Assigment_Basic_Threading
{
    /// <summary>
    /// Represents the first assigment/exercise for basic threading
    /// </summary>
    public class ExerciseZero
    {
        /// <summary>
        /// Runs exercise zero
        /// </summary>
        public void RunExercise()
        {

            // Create threads with the WorkThreadMethod of ThreadClass
            Thread firstThread = new Thread(new ThreadStart(WorkThreadMethod));
            Thread secondThread = new Thread(new ThreadStart(WorkThreadMethod));

            // Assign names to the threads
            firstThread.Name = "FirstThread";
            secondThread.Name = "SecondThread";

            // Start threads
            firstThread.Start();
            secondThread.Start();
        }

        /// <summary>
        /// Writes out the thread which executes the method
        /// </summary>
        public void WorkThreadMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread by" + Thread.CurrentThread.Name);
            }
        }
    }
}
