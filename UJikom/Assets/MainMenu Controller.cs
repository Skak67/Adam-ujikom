using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button PlayButton;
    public Button ExitButton;
       void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
        PlayButton.onClick.AddListener(ExitGame);
        
    }

    public void PlayGame(){
        SceneManager.LoadScene("GamePlay");
    }

    public void ExitGame(){
        Application.Quit();
    }


}


