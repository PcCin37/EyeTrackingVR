using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeDayTextController : MonoBehaviour
{
    public Text firstDate;
    public Text firstWeather;
    public Text firstHighest;
    public Text firstLowest;
    public Text secondDate;
    public Text secondWeather;
    public Text secondHighest;
    public Text secondLowest;
    public Text thirdDate;
    public Text thirdWeather;
    public Text thirdHighest;
    public Text thirdLowest;
    public Text forthDate;
    public Text forthWeather;
    public Text forthHighest;
    public Text forthLowest;
    public Text fifthDate;
    public Text fifthWeather;
    public Text fifthHighest;
    public Text fifthLowest;

    // Update is called once per frame
    void Update()
    {
        firstDate.text = "09-12";
        firstWeather.text = "Cloudy";
        firstHighest.text = "Highest 76°F";
        firstLowest.text = "Lowest 57°F";

        secondDate.text = "09-13";
        secondWeather.text = "Rainy";
        secondHighest.text = "Highest 67°F";
        secondLowest.text = "Lowest 55°F";

        thirdDate.text = "09-14";
        thirdWeather.text = "Sunny";
        thirdHighest.text = "Highest 63°F";
        thirdLowest.text = "Lowest 52°F";

        forthDate.text = "09-15";
        forthWeather.text = "Sunny";
        forthHighest.text = "Highest 66°F";
        forthLowest.text = "Lowest 48°F";

        fifthDate.text = "09-16";
        fifthWeather.text = "Cloudy";
        fifthHighest.text = "Highest 69°F";
        fifthLowest.text = "Lowest 50°F";


        // firstDate.text = "08-20";
        // firstWeather.text = "多云";
        // firstHighest.text = "最高 33°C";
        // firstLowest.text = "最低 24°C";

        // secondDate.text = "08-21";
        // secondWeather.text = "晴";
        // secondHighest.text = "最高 34°C";
        // secondLowest.text = "最低 25°C";

        // thirdDate.text = "08-22";
        // thirdWeather.text = "雨";
        // thirdHighest.text = "最高 32°C";
        // thirdLowest.text = "最低 26°C";

        // forthDate.text = "08-23";
        // forthWeather.text = "雨";
        // forthHighest.text = "最高 30°C";
        // forthLowest.text = "最低 24°C";

        // fifthDate.text = "08-24";
        // fifthWeather.text = "阴";
        // fifthHighest.text = "最高 32°C";
        // fifthLowest.text = "最低 24°C";
    }
}
