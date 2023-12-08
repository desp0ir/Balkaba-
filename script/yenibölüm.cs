using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenibölüm : MonoBehaviour
{

  private void OnTriggerEnter2D(Collider2D nesne)
    {
       if (nesne.tag == "mezar")
       {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    }
}