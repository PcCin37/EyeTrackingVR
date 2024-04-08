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

        if (first == "Sunny")
        {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_01");
        } else if (first == "Mid Rain" || first == "Heavy Rain")
        {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_02");
        } else if (first == "Light Rain")
        {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_03");
        } else if (first == "Tornado")
        {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_04");
        } else if (first == "Cloudy")
        {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_05");
        }

        TMP_Text secondWeather = GameObject.Find("second/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string second = secondWeather.text;

        if (second == "Sunny")
        {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_01");
        }
        else if (second == "Mid Rain" || second == "Heavy Rain")
        {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_02");
        }
        else if (second == "Light Rain")
        {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_03");
        }
        else if (second == "Tornado")
        {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_04");
        }
        else if (second == "Cloudy")
        {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_05");
        }


        TMP_Text thirdWeather = GameObject.Find("third/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string third = thirdWeather.text;

        if (third == "Sunny")
        {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_01");
        }
        else if (third == "Mid Rain" || third == "Heavy Rain")
        {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_02");
        }
        else if (third == "Light Rain")
        {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_03");
        }
        else if (third == "Tornado")
        {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_04");
        }
        else if (third == "Cloudy")
        {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_05");
        }


        TMP_Text forthWeather = GameObject.Find("forth/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string forth = forthWeather.text;

        if (forth == "Sunny")
        {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_01");
        }
        else if (forth == "Mid Rain" || forth == "Heavy Rain")
        {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_02");
        }
        else if (forth == "Light Rain")
        {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_03");
        }
        else if (forth == "Tornado")
        {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_04");
        }
        else if (forth == "Cloudy")
        {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_05");
        }


        TMP_Text fifthWeather = GameObject.Find("fifth/SeeItSayItLabel/Weather").GetComponent<TMP_Text>();
        string fifth = fifthWeather.text;

        if (fifth == "Sunny")
        {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_01");
        }
        else if (fifth == "Mid Rain" || fifth == "Heavy Rain")
        {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_02");
        }
        else if (fifth == "Light Rain")
        {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_03");
        }
        else if (fifth == "Tornado")
        {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_04");
        }
        else if (fifth == "Cloudy")
        {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Materials/3D Ico_05");
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

/*    private void OnEnable()
    {
        newTxtCrtl.OnTemperatureLoaded += HandleTemperatureLoaded;
    }

    private void OnDisable()
    {
        newTxtCrtl.OnTemperatureLoaded -= HandleTemperatureLoaded;
    }

    private void HandleTemperatureLoaded()
    {
        string city = newTxtCrtl.Temperature.message;
        Debug.Log($"城市: {city}");
    }*/
}
