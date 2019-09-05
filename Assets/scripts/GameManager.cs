
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHathEnd = false;
    public float restartdelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if(gameHathEnd == false)
        {
            gameHathEnd = true;
            Debug.Log("game over");
            Invoke("Restart", restartdelay);
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
     public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }
        
    
}
