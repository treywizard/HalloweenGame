using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.color = Color.white;
        txt.text = HouseAlive.timeMinute.ToString("00") + ":" + HouseAlive.timeSecond.ToString("00");
    }
}
