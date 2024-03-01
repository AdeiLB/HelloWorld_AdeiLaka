using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToCange;
    private Renderer renderObjetoCambiar;
    private Color colorObjeto;
    // Start is called before the first frame update
    void Start()
    {
        objectToCange = GameObject.Find("Sphere");
        renderObjetoCambiar = objectToCange.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * intento de cambio de color por actualizacion
        float num = 0;

        if(num == 1)
        {
            num = 0;
        }

        colorObjeto = new Color(num, num, num);
        num = (float)(num + 0.01);
        */
        renderObjetoCambiar.material.color = Color.red;
        

    }
}
