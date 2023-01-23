using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
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
        transform.position = new Vector3(-12.98091f, 66.303f, 9.977699f);
        HouseAlive.candy++; 
    }
}
