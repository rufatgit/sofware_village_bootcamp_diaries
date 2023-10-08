using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson19_practice
{
    public class ListInt
    {
        private int[] array = new int[0];
        public int Length
        {
            get { return array.Length; }
        }


        public int this[int index]
        {
            get
            {
                if (index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    return array[array.Length - 1];
                }
            }

            set
            {
                if (array.Length > index)
                {
                    array[index] = value;
                }
            }
        }



        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;
        }


        public void AddRange(params int[] nums)
        {
            Array.Resize(ref array, array.Length + nums.Length);  //

            for (int i = 0; i < nums.Length; i++)
            {
                array[array.Length - nums.Length + i] = nums[i];  //3-2+0    1 2 3 - 5 6
            }



        }



    }
}
