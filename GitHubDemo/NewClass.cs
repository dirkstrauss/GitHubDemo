using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubDemo
{
    class NewClass
    {
        public double CountDown(double theFactor)
        {
            int currentHour = DateTime.Now.Hour;
            return currentHour / theFactor;
        }
    }
}
