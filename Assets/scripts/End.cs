using UnityEngine;

public class End : MonoBehaviour
{
    public GameManager gamemanager;
  
    // Update is called once per frame
    public void OnTriggerEnter()
    {
        gamemanager.completeLevel();
    }
}
