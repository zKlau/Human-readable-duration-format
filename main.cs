using System;
public class HumanTimeFormat{
  public static string formatDuration(int s){
        if (s == 0) {return "now";}
        TimeSpan t = TimeSpan.FromSeconds(s);
        int years = 0,
            days = t.Days,
            hours = t.Hours,
            min = t.Minutes,
            sec = t.Seconds;

        string time = "";
        string yearTime = "years",
                dayTime = "days",
                hourTime = "hours",
                minTime = "minutes",
                secTime = "seconds";

        while (days >= 365)
        {
            years++;
            days -= 365;
        }
        int[] n = new int[]{years,days,hours,min,sec};
        int sp = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] != 0)
            {
                sp++;
            }
        }
        
        Console.WriteLine(sp);
        if (years == 1) yearTime = "year";
        if (days == 1) dayTime = "day";
        if (hours == 1) hourTime = "hour";
        if (min == 1) minTime = "minute";
        if (sec == 1) secTime = "second";

        string space = ", "; 
        string yearT = String.Format("{0} {1}",years,yearTime);
        string daysT = String.Format("{0} {1}",days,dayTime);
        string hourT = String.Format("{0} {1}", hours,hourTime);
        string minT = String.Format("{0} {1}", min,minTime);
        string secT = String.Format("{0} {1}", sec,secTime);
        if (sp == 1)
        {
            if (years != 0) {return yearT;}
            if (days != 0) {return daysT ;}
            if (hours != 0) {return hourT;}
            if (min != 0) {return minT;}
            if (sec != 0) {return secT ;}
        }
        if (years != 0) {if (sp == 2) space = " and "; if (sp == 1) space = string.Empty;time += yearT + $"{space}";  sp--;    }
        if (days != 0) {  if (sp == 2) space = " and ";if (sp == 1) space = string.Empty;time += daysT + $"{space}";  sp--;    }
        if (hours != 0) {if (sp == 2) space = " and ";if (sp == 1) space = string.Empty;   time += hourT + $"{space}";sp--;    }
        if (min != 0) { if (sp == 2) space = " and "; if (sp == 1) space = string.Empty;   time += minT + $"{space}";  sp--;    }
        if (sec != 0) { time +=  secT ;}
        
        Console.WriteLine(sp);
        return time;
  }
}
