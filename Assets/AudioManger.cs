using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManger : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    [SerializeField] public AudioClip Playerjump;
    void Start()
    {
        UnityEngine.AudioClip Playerjump = audioSource.clip;
    }

    public void PlayPlayerjump()
    {
        audioSource.PlayOneShot(Playerjump);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
