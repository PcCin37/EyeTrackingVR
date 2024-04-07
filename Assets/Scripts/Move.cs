using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // 移动速度
    public float movespeed = 5f;
    // 转身速度
    public float turnspeed = 1f;
    
    private float horizontal;
    private float vertical;
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //前后移动
        transform.position += vertical * transform.forward * Time.deltaTime * movespeed;
        //左右转身
        transform.eulerAngles += horizontal * Vector3.up * turnspeed;
    }

}
