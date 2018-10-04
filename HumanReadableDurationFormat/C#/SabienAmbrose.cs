//link: http://www.codewars.com/kata/52742f58faf5485cae000b9a/train

using System;
using System.Collections.Generic;
using System.Linq;


class HumanTimeFormat
{
    public enum TimeTypes
    {
        second, minute, hour, day, year
    }

    public static string formatDuration(int seconds)
    {

        Dictionary<TimeTypes, int> times = new Dictionary<TimeTypes, int>();

        int secondsPerYear = 365 * 24 * 60 * 60; //days * hours/day * minutes/hour * seconds/minute
        int secondsPerDay = 24 * 60 * 60; //hours/day * minutes/hour * seconds/minute
        int secondsPerHour = 60 * 60; //minutes/hour * seconds/minute
        int secondsPerMinute = 60; //seconds/minute

        int years = seconds / secondsPerYear;
        times.Add(TimeTypes.year, years);
        seconds -= years * secondsPerYear;

        int days = seconds / secondsPerDay;
        times.Add(TimeTypes.day, days);
        seconds -= days * secondsPerDay;

        int hours = seconds / secondsPerHour;
        times.Add(TimeTypes.hour, hours);
        seconds -= hours * secondsPerHour;

        int minutes = seconds / secondsPerMinute;
        times.Add(TimeTypes.minute, minutes);
        seconds -= minutes * secondsPerMinute;

        times.Add(TimeTypes.second, seconds);

        return FormatDictionary(times);
    }

    public static String FormatDictionary(Dictionary<TimeTypes, int> times)
    {
        //clear out all times that are 0
        times.ToList().Where(pair => pair.Value == 0).ToList().ForEach(pair => times.Remove(pair.Key));

        String toReturn = "";
        //format the string for return
        if(times.Keys.Count == 0)
        {
            toReturn = "now";
        }else if(times.Keys.Count == 1)
        {
            foreach(TimeTypes timeType in times.Keys)
            {
                int time = times[timeType];
                toReturn = GetStringFor(timeType, time);
            }
        }
        else
        {
            TimeTypes[] timeTypes = new TimeTypes[times.Keys.Count];
            times.Keys.CopyTo(timeTypes, 0);
            foreach (TimeTypes timeType in timeTypes)
            {
                int time = times[timeType];
                toReturn += GetStringFor(timeType, time) + "";
                // its last do nothing
                if(timeType == timeTypes[timeTypes.Length - 1])
                {
                    toReturn += "";
                }else if (timeType == timeTypes[timeTypes.Length - 2])
                {
                    toReturn += " and ";
                }else
                {
                    toReturn += ", ";
                }
            }
        }
        return toReturn;
    }

    static String GetStringFor(TimeTypes timeType, int time)
    {
        if(time > 1)
        {
            return time + " " + timeType.ToString() + "s";
        }
        else
        {
            return time + " " + timeType.ToString();
        }
    }
}