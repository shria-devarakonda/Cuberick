 using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
    public Text displayText;

    public void DisplayText()
    {
        displayText.text = "Secret message.";
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    
}
