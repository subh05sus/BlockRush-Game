using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject gameOverUI;




    public void EndGame(){
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("gameOverPanel", restartDelay);
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOverPanel(){
        gameOverUI.SetActive(true);
    }


}
