using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HouseAlive : MonoBehaviour
{
    public static float timeSecond = 0.0f;
    public static float timeMinute = 0.0f;
    public static int candy = 5;
    public static float countDown = 15.0f;
    public static float kidCount = 20.0f;
    public static int monsterCount = 1;
    public static int random;
    public GameObject[] monsters = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        var allDescendents = GetComponentsInChildren<MeshRenderer>();
        foreach (var t in allDescendents) {
            t.gameObject.AddComponent<BoxCollider>();
        }
        monsters = new GameObject[3];
        monsters[0] = GameObject.Find("Monster 1");
        monsters[1] = GameObject.Find("Monster 2");
        monsters[2] = GameObject.Find("Monster 3");
    }

    // Update is called once per frame
    void Update()
    {
        timeSecond += Time.deltaTime;
        countDown -= Time.deltaTime;
        kidCount -= Time.deltaTime;
        if(timeSecond >= 59.0f)
        {
            timeSecond = 0.0f;
            timeMinute++;
        }
        if(countDown < 0)
        {
            monsterCycle();
            countDown = 15.0f;
        }
        if(kidCount < 0)
        {
            kidCycle();
            kidCount = 20.0f;
        }
    }

    void monsterCycle()
    {
        Debug.Log("MonsterCount: " + monsterCount);
        for(int i = 0; i < monsterCount; i++)
        {
        monsters[i].GetComponent<Monster>().alive = true;
        random = Convert.ToInt32(Math.Round(UnityEngine.Random.Range(0.51f, 10.49f)));
        switch(random)
        {
            case 1:
                monsters[i].transform.position = new Vector3(-14.24107f, 25.70668f, 26.96601f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -180f, 0f);
                break;
            case 2:
                monsters[i].transform.position = new Vector3(-20.2f, 25.70668f, 26.96601f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -180f, 0f);
                break;
            case 3:
                monsters[i].transform.position = new Vector3(-4.2f, 25.70668f, 30.06f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -180f, 0f);
                break;
            case 4:
                monsters[i].transform.position = new Vector3(-12.93f, 25.70668f, 13.84f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -180f, 0f);
                break;
            case 5:
                monsters[i].transform.position = new Vector3(-6.66f, 25.70668f, 17.13f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -90f, 0f);
                break;
            case 6:
                monsters[i].transform.position = new Vector3(-16.7f, 25.70668f, 16.74f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -90f, 0f);
                break;
            case 7:
                monsters[i].transform.position = new Vector3(-16.7f, 25.70668f, 40.59f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -90f, 0f);
                break;
            case 8:
                monsters[i].transform.position = new Vector3(-8.59f, 25.70668f, 38.97f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -90f, 0f);
                break;
            case 9:
                monsters[i].transform.position = new Vector3(9.81f, 25.70668f, 41.3f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -90f, 0f);
                break;
            case 10:
                monsters[i].transform.position = new Vector3(-12.93f, 25.70668f, 13.84f);
                monsters[i].transform.eulerAngles  = new Vector3(0f, -180f, 0f);
                break;
        }
        monsters[i].GetComponent<AudioSource>().Play();
        }
    }
    void kidCycle()
    {
        GetComponent<AudioSource>().Play();
        GameObject.Find("Kid").transform.position = new Vector3(-12.98091f, 29.156f, 9.977699f);
        GameObject.Find("Kid").GetComponent<kid>().stillHere = true;
        random = Convert.ToInt32(Math.Round(UnityEngine.Random.Range(0.51f, 10.49f)));
        switch(random)
        {
            case 1:
                GameObject.Find("Candy Box").transform.position = new Vector3(2.43f, 28.52f, 21.9f);
                break;
            case 2:
                GameObject.Find("Candy Box").transform.position = new Vector3(10.63f, 27.25f, 35.7f);
                break;
            case 3:
                GameObject.Find("Candy Box").transform.position = new Vector3(17.9f, 27.25f, 33.47f);
                break;
            case 4:
                GameObject.Find("Candy Box").transform.position = new Vector3(17.9f, 27.25f, 44.44f);
                break;
            case 5:
                GameObject.Find("Candy Box").transform.position = new Vector3(10.74f, 29.08f, 44.44f);
                break;
            case 6:
                GameObject.Find("Candy Box").transform.position = new Vector3(-7.63f, 29.92f, 22.45f);
                break;
            case 7:
                GameObject.Find("Candy Box").transform.position = new Vector3(-2.707f, 21.913f, 20.397f);
                break;
            case 8:
                GameObject.Find("Candy Box").transform.position = new Vector3(3.09f, 19.48f, 16.19f);
                break;
            case 9:
                GameObject.Find("Candy Box").transform.position = new Vector3(-21.68f, 29.462f, 15.073f);
                break;
            case 10:
                GameObject.Find("Candy Box").transform.position = new Vector3(-22.9f, 27.44f, 30.65f);
                break;
        }
    }
}   
