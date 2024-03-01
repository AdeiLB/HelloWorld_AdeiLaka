using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInput : MonoBehaviour
{
    private Object[] allObjects;
    int cont=0;
    // Start is called before the first frame update
    void Start()
    {
        allObjects = GameObject.FindObjectsOfType(typeof(GameObject));
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();

    }

    private void Destroy()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(allObjects[cont]);
            cont++;
            Debug.Log(cont);
        }
    }
}
