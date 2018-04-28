using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventAnim : MonoBehaviour {


    public AudioSource asrc;

    void TocaMsg(){
        asrc.Play();
        Debug.Log("Evento");
    }

}
