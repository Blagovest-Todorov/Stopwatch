using System;
using System.Diagnostics; // Provides classes that allow You to interact with system processes , event logs, and performance counters
using System.Collections.Generic;

namespace Stopwatch1
{
    class Program
    {

        public static void Main(string[] args) 
        {
            var memory = GC.GetTotalMemory(true);
            var list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
            var memoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine(memoryAfter - memory);
            Console.WriteLine(list[0]);
            // We mesure locally with GarbageCollector how much memory we use !
        }


        static void MeasureTime()
        {
            var a = 0;
            for (int outTimes = 0; outTimes < 10; outTimes++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                for (int times = 0; times < 100000000; times++)
                {
                    a = times * 2;
                }
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
                // optimisations of bottlenecks must be done not as You go, it must be done one as the system is finished !, You optimize when
                // the system is created inn fully, then  You analuize as whole where are the cruitial slow places into teh code, where
                // is the bottlenecks !
                // whem to pptimize :
                // 1.We write high quality code accoring to common practices and principles !-using a high-quality design!
                //make the program easily modifiable, , when its complete and correct, check the performance
                //always consider the compiler Optimisations, 
                // Measure, measure, measure, 
                // write clean code thats easy to maintain !
                // write unit tests before optimizing ! 
                // We verify that the program works correctly using unit tests, acceptance tests, integration tests !
                // allfer all this then we check if the program performance is ok , if it does not work fast enough then we optimise !
                // optimisation- > making the code to work faster is kinda refactoring!
                // acceptance test- the code is working now, we do some modifications(refactor the code), then the code gives the same result
                // acceptance test verifies that after some modificatons the code still continues to work corretly!
                // optimisatons are made on iterations : we do a modification then we analize, we do a second modifiaction then  we measure again, 
                // We dong do several changes and then to measure , becasue we cant understand what is the reason for the cahnge !
                // so measure the improvement ofter every optimisation !
                //
                // if the optimisation does not improve the performance then revert it !
                // when we found the problem then we stop to go inside !
                // Stopwatch is diagnostic tool to measure the fast execution !
                // performance profilers, or memory profilers !---- collect information about memoery usage - > methods frequancy call, 
                // duration of function calls ! 
                // on low level we measure with stopwatch the performace !
                // static fields aree faster than the instantiated fieleds
                //  static methods are faster than the intanciated methods
                // method with less arguments is faster than the same emthod with more arguments !
                // the stack memory si busy with the local variables of teh ethod and with the method allocation, the method is allocated into 
                // the static memory 

                // constants are faster !, the contants are alive in the code forever!

            }

        }
    }
}
