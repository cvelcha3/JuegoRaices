using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    /*public void Menu(string SampleScene)
      {
          print("Menu" + SampleScene);
          SceneManager.LoadScene(SampleScene
      }*/
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Salir()
    {
        Debug.Log("QUITTING GAME");
        Application.Quit();
    }
}
