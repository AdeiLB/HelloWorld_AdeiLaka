using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
  
   [SerializeField]
    public float speed;
    public bool rot;

    void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        checkScale();
        if (rot)
        {
            rotate();
        }
        
    }

    private void PrintPosition()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Sea pulsado el espacio");
            Debug.Log("Posicion en X:" + this.transform.position.x);
            Debug.Log("Posicion en Y:" + this.transform.position.y);
            Debug.Log("Posicion en Z:" + this.transform.position.z);


        }
    }

    private void rotate()
    {
        this.transform.rotation *= Quaternion.Euler(0,1 * speed ,0);
    }

    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.localScale += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.transform.localScale += Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            this.transform.localScale += Vector3.back * speed;
        }
    }

    private void checkMovement()
    {
        PrintPosition();
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Button ");
            this.transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.transform.position += Vector3.back * speed;
        }

    }
}
