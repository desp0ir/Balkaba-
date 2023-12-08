using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutoriaisign : MonoBehaviour
{
    public GameObject tutorialText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       tutorialText.SetActive(true);
    }
     void OnTriggerExit2D(Collider2D collision)
    {
       tutorialText.SetActive(false);
    }
    void update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
   }
}
