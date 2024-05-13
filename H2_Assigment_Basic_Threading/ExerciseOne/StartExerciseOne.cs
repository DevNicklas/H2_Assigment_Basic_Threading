using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace H2_Assigment_Basic_Threading.ExerciseOne
{
    /// <summary>
    /// Represents the second assigment/exercise for basic threading
    /// </summary>
    public class StartExerciseOne
    {
        /// <summary>
        /// Runs exercise one
        /// </summary>
        public void RunExercise()
        {
            MessageExerciseTwo msgExerciseOne = new MessageExerciseTwo();

            Thread easyThreading = new Thread(msgExerciseOne.EasyThreading);
            Thread easyMultipleThreading = new Thread(msgExerciseOne.EasyMultipleThreading);

            easyThreading.Start();
            easyMultipleThreading.Start();
            Console.Read();
        }
    }
}
