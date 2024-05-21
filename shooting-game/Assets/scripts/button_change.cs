using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonChange : MonoBehaviour
{
    public Sprite sprite1; // Volume sprite
    public Sprite sprite2; // Mute sprite
    public Button button;
    private AudioSource[] audioSources;
    private float[] originalVolumes;
    private bool isMuted = false;

    void Start()
    {
        GameObject soundObject = GameObject.Find("sound");
        if (soundObject != null)
        {
            audioSources = new AudioSource[soundObject.transform.childCount];
            originalVolumes = new float[soundObject.transform.childCount];

            int index = 0;
            foreach (Transform child in soundObject.transform)
            {
                AudioSource audio = child.GetComponent<AudioSource>();
                if (audio != null)
                {
                    audioSources[index] = audio;
                    originalVolumes[index] = audio.volume;
                  
                    index++;
                }
            }
        }
        else
        {
            Debug.Log("GameObject named 'sound' not found!");
        }
    }

    public void ChangeButtonImage()
    {
        if (!isMuted)
        {
            button.image.sprite = sprite2; // Switch to mute sprite
            foreach (var audio in audioSources)
            {
                if (audio != null)
                {
                    audio.volume = 0;
                }
            }
            isMuted = true;
        }
        else
        {
            button.image.sprite = sprite1; // Switch to volume sprite
            for (int i = 0; i < audioSources.Length; i++)
            {
                if (audioSources[i] != null)
                {
                    audioSources[i].volume = originalVolumes[i];
                   
                }
            }
            isMuted = false;
        }
    }
}
