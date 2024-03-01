using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangeTag : MonoBehaviour
{

    public enum tagTypes
    {
        Wheel,
        Wagon,
        Metal
    }

    private GameObject[]  ObjectList;
    [SerializeField]
    public Color WantedColor;
    public bool FindByTag;
    public string ChoseenTag;
    
    // Start is called before the first frame update
    void Start()
    {
        ObjectList = GameObject.FindGameObjectsWithTag(ChoseenTag);
    }

    // Update is called once per frame
    void Update()
    {
        ColorObjects();
    }

    private void ColorObjects()
    {
        if (FindByTag == true)
        {
            for (int i = 0; i < ObjectList.Length; i++)
            {
                ObjectList[i].GetComponent<Renderer>().material.color = WantedColor;
            }
        }
    }
}
