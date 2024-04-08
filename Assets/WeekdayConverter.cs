using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekdayConverter : MonoBehaviour
{

    private static readonly Dictionary<string, string> weekDayMap = new Dictionary<string, string>
    {
        {"中雨", "Mid Rain"},
        {"晴", "Sunny"},
        {"多云", "Cloudy"},
        {"阴", "Cloudy"},
        {"小雨", "Light Rain"},
        {"大雨", "Heavy Rain"},
        {"雪", "Snowy"}
    };

    private static readonly Dictionary<string, string> WeatherMap = new Dictionary<string, string>
    {
        {"星期一", "Monday"},
        {"星期二", "Tuesday"},
        {"星期三", "Wednesday"},
        {"星期四", "Thursday"},
        {"星期五", "Friday"},
        {"星期六", "Saturday"},
        {"星期日", "Sunday"}
    };

    public static string ConvertToEnglish(string chineseWord)
    {
        if (weekDayMap.TryGetValue(chineseWord, out string englishWeekday))
        {
            return englishWeekday;
        }

        if (WeatherMap.TryGetValue(chineseWord, out string englishWord))
        {
            return englishWord;
        }


        return chineseWord;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
