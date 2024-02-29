using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
 {
    public Player(string name) : base(name)
    {
       
    }

    public override void takeDamage(int damage)
    {
        base.takeDamage(0);
    }

}

public class Enemy : Character
 {
    
    public Enemy(string name) : base(name)
    {
       
    }
    public override void takeDamage(int damage)
    {
        base.takeDamage(damage);
    }

}


