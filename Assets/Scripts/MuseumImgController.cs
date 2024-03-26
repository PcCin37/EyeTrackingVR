using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuseumImgController : MonoBehaviour
{
    public Image exhibitImg;

    // 原始尺寸
    private Vector2 olSize;
    // 缩放后的尺寸
    private Vector2 size;
    // 原始尺寸宽高比
    private float al;
    private RectTransform self;       
    internal float ReferHeight;
    internal float ReferWidth;
    private Vector2 parentSize;      
    public float FrameThickness;

    // Update is called once per frame
    void Update()
    {
        Text thisExhibit = GameObject.Find("Canvas/MuseumPanel/Name").GetComponent<Text>();
        string thisExhibitStr = thisExhibit.text;

        exhibitImg.sprite = Resources.Load<Sprite>("Museum/" + thisExhibitStr);
        SetWidthHight();
    }

    // 设置宽高
    public void SetWidthHight()
    {
        self = GetComponent<RectTransform>();
        parentSize = self.GetComponent<RectTransform>().rect.size;        
        ReferHeight = parentSize.y - FrameThickness;
        ReferWidth = parentSize.x - FrameThickness;
        self.GetComponent<Image>().SetNativeSize();
        olSize = self.sizeDelta;      
        al = olSize.x / olSize.y;        
        if (olSize.x < olSize.y)
        	size = new Vector2(ReferHeight * al, ReferHeight); 
        else
        	size = new Vector2(ReferWidth, ReferWidth / al);
       
        self.sizeDelta = size;      
    }
}