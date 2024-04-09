using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using System;
using System.Globalization;

public class newTxtCrtl : MonoBehaviour
{
    public TMP_Text firstDate;
    public TMP_Text firstDay;
    public TMP_Text firstWeather;
    public TMP_Text firstHighest;
    public TMP_Text secondDate;
    public TMP_Text secondDay;
    public TMP_Text secondWeather;
    public TMP_Text secondHighest;
    public TMP_Text thirdDate;
    public TMP_Text thirdDay;
    public TMP_Text thirdWeather;
    public TMP_Text thirdHighest;
    public TMP_Text forthDate;
    public TMP_Text forthDay;
    public TMP_Text forthWeather;
    public TMP_Text forthHighest;
    public TMP_Text fifthDate;
    public TMP_Text fifthDay;
    public TMP_Text fifthWeather;
    public TMP_Text fifthHighest;

    public static Temperature Temperature;
    public static event Action OnTemperatureLoaded;

    void Start()
    {
        string chineseWeekday = "星期二";
        Debug.Log(WeekdayConverter.ConvertToEnglish(chineseWeekday));
        StartCoroutine(GetData());
    }

    // Update is called once per frame
    void Update()
    {
        if (Temperature != null)
        {
            firstDate.text = DateFormatConverter.ConvertDate(Temperature.data.forecast[0].ymd);
            firstDay.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[0].week);
            firstWeather.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[0].type);
            firstHighest.text = ExtractTemperature(Temperature.data.forecast[0].high);

            secondDate.text = DateFormatConverter.ConvertDate(Temperature.data.forecast[1].ymd);
            secondDay.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[1].week);
            secondWeather.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[1].type);
            secondHighest.text = ExtractTemperature(Temperature.data.forecast[1].high);


            thirdDate.text = DateFormatConverter.ConvertDate(Temperature.data.forecast[2].ymd);
            thirdDay.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[2].week);
            thirdWeather.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[2].type);
            thirdHighest.text = ExtractTemperature(Temperature.data.forecast[2].high);

            forthDate.text = DateFormatConverter.ConvertDate(Temperature.data.forecast[3].ymd);
            forthDay.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[3].week);
            forthWeather.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[3].type);
            forthHighest.text = ExtractTemperature(Temperature.data.forecast[3].high);

            fifthDate.text = DateFormatConverter.ConvertDate(Temperature.data.forecast[4].ymd);
            fifthDay.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[4].week);
            fifthWeather.text = WeekdayConverter.ConvertToEnglish(Temperature.data.forecast[4].type);
            fifthHighest.text = ExtractTemperature(Temperature.data.forecast[4].high);

        }


    }

    private IEnumerator GetData()
    {

        UnityWebRequest unityWebRequest = UnityWebRequest.Get("http://t.weather.sojson.com/api/weather/city/101210101");
        yield return unityWebRequest.SendWebRequest();
        if (unityWebRequest.isDone)
        {
            Debug.Log(unityWebRequest.downloadHandler.text);
            Temperature = JsonUtility.FromJson<Temperature>(unityWebRequest.downloadHandler.text);
            Debug.Log(Temperature.cityInfo.city);
            OnTemperatureLoaded?.Invoke();
        }
    }

    public string ExtractTemperature(string highTemperature)
    {
        string[] parts = highTemperature.Split(' ');

        if (parts.Length > 1)
        {
            string temperatureWithC = parts[1];
            if (temperatureWithC.EndsWith("℃"))
            {
                return temperatureWithC.Substring(0, temperatureWithC.Length - 1);
            }
            else
            {
                return temperatureWithC;
            }
        }
        else
        {
            return "format error";
        }
    }



    public class DateFormatConverter
    {
        public static string ConvertDate(string inputDate)
        {
            if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate.ToString("MMM.dd.yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                return "Invalid date format";
            }
        }
    }

}



[System.Serializable]
public class Temperature
{
    public string message;
    public int status;
    public string date;
    public string time;
    public CityInfo cityInfo;
    public Data data;
}

[System.Serializable]
public class CityInfo
{
    public string city;
    public string citykey;
    public string parent;
    public string updateTime;
}
[System.Serializable]
public class Data
{
    public string shidu;
    public float pm25;
    public float pm10;
    public string quality;
    public string Temperature;
    public string ganmao;
    public List<Forecast> forecast;
    public Forecast yesterday;
}
[System.Serializable]
public class Forecast
{
    public string date;
    public string high;
    public string low;
    public string ymd;
    public string week;
    public string sunrise;
    public string sunset;
    public int aqi;
    public string fx;
    public string fl;
    public string type;
    public string notice;
}
