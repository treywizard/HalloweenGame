using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        PhoneLight.charging = !PhoneLight.charging;
        if(PhoneLight.charging)
        {
            StartCoroutine(chargeCycle());
        }
    }

    IEnumerator chargeCycle()
    {
        do
        {
            yield return new WaitForSeconds(3);
            PhoneLight.charges++;
        } while(PhoneLight.charging && PhoneLight.charges < 3);
    }
}
