using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadd : MonoBehaviour
{
    public int health;
    public int damage;

    bool playercollider = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !playercollider)
        {
            playercollider = true;
        other.GetComponent<karaktercan>().getDamage(damage);
        }
    }
     void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player" )
        {
            playercollider = false;
        }
    }
}
