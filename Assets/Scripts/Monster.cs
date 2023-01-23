using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class Monster : MonoBehaviour
{
    Vector3 pos = Vector3.one;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        alive = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(alive == true && HouseAlive.countDown < 1.0f)
         {
             SceneManager.LoadScene("Game Over");
         }
    }
    private void OnMouseOver() 
    {
        pos = Vector3.one;
        //Debug.Log("Hello: " + gameObject.name);
        if (Input.GetKeyDown(KeyCode.F) && PhoneLight.charges > 0 && !PhoneLight.charging) 
        {
            //Debug.Log("Hello: " + gameObject.name);
            GameObject.Find("Body").GetComponent<AudioSource>().Play();
            transform.position = new Vector3(pos.x, pos.y + 100.0f, pos.z);
            alive = false;
        }
    }
}
