using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private static long _delayValue;

        public static void Delay(int value) 
        {
            _delayValue = 0;

            for (int i = 0; i < value; i++)
            {
                for (int j= 0; j < value; j++)
                {
                    _delayValue = _delayValue + 1;
                }
            }
        }
    }
}
