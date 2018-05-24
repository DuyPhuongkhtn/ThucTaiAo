using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;

public class texttospeech : MonoBehaviour {

    public AudioSource _audio;
    //public InputField inputText;
	// Use this for initialization
	void Start () {
        _audio = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio());

    }
	// Update is called once per frame
	void Update () {
    }
    IEnumerator DownloadTheAudio()
    {
        //Regex rgx = new Regex("\\s+");
        //string result = rgx.Replace(inputText.text, "+");
        string url = "http://api.voicerss.org/?key=568e85cb879d4f218596eea9040095f5&hl=en-us&src=Hello";
        WWW www = new WWW(url);
        yield return www;
        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();
        Debug.Log("NOi roi");
    }
    //public void ButtonClick()
    //{
    //    StartCoroutine(DownloadTheAudio()); 
    //}

}
