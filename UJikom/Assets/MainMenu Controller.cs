using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public AudioSource audioSource;
    public Button PlayButton;
    public Button ExitButton;
       void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
        PlayButton.onClick.AddListener(ExitGame);
        PlayBGM();
        
    }

    public void PlayGame(){
        SceneManager.LoadScene("GamePlay");

        StopBGM();

    }

    public void ExitGame(){

        Application.Quit();
    }

    public void PlayBGM(){
        audioSource.Play();
    }

    public void StopBGM(){
        audioSource.Stop();

    }

    


}


