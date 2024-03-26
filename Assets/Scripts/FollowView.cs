using UnityEngine;
using System.Collections;

// 相机一直拍摄主角的后背，需要绑定target
public class FollowView : MonoBehaviour
{

    public Transform target;

    public float distanceUp = 3f;
    public float distanceAway = 20f;
    // 平滑移动
    public float smooth = 2f;
    public float camDepthSmooth = 5f;

    void Update()
    {
        // 鼠标轴控制相机的远近
        if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) 
        || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth * Time.deltaTime;
        }
    }

    void LateUpdate()
    {
        // 相机的位置
        Vector3 disPos = target.position + Vector3.up * distanceUp - target.forward * distanceAway;
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        // 相机的角度
        transform.LookAt(target.position);
    }
}

