using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class karaktercan : MonoBehaviour
{
    public bool dead = false;
    public int health;
    public Image[] hearts;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getDamage(int damage)
    {
        if(health - damage >= 0)
        {
            hearts[health - 1].enabled = false;
            health -= damage;
        }
    
    else {

        health = 0;
    }
   amIdead();
}
   void amIdead()
    {
        if(health == 0)
        {
            dead = true;
            SceneManager.LoadScene("son");

        }
    }
}

