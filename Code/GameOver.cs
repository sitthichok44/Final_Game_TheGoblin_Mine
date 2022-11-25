using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }



    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }





}