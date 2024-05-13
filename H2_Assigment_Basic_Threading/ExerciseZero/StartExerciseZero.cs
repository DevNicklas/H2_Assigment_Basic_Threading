using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace H2_Assigment_Basic_Threading.ExerciseZero
{
    /// <summary>
    /// Represents the first assigment/exercise for basic threading
    /// </summary>
    public class StartExerciseZero
    {
        /// <summary>
        /// Runs exercise zero
        /// </summary>
        public void RunExercise()
        {
            MessageExerciseZero threadClass = new MessageExerciseZero();

            // Create threads with the WorkThreadMethod of ThreadClass
            Thread firstThread = new Thread(new ThreadStart(threadClass.WorkThreadMethod));
            Thread secondThread = new Thread(new ThreadStart(threadClass.WorkThreadMethod));

            // Assign names to the threads
            firstThread.Name = "FirstThread";
            secondThread.Name = "SecondThread";

            // Start threads
            firstThread.Start();
            secondThread.Start();

            Console.Read();
        }
    }
}
