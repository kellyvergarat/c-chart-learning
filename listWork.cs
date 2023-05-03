using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class listWork
    {
        static List<int> listVar1 = new List<int>();

        public void AddValue(int value)
        {
            listVar1.Add(value);
        }

        public void AddValuePosition(int position, int value)
        {
            listVar1.Insert(position, value);
        }

        public List<int> getList()
        {
            return listVar1;
        }

        public int getListPosition(int position)
        {
            return listVar1[position - 1];
        }

        public void remove

    }

}