using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProject
{
    class Addition

    {
        static NLog nLog = new NLog();
        public int Add(int firstnumber, int secondnumber)
        {
            if (firstnumber == 0 || secondnumber == 0)
            {
                nLog.LogInfo("addition method");
                nLog.LogDebug("Debug Successfull");
                nLog.LogWarn("First Number or Second Number is zero.");
                return 0;
            }
            else
            {
                int result = firstnumber + secondnumber;
                nLog.LogInfo("addition method");
                nLog.LogDebug("Debug Successfull");
                nLog.LogWarn("addition Method Passed, Result : " + result);
                return result;
            }

        }
    }
}
