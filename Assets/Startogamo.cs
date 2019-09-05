using UnityEngine;
using UnityEngine.SceneManagement;

public class Startogamo : MonoBehaviour
{
public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
