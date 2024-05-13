using H2_Assigment_Basic_Threading.ExerciseOne;
using H2_Assigment_Basic_Threading.ExerciseThree;
using H2_Assigment_Basic_Threading.ExerciseZero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H2_Assigment_Basic_Threading
{
    /// <summary>
    /// The main entry point for the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point for the program.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Exercise Zero
            // StartExerciseZero exerciseZero = new StartExerciseZero();
            // exerciseZero.RunExercise();

            // Exercise One
            // StartExerciseOne exerciseOne = new StartExerciseOne();
            // exerciseOne.RunExercise();

            // Exercise Two
            StartExerciseThree exerciseThree = new StartExerciseThree();
            exerciseThree.RunExercise();

            // Exercise Three
        }
    }
}
