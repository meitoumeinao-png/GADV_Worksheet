using System.Collections;
using System.Collections.Generic;
using UnityEngine;
{ 
public class Main : MonoBehaviour
{
    void Start()
    {
        Player player = new Player(10);
        player.TakeDamage(3);
    }
}

}
