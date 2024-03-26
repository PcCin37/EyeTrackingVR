using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeatherBackground : MonoBehaviour
{
    public Image weatherImg;

    // Update is called once per frame
    void Update()
    {
        Text thisWeather = GameObject.Find("Canvas/TodayPanel/Weather").GetComponent<Text>();
        string weather = thisWeather.text;

        if (weather == "Sunny"){
            weatherImg.sprite = Resources.Load<Sprite>("Weather/sunnybackground");
        } else if (weather == "Cloudy"){
            weatherImg.sprite = Resources.Load<Sprite>("Weather/cloudybackground");
        } else if (weather == "Rainy"){
            weatherImg.sprite = Resources.Load<Sprite>("Weather/rainybackground");
        } else if (weather == "Snowy"){
            weatherImg.sprite = Resources.Load<Sprite>("Weather/snowybackground");
        } else if (weather == "Partly Cloudy"){
            weatherImg.sprite = Resources.Load<Sprite>("Weather/partlycloudybackground");
        } else if (weather == "Windy"){
            weatherImg.sprite = Resources.Load<Sprite>("Weather/windybackground");
        }

        // if (weather == "晴"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/sunnybackground");
        // } else if (weather == "阴"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/cloudybackground");
        // } else if (weather == "雨"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/rainybackground");
        // } else if (weather == "雪"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/snowybackground");
        // } else if (weather == "多云"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/partlycloudybackground");
        // } else if (weather == "风"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/windybackground");
        // }
    }
}
