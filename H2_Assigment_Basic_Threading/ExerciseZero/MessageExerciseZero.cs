using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace H2_Assigment_Basic_Threading.ExerciseZero
{
    /// <summary>
    /// Represents all messages for exercise zero
    /// </summary>
    public class MessageExerciseZero
    {
        /// <summary>
        /// Writes out the thread which executes the method
        /// </summary>
        public void WorkThreadMethod()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread by" + Thread.CurrentThread.Name);
            }
        }
    }
}
