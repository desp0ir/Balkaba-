using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sonmenü : MonoBehaviour
{
    public void playagain(){
  SceneManager.LoadScene("first scene");   
   }
    public void QuitGame(){
        Debug.Log("Oyundan çıkıldı!");
        Application.Quit();
    }
}