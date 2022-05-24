
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
<<<<<<< HEAD

    
    public void PlayGame()
    {
        FindObjectOfType<LoadingLevel>().LoadingLevel1(1);
        Invoke("InPlayGame", 2f);
        
    }
    
    private void InPlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

 

=======
 
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

>>>>>>> d2887623d790ef0095a9cd89083d9ab3562d8402
    public void QuitGame()
    {
        Application.Quit();
    }



}
