using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryCharge : MonoBehaviour
{
    public Image charge;
    public Sprite full;
    public Sprite almostfull;
    public Sprite almostdead;
    public Sprite dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(PhoneLight.charges)
        {
            case 3:
                charge.sprite = full;
                break;
            case 2:
                charge.sprite = almostfull;
                break;
            case 1:
                charge.sprite = almostdead;
                break;
            case 0:
                charge.sprite = dead;
                break;
        }
    }
}
