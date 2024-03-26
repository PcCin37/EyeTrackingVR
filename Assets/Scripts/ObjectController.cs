using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // 定义水平参数以及垂直参数
    public float horizontalinput;
    public float Verticalinput;
    // 声明一个速度参数
    float speed=5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        // AD方向控制
        Verticalinput = Input.GetAxis("Vertical");
        // WS方向控制
        
        if (horizontalinput!=0 && Verticalinput!=0)
        {
            horizontalinput = horizontalinput * 0.6f;
            Verticalinput = Verticalinput * 0.6f;
        }
        this.transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
        // 控制该物体向侧方移动
        this.transform.Translate(Vector3.forward * Verticalinput * Time.deltaTime * speed);
        // 控制该物体向前后移动
    }
}
