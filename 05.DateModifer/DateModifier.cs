using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


public class DateModifier
{ 

    public static double DifferensDateTime(string startDate, string endDate)
    {
        var start = DateTime.ParseExact(startDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var end = DateTime.ParseExact(endDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        if (start > end)
        {
            return DifferensDateTime(endDate, startDate);
        }
        return (end - start).Days;
    }
}
    

