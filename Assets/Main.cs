using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Main : MonoBehaviour
    {
        Enemy enemy;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Soy la clase 1");
            enemy = new Enemy("Bob");
            Player player = new Player("Mike");
            Debug.Log("Hello git commit");
            Debug.Log("Hello from class 105");

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("Enemy name " + enemy.name);
            Debug.Log("Enemy HP" + enemy.Life);
        }
    }
