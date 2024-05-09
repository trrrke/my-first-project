using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SuondBord : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AudioClip clip = audioSource.clip;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MediaPlayer();
        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            audioSource.Play();
         }
    }
    private void MediaPlayer() {
       if (Input.GetKeyDown(KeyCode.Alpha1)) { 

            audioSource.Play();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)){
                audioSource.Stop();

            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
                audioSource.Pause();
            {
            }
        }
}
        