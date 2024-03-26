using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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



    // Update is called once per frame
    void Update()
    {
        // firstDate.text = "09-12";
        // firstWeather.text = "Cloudy";
        // firstHighest.text = "Highest 76°F";
        // firstLowest.text = "Lowest 57°F";

        // secondDate.text = "09-13";
        // secondWeather.text = "Rainy";
        // secondHighest.text = "Highest 67°F";
        // secondLowest.text = "Lowest 55°F";

        // thirdDate.text = "09-14";
        // thirdWeather.text = "Sunny";
        // thirdHighest.text = "Highest 63°F";
        // thirdLowest.text = "Lowest 52°F";

        // forthDate.text = "09-15";
        // forthWeather.text = "Sunny";
        // forthHighest.text = "Highest 66°F";
        // forthLowest.text = "Lowest 48°F";

        // fifthDate.text = "09-16";
        // fifthWeather.text = "Cloudy";
        // fifthHighest.text = "Highest 69°F";
        // fifthLowest.text = "Lowest 50°F";


        firstDate.text = "Mar.25.2024";
        firstDay.text = "Monday";
        firstWeather.text = "Angled Rain";
        firstHighest.text = "33°";

        secondDate.text = "Mar.26.2024";
        secondDay.text = "Tuesday";
        secondWeather.text = "Rain";
        secondHighest.text = "34°";

        thirdDate.text = "Mar.27.2024";
        thirdDay.text = "Wednesday";
        thirdWeather.text = "Sun Rain";
        thirdHighest.text = "32°";

        forthDate.text = "Mar.28.2024";
        forthDay.text = "Thursday";
        forthWeather.text = "Tornado";
        forthHighest.text = "30°";

        fifthDate.text = "Mar.29.2024";
        fifthDay.text = "Friday";
        fifthWeather.text = "Windy";
        fifthHighest.text = "32°";
    }
}
