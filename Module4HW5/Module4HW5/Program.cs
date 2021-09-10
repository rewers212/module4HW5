using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Module4HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new StartApp();
            start.FirstQuery();
            start.SecondQuery();
            start.ThirdQuery();
            start.FourthQuery();
            start.FifthQuery();
        }        
    }
}
