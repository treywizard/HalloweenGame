using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public bool door = false;
    Vector3 pos = Vector3.one;
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
        if(door == false)
        {
            transform.Rotate(Vector3.forward * 90f);
            door = true;
            //transform.position = new Vector3(pos.x + 2.0f, pos.y + 2.0f, pos.z + 2.0f);
        }
        else
        {
            transform.Rotate(-Vector3.forward * 90f);
            door = false;
            //transform.position = new Vector3(pos.x - 2.0f, pos.y - 2.0f, pos.z - 2.0f);
        }
    }
}
