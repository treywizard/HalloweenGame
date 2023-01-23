using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!PhoneLight.charging)
        {
            this.GetComponent<Image>().color = new Color32(11,255,1,255);
        }
        else
        {
            this.GetComponent<Image>().color = new Color32(255,11,1,255);
        }
    }
}
