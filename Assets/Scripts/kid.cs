using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kid : MonoBehaviour
{
    Vector3 pos = Vector3.one;
    public bool stillHere = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HouseAlive.kidCount <= 0.018f && stillHere == true && HouseAlive.monsterCount < 3)
        {
            HouseAlive.monsterCount++;
            /*if(HouseAlive.monsterCount == 2)
            {
                GameObject.Find("Window").transform.position = new Vector3(2.138031f, 40.76168f, 10.63875f);
                GameObject.Find("Broken Window").transform.position = new Vector3(1.046496f, 30.42517f, 14.12566f);
            }
            else
            {

            }*/
        } 
    }
    void OnMouseUp()
    {
        if(HouseAlive.candy >= 1)
        {
            HouseAlive.candy--;
            //gameObject.SetActive(false);
            transform.position = new Vector3(-12.98091f, 26.303f, 9.977699f);
            stillHere = false;
        }
    }
}
