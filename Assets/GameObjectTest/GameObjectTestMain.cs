using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTestMain : MonoBehaviour
{
    Vector3 pos;
    private Transform transformation;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = GameObject.Find("Cube").transform.position;
        Debug.Log("la posicion X de el objeto es " + pos.x);

    }
}
