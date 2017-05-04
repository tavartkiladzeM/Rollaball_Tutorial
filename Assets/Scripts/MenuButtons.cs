using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public int score;

    public void RestartGame()


    {

        SceneManager.LoadScene(0);  

        //Debug.Log("Restarting!");

    }
      
	public void QuitGame()
    {

        Application.Quit();
    }
}
