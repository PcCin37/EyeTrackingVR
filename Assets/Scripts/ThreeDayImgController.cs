using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeDayImgController : MonoBehaviour
{
    public Image firstWeatherImg;
    public Image secondWeatherImg;
    public Image thirdWeatherImg;
    public Image forthWeatherImg;
    public Image fifthWeatherImg;

    // Update is called once per frame
    void Update()
    {
        Text firstWeather = GameObject.Find("Canvas/ThreeDayPanel/1stWeather").GetComponent<Text>();
        string firstWeatherStr = firstWeather.text;

        Text secondWeather = GameObject.Find("Canvas/ThreeDayPanel/2ndWeather").GetComponent<Text>();
        string secondWeatherStr = secondWeather.text;

        Text thirdWeather = GameObject.Find("Canvas/ThreeDayPanel/3rdWeather").GetComponent<Text>();
        string thirdWeatherStr = thirdWeather.text;

        Text forthWeather = GameObject.Find("Canvas/ThreeDayPanel/4thWeather").GetComponent<Text>();
        string forthWeatherStr = forthWeather.text;

        Text fifthWeather = GameObject.Find("Canvas/ThreeDayPanel/5thWeather").GetComponent<Text>();
        string fifthWeatherStr = fifthWeather.text;

        if (firstWeatherStr == "Sunny") {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        } else if (firstWeatherStr == "Cloudy") {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        } else if (firstWeatherStr == "Rainy") {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        } else if (firstWeatherStr == "Snowy") {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        } else if (firstWeatherStr == "Partly Cloudy") {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        } else if (firstWeatherStr == "Windy") {
            firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        }

        if (secondWeatherStr == "Sunny") {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        } else if (secondWeatherStr == "Cloudy") {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        } else if (secondWeatherStr == "Rainy") {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        } else if (secondWeatherStr == "Snowy") {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        } else if (secondWeatherStr == "Partly Cloudy") {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        } else if (secondWeatherStr == "Windy") {
            secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        }

        if (thirdWeatherStr == "Sunny") {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        } else if (thirdWeatherStr == "Cloudy") {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        } else if (thirdWeatherStr == "Rainy") {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        } else if (thirdWeatherStr == "Snowy") {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        } else if (thirdWeatherStr == "Partly Cloudy") {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        } else if (thirdWeatherStr == "Windy") {
            thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        }

        if (forthWeatherStr == "Sunny") {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        } else if (forthWeatherStr == "Cloudy") {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        } else if (forthWeatherStr == "Rainy") {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        } else if (forthWeatherStr == "Snowy") {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        } else if (forthWeatherStr == "Partly Cloudy") {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        } else if (forthWeatherStr == "Windy") {
            forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        }

        if (fifthWeatherStr == "Sunny") {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        } else if (fifthWeatherStr == "Cloudy") {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        } else if (fifthWeatherStr == "Rainy") {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        } else if (fifthWeatherStr == "Snowy") {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        } else if (fifthWeatherStr == "Partly Cloudy") {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        } else if (fifthWeatherStr == "Windy") {
            fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        }


        // if (firstWeatherStr == "晴") {
        //     firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        // } else if (firstWeatherStr == "阴") {
        //     firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        // } else if (firstWeatherStr == "雨") {
        //     firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        // } else if (firstWeatherStr == "雪") {
        //     firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        // } else if (firstWeatherStr == "多云") {
        //     firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        // } else if (firstWeatherStr == "风") {
        //     firstWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        // }

        // if (secondWeatherStr == "晴") {
        //     secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        // } else if (secondWeatherStr == "阴") {
        //     secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        // } else if (secondWeatherStr == "雨") {
        //     secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        // } else if (secondWeatherStr == "雪") {
        //     secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        // } else if (secondWeatherStr == "多云") {
        //     secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        // } else if (secondWeatherStr == "风") {
        //     secondWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        // }

        // if (thirdWeatherStr == "晴") {
        //     thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        // } else if (thirdWeatherStr == "阴") {
        //     thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        // } else if (thirdWeatherStr == "雨") {
        //     thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        // } else if (thirdWeatherStr == "雪") {
        //     thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        // } else if (thirdWeatherStr == "多云") {
        //     thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        // } else if (thirdWeatherStr == "风") {
        //     thirdWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        // }

        // if (forthWeatherStr == "晴") {
        //     forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        // } else if (forthWeatherStr == "阴") {
        //     forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        // } else if (forthWeatherStr == "雨") {
        //     forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        // } else if (forthWeatherStr == "雪") {
        //     forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        // } else if (forthWeatherStr == "多云") {
        //     forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        // } else if (forthWeatherStr == "风") {
        //     forthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        // }

        // if (fifthWeatherStr == "晴") {
        //     fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Sunny");
        // } else if (fifthWeatherStr == "阴") {
        //     fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Cloudy");
        // } else if (fifthWeatherStr == "雨") {
        //     fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Rainy");
        // } else if (fifthWeatherStr == "雪") {
        //     fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Snowy");
        // } else if (fifthWeatherStr == "多云") {
        //     fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Partly Cloudy");
        // } else if (fifthWeatherStr == "风") {
        //     fifthWeatherImg.sprite = Resources.Load<Sprite>("Weather/Windy");
        // }
    }
}
