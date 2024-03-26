using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text cityNameText;
    public Text dateText;
    public Text temperatureText;
    public Text weatherText;
    public Text highestTempText;
    public Text lowestTempText;

    // Update is called once per frame
    void Update()
    {
        cityNameText.text = "New York";
        dateText.text = "2023-09-11";
        temperatureText.text = "62°F";
        weatherText.text = "Cloudy";
        // 晴朗 Sunny
        // 阴 Cloudy
        // 雨 Rainy
        // 雪 Snowy
        // 多云 Partly Cloudy
        // 风 Windy
        highestTempText.text = "Highest 73°F";
        lowestTempText.text = "Lowest 60°F";

        if (weatherText.text == "Rainy" || weatherText.text == "Cloudy") {
            GameObject.Find("Canvas/TodayPanel/CityName").GetComponent<Text>().color = Color.white;
            GameObject.Find("Canvas/TodayPanel/Date").GetComponent<Text>().color = Color.white;
            GameObject.Find("Canvas/TodayPanel/Temperature").GetComponent<Text>().color = Color.white;
            GameObject.Find("Canvas/TodayPanel/Weather").GetComponent<Text>().color = Color.white;
            GameObject.Find("Canvas/TodayPanel/Highest").GetComponent<Text>().color = Color.white;
            GameObject.Find("Canvas/TodayPanel/Lowest").GetComponent<Text>().color = Color.white;
        }

        // cityNameText.text = "杭州市";
        // dateText.text = "2023-08-19";
        // temperatureText.text = "31°C";
        // weatherText.text = "阴";
        // // 晴朗 Sunny
        // // 阴 Cloudy
        // // 雨 Rainy
        // // 雪 Snowy
        // // 多云 Partly Cloudy
        // // 风 Windy
        // highestTempText.text = "最高气温 31°C";
        // lowestTempText.text = "最低气温 24°C";

        // if (weatherText.text == "雨" || weatherText.text == "阴") {
        //     GameObject.Find("Canvas/TodayPanel/CityName").GetComponent<Text>().color = Color.white;
        //     GameObject.Find("Canvas/TodayPanel/Date").GetComponent<Text>().color = Color.white;
        //     GameObject.Find("Canvas/TodayPanel/Temperature").GetComponent<Text>().color = Color.white;
        //     GameObject.Find("Canvas/TodayPanel/Weather").GetComponent<Text>().color = Color.white;
        //     GameObject.Find("Canvas/TodayPanel/Highest").GetComponent<Text>().color = Color.white;
        //     GameObject.Find("Canvas/TodayPanel/Lowest").GetComponent<Text>().color = Color.white;
        // }
    }
}
