using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class NewNPCScript : MonoBehaviour
{
    public int health = 5; //здоровье
    public float speed = 3.5f; //скорость
    public int level = 2;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        health = level;
        print("Healt count:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += Time.deltaTime * speed;
        obj.transform.position = new Vector3(newPosition.x, 0, 0);
    }
}
