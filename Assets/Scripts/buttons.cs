using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    public void Quit(){
        Application.Quit();
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


}
