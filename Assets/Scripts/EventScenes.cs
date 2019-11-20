using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScenes : MonoBehaviour
{
    public void BackMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Death()
    {
        SceneManager.LoadScene("Menu");
    }

    public string level = "Mapa_1_Gelo";

    // Use this for initialization

    void OnCollisionEnter2D(Collision2D NextScene)
    {
        if (NextScene.gameObject.tag == "Player")
            SceneManager.LoadScene(level);
    }

}
