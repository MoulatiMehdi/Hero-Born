
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MusicClass: MonoBehaviour
{
    private AudioSource _audioSource;
    private GameObject [] other;
    private bool NotFirst;

    
    private void Awake(){
            other=GameObject.FindGameObjectsWithTag("Music");

            foreach(GameObject oneOther in other){
                if(oneOther.scene.buildIndex==-1){
                   
                    NotFirst=true;
                }
            }
            if(NotFirst==true && gameObject!=null){
                Destroy(gameObject);
            }
            DontDestroyOnLoad(transform.gameObject);
            _audioSource=GetComponent<AudioSource>();
    }

    
    public void PlayMusic(){
        if(_audioSource.isPlaying||PlayerPrefs.GetInt("Music")==0) return;
        _audioSource.Play();
      
    }
    public void StopMusic(){
        _audioSource.Stop();
    }
}