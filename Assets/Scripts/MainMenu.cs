using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Mapa_0_Floresta");
        
    }
   
    public void ExitGame()
    {
        Debug.Log("EXIT!");
        Application.Quit();
    }
   
}