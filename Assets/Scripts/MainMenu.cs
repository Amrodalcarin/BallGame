using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {
    public void Iniciar_Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void Iniciar_Level_2()
    {
        SceneManager.LoadScene(2);
    }
}
