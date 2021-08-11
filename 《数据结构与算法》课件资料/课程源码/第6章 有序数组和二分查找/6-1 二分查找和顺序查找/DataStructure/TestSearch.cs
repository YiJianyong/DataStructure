using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class TestSearch
    {
        //二分查找法，在有序数组arr中，查找target
        //如果找到target，返回相应的索引index
        //如果没有找到target，返回-1
        public static int BinarySearch(int[] arr,int target)
        {
            //在[l...r]范围里寻找target
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                //int mid = (r + l) / 2;
                int mid = l + (r - l) / 2;

                if (target < arr[mid])
                    r = mid - 1;    //在arr[l...mid-1]查找target
                else if (target > arr[mid])
                    l = mid + 1;    //在arr[mid+1...r]查找target
                else
                    return mid;     //找到target，并返回索引
            }

            return -1;
        }
    }
}
