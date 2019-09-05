using UnityEngine;

public class Collision : MonoBehaviour
{
    public movement MoveMent;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            MoveMent.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
