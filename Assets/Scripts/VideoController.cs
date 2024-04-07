using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController : MonoBehaviour
{
    private RawImage rawImage;
    private VideoPlayer videoPlayer;
    private string videoFileName;

    // Start is called before the first frame update
    void Start()
    {
        rawImage = GetComponent<RawImage>();
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        Text thisProduct = GameObject.Find("Canvas/LivePanel/ID").GetComponent<Text>();
        string thisProductStr = thisProduct.text;

        if (thisProductStr == "1") {
            videoFileName = "1";
        } else if (thisProductStr == "2") {
            videoFileName = "2";
        }

        LoadAndPlayVideoClip();
        rawImage.texture = videoPlayer.texture;
    }

    void LoadAndPlayVideoClip()
    {
        string videoPath = "LiveVideo/" + videoFileName; // Path relative to Resources folder
        VideoClip loadedClip = Resources.Load<VideoClip>(videoPath);

        if (loadedClip != null)
        {
            videoPlayer.clip = loadedClip;
            videoPlayer.Play();
        }
        // else
        // {
        //     Debug.LogError("Failed to load VideoClip.");
        // }
    }

}