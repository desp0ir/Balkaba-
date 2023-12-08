using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainrestart : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("level 1");
    }
    public void QuitGame(){
        Debug.Log("Oyundan çıkıldı!");
        Application.Quit();
    }
    public void ReturnToMainMenu(){
        SceneManager.LoadScene("son");
    }
    public void ReSTART(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}