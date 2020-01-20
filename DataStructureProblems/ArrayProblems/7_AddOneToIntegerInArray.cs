using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class AddOneToIntegerInArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataArray"></param>
        /// <returns></returns>
        public int[] HandleIntegerArrayPlusOne(int[] dataArray)
        {
            if(dataArray== null || dataArray.Length == 0)
            {
                return dataArray;
            }

            // start from the last item, add one if there is carry, check the next digit
            int index = dataArray.Length - 1;
            bool isCarry = false;
            for(int i = index; i>=0; i--)
            {
                dataArray[i] = dataArray[i] + 1;
                if(dataArray[i] < 10)
                {
                    isCarry = false;
                    break;
                }
                else
                {
                    dataArray[i] = dataArray[i] % 10;
                    isCarry = true;
                }
            }

            if(isCarry == true)
            {
                int[] dataArrayResult = new int[dataArray.Length + 1];
                dataArrayResult[0] = 1;
                for(int i=0;i<dataArray.Length; i++)
                {
                    dataArrayResult[i + 1] = dataArray[i];
                }
                return dataArrayResult;
            }
            else
            {
                return dataArray;
            }
        }
    }
}
