
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcompleted : MonoBehaviour
{
    public void Loadnextlevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
