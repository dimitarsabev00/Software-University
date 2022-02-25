﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.ListyIterator
{
    public class ListyIterator<T>
    {
        private readonly List<T> list;
        private int idx;

        public ListyIterator(params T[] list)
        {
            this.list = list.ToList();
            idx = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                idx++;
                return true;
            }

            return false;
        }

        public bool HasNext() => idx + 1 < list.Count;

        public void Print()
        {
            if (list.Count == 0) throw new Exception("Invalid Operation!");
            Console.WriteLine(list[idx]);
        }
    }
}
