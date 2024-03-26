using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeatherImgController : MonoBehaviour
{
    //public Image weatherImg;

    public SpriteRenderer firstWeatherImg;

    public SpriteRenderer secondWeatherImg;

    public SpriteRenderer thirdWeatherImg;

    public SpriteRenderer forthWeatherImg;

    public SpriteRenderer fifthWeatherImg;



    // Update is called once per frame
    void Update()
    {
        TMP_Text firstWeather = GameObject.Find("first/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string first = firstWeather.text;

        if (first == "Angled Rain"){
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun angled rain");
        } else if (first == "Rain"){
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/rain");
        } else if (first == "Sun Rain"){
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun rain");
        } else if (first == "Tornado"){
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/Tornado");
        } else if (first == "Fast Wind"){
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/fast wind");
        }

        TMP_Text secondWeather = GameObject.Find("second/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string second = secondWeather.text;

        if (second == "Angled Rain"){
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun angled rain");
        } else if (second == "Rain"){
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/rain");
        } else if (second == "Sun Rain"){
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun rain");
        } else if (second == "Tornado"){
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/Tornado");
        } else if (second == "Fast Wind"){
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/fast wind");
        }

        TMP_Text thirdWeather = GameObject.Find("third/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string third = thirdWeather.text;

        if (third == "Angled Rain"){
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun angled rain");
        } else if (third == "Rain"){
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/rain");
        } else if (third == "Sun Rain"){
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun rain");
        } else if (third == "Tornado"){
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/Tornado");
        } else if (third == "Fast Wind"){
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/fast wind");
        }

        TMP_Text forthWeather = GameObject.Find("forth/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string forth = forthWeather.text;

        if (forth == "Angled Rain"){
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun angled rain");
        } else if (forth == "Rain"){
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/rain");
        } else if (forth == "Sun Rain"){
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun rain");
        } else if (forth == "Tornado"){
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/Tornado");
        } else if (forth == "Fast Wind"){
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/fast wind");
        }

        TMP_Text fifthWeather = GameObject.Find("fifth/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string fifth = fifthWeather.text;

        if (fifth == "Angled Rain"){
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun angled rain");
        } else if (fifth == "Rain"){
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/rain");
        } else if (fifth == "Sun Rain"){
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/Sun rain");
        } else if (fifth == "Tornado"){
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/Tornado");
        } else if (fifth == "Fast Wind"){
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/fast wind");
        }

        // if (weather == "晴"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        // } else if (weather == "阴"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        // } else if (weather == "雨"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        // } else if (weather == "雪"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        // } else if (weather == "多云"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        // } else if (weather == "风"){
        //     weatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        // } 
    }
}
