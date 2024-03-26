using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelRotate : MonoBehaviour
{
    public Transform modelTransform;

    private bool isRotate;
    private Vector3 startPoint;
    private Vector3 startAngel;
    [Range(0.1f, 1f)]
    public float rotateScale = 1f;
    private List<string> nameList;
    private GameObject currentModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LoadModel() {
        if (currentModel != null) {
            GameObject.Destroy (currentModel);
        }

        Text thisExhibit = GameObject.Find("Canvas/MuseumPanel/Name").GetComponent<Text>();
        string name = thisExhibit.text;
        string path = "Models/" + name;

        var model = Resources.Load<GameObject> (path);
        var go = GameObject.Instantiate<GameObject> (model);

        // go.transform.position = Vector3.zero;
        // modelTransform.eulerAngles = Vector3.zero;

        go.transform.SetParent (modelTransform, false);
        currentModel = go.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        LoadModel();
        // if (Input.GetMouseButtonDown (0) && !isRotate) {
        //     isRotate = true;
        //     startPoint = Input.mousePosition;
        //     startAngel = modelTransform.eulerAngles;
        // }
        // if (Input.GetMouseButtonUp (0)) {
        //     isRotate = false;
        // }

        // if (isRotate) {
        //     var currentPoint = Input.mousePosition;
        //     var x = startPoint.x - currentPoint.x;

        //     modelTransform.eulerAngles = startAngel + new Vector3 (0, x * rotateScale, 0);
        // }
    }

    public void BeginDrag() {
        isRotate = true;
        startPoint = Input.mousePosition;
        startAngel = modelTransform.eulerAngles;
    }

    public void Drag() {
        if (isRotate) {
            var currentPoint = Input.mousePosition;
            var x = startPoint.x - currentPoint.x;

            modelTransform.eulerAngles = startAngel + new Vector3 (0, x * rotateScale, 0);
        }
    }

    public void EndDrag() {
        isRotate = false;
    }
}
