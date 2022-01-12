using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    
        /*
     метод void setStart(int x) - устанавливает начальное значение
   метод int getNext() - возвращает следующее число ряда
   метод void reset() - выполняет сброс к начальному значению
    */

        class GeomProgression : ISeries
        {
            int step;
            int startValue;
            int currentValue;

            public int getNext()
            {
                currentValue *= step;
                return currentValue;
            }

            public void reset()
            {
                currentValue = startValue;
            }

            public void setStart(int x)
            {
                startValue = x;
                currentValue = startValue;
            }
            public void setStep(int s)
            {
                step = s;
            }
        }
    }


  
