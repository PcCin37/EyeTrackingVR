using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveTextController : MonoBehaviour
{
    public Text price;
    public Text productName;
    public Text productID;

    // Update is called once per frame
    void Update()
    {
        productID.text = "1";
        price.text = "¥ " + "100";
        // productName.text = "Dz.TOP coins, push card fidget spinners, adult metal, decompression titanium alloy EDC toys";
        productName.text = "Dz.TOP gold coin push card, fidget spinner, adult metal, decompression titanium alloy EDC toy";
    }
}
