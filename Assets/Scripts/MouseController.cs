using UnityEngine;

public class MouseController : MonoBehaviour {
    // 鼠标在X、Y轴拖拽时，相机旋转的速度
    public float xSpeed = 2;
    public float ySpeed = 2;
    // 相机Y轴的最小、最大角度
    public float yMinLimit = -50;
    public float yMaxLimit = 50;
    // 缩放的速度
    public float zoomSpeed = 5;
    // 相机最小、最大的FOV
    public float MinFOV = 40;
    public float MaxFOV = 75;
    // 相机的FOV
    private float zoomFOV;
    // 相机X、Y轴的角度
    private float x = 0.0f;
    private float y = 0.0f;
    // 相机组件
    private Camera cam;

    void Start () {
        // // 初始化时获取相机X、Y轴的角度
        // x = transform.eulerAngles.y;
        // y = transform.eulerAngles.x;
        // 获取相机组件
        cam = this.GetComponent<Camera> ();
        // 获取相机组件中的FOV
        zoomFOV = cam.fieldOfView;
    }

    void LateUpdate () {
        // // 若点击鼠标左键，获取相机当前的X、Y轴值
        // if (Input.GetMouseButtonDown (0)) {
        //     x = transform.eulerAngles.y;
        //     y = transform.eulerAngles.x;
        // }
        // // 若按住鼠标左键 设置相机的旋转角度
        // if (Input.GetMouseButton (0)) {
        //     // Input.GetAxis("Mouse X") 获取鼠标在X轴上坐标轴的值
        //     // 相机的X轴角度 加等于 坐标轴的值乘以速度
        //     x += Input.GetAxis ("Mouse X") * xSpeed;
        //     y -= Input.GetAxis ("Mouse Y") * ySpeed;
        //     // 限制Y轴的角度
        //     y = ClampAngle (y, yMinLimit, yMaxLimit);
        //     // 鼠标在X轴上的拖拽的值 对应 相机旋转Y轴的值
        //     // 鼠标在Y轴上的拖拽的值 对应 相机旋转X轴的值
        //     // 设置相机的旋转
        //     transform.eulerAngles = new Vector3 (y, x, 0);
        // }
        // Input.GetAxis("Mouse ScrollWheel")获取鼠标滚轮的值
        // zoomFOV 减等于鼠标滚轮值乘以缩放的速度
        zoomFOV -= Input.GetAxis ("Mouse ScrollWheel") * zoomSpeed;
        // 限制zoomFOV的范围
        zoomFOV = Mathf.Clamp (zoomFOV, MinFOV, MaxFOV);
        // 相机的FOV值等于zoomFOV
        cam.fieldOfView = zoomFOV;
    }

    // 限制角度
    float ClampAngle (float angle, float min, float max) {
        if (angle > 180.0f)
            angle -= 360.0f;
        return Mathf.Clamp (angle, min, max);
    }

    public void BeginDrag () {
        // 初始化时获取相机X、Y轴的角度
        x = transform.eulerAngles.y;
        y = transform.eulerAngles.x;
    }

    public void Drag () {
        // Input.GetAxis("Mouse X") 获取鼠标在X轴上坐标轴的值
        // 相机的X轴角度 加等于 坐标轴的值乘以速度
        x += Input.GetAxis ("Mouse X") * xSpeed;
        y -= Input.GetAxis ("Mouse Y") * ySpeed;
        // 限制Y轴的角度
        y = ClampAngle (y, yMinLimit, yMaxLimit);
        // 鼠标在X轴上的拖拽的值 对应 相机旋转Y轴的值
        // 鼠标在Y轴上的拖拽的值 对应 相机旋转X轴的值
        // 设置相机的旋转
        transform.eulerAngles = new Vector3 (y, x, 0);
    }

    public void EndDrag () {

    }
    
}
