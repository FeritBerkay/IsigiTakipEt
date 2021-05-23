using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelMenu : MonoBehaviour
{
    
    public void level1play()
    {
        SceneManager.LoadScene(2);
    }
    public void level2play()
    {
        SceneManager.LoadScene(3);
    }
    public void level3play()
    {
        SceneManager.LoadScene(4);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
