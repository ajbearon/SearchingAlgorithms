﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("UnitTests")]

namespace SearchingAlgorithms
{
    internal static class Search
    {
        public static int LinearSearch(string[] items, string itemToFind)
        {
            var found = false;
            int index = 0;

            while (!found && index < items.Length)
            {
                if (items[index] == itemToFind)
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            }

            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}