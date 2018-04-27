using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeMusicas : MonoBehaviour {

    public AudioSource sons;
    public static GerenciadorDeMusicas inst = null;

	private void Awake()
	{
        if (inst == null)
        {
            inst = this;
        }
        else if (inst != this)
        {
            Destroy(gameObject);
        }
    }


    public void PlayAudio(AudioClip clipAudio){
        sons.clip = clipAudio;
        sons.Play();
    }
}
