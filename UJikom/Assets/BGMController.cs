using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    public void PlayBGM(){
        audioSource.Play();
    }

}
