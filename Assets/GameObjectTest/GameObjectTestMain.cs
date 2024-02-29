using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTestMain : MonoBehaviour
{
    [SerializeField]
    private GameObject otherGameObject;
    public Vector3 pos;
   
    // Start is called before the first frame update
    void Start()
    {
        otherGameObject = GameObject.Find("Cube");
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = otherGameObject.transform.position;
        Debug.Log("la posicion del objeto es " + pos);

    }
}
