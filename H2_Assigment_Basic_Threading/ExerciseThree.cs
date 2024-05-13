using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H2_Assigment_Basic_Threading
{
    /// <summary>
    /// Represents the third assigment/exercise for basic threading
    /// </summary>
    public class ExerciseThree
    {
        /// <summary>
        /// Runs exercise three.
        /// </summary>
        public void RunExercise()
        {
            Thread tempThread = new Thread(StartTemp);
            tempThread.Start();

            // Check if tempeture thread is alive every 10 seconds
            while (IsThreadAlive(tempThread))
            {
                Thread.Sleep(10000);
            }

            Console.WriteLine("Alarm-tråd termineret");
        }

        /// <summary>
        /// Starts the temperature game
        /// </summary>
        public void StartTemp()
        {
            Random rand = new Random();
            int alarmCount = 0;

            const int minTemp = -20;
            const int maxTemp = 120;

            // Check if the temperature has been out of the allowed range three times, every 2 seconds
            while (alarmCount < 3)
            {
                int temp = rand.Next(minTemp, maxTemp + 1);

                // Check temperature is withing the allowed range
                if (!CheckTemp(temp))
                {
                    alarmCount++;
                    Console.WriteLine($"Temperaturen er {temp}. Det må den ikke! ({alarmCount})");
                }
                else
                {
                    Console.WriteLine($"Temperaturen er {temp}. Intet problem :-)");
                }
                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// Check if the temperature is within the allowed range
        /// </summary>
        /// <param name="temp">Temperature to check is within the allowed range</param>
        /// <returns>A boolean. If the temperature is within allowered range</returns>
        public bool CheckTemp(int temp)
        {
            const int minAllowedTemp = 0;
            const int maxAllowedTemp = 100;

            if (temp < minAllowedTemp || temp > maxAllowedTemp)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check is thread is alive
        /// </summary>
        /// <param name="thread">Thread to check is alive</param>
        /// <returns>A boolean. If the thread is alive</returns>
        public bool IsThreadAlive(Thread thread)
        {
            return thread.IsAlive;
        }
    }
}
