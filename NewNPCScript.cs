using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class NewNPCScript : MonoBehaviour
{
    public int health = 5; //здоровье
    public float speed = 3.5f; //скорость
    public int level = 2; 
    public GameObject obj; //обращение к объекту

    // Start is called before the first frame update
    void Start()
    {
        health = level; //обновление здоровья
        print("Healt count:" + health); //вывод здоровья
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; //получение следующей позиции
        newPosition.x += Time.deltaTime * speed; //вычисление позиции
        obj.transform.position = new Vector3(newPosition.x, 0, 0); //обновление позиции NPC
    }
}
