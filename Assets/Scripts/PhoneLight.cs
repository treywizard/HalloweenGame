using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class PhoneLight : MonoBehaviour
{
    public GameObject lightsource;
    public static int charges = 3;
    public static bool charging = false;
    // Start is called before the first frame update
    void Start()
    {
        charges = 3;
        lightsource.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(waiter());
            charges--;
        }
    }
    IEnumerator waiter()
    {
        if(charges >= 1 && !charging)
        {
            lightsource.SetActive(true);
            yield return new WaitForSeconds(1);
            lightsource.SetActive(false);
        }
    }
}
