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
    public AudioSource UIButton;
       void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
        PlayButton.onClick.AddListener(ExitGame);
        PlayBGM();
        
    }

    public void PlayGame(){
        SceneManager.LoadScene("GamePlay");
        PlaySFX();
      

        StopBGM();
        

    }

    public void ExitGame(){
        PlaySFX();

        Application.Quit();
    }

    public void PlayBGM(){
        audioSource.Play();
    }

    public void PlaySFX(){
        UIButton.Play();
    }


    public void StopBGM(){
        audioSource.Stop();
    }

    


}


