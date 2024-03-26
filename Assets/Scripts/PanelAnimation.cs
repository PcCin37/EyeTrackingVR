using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimation : MonoBehaviour
{
    public AnimationCurve showCurve;
    public AnimationCurve hideCurve;
    public float animationSpeed;
    public GameObject panel;
    public GameObject panel2;
    public bool aShow = false;

    IEnumerator ShowPanel(GameObject gameObject)
    {
        float time = 0;
        while (time <= 1)
        {
            gameObject.transform.localScale = Vector3.one * showCurve.Evaluate(time);
            time += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }

    IEnumerator HidePanel(GameObject gameObject)
    {
        float time = 0;
        while (time <= 1)
        {
            gameObject.transform.localScale = Vector3.one * hideCurve.Evaluate(time);
            time += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }

    void Start()
    {
        panel.transform.localScale = Vector3.zero;
        panel2.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && aShow == false) {
            StartCoroutine(ShowPanel(panel));
            aShow = true;
        }
        else if (Input.GetKeyDown("escape") && aShow == true) {
            StartCoroutine(HidePanel(panel));
        }
        else if (Input.GetKeyDown("space") && aShow == true) {
            StartCoroutine(ShowPanel(panel2));
            aShow = false;
        }
        else if (Input.GetKeyDown("escape") && aShow == false) {
            StartCoroutine(HidePanel(panel2));
        }
    }

}
