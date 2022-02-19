using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTestDemo : MonoBehaviour
{

    private float initBgMusicvolume = 0.0f;

    private AudioSource audioSource;
    // Start is called before the first frame update
     void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 100), "播放音乐")) 
        {
            MusicMgr.GetInstance().PlayBkMusic("Black");
            MusicMgr.GetInstance().ChangeBKValue(initBgMusicvolume);
        }
        initBgMusicvolume += Time.deltaTime / 100;
        MusicMgr.GetInstance().ChangeBKValue(initBgMusicvolume);

        if (GUI.Button(new Rect(0,100,100,100),"暂停音乐"))
        {
            MusicMgr.GetInstance().PauseBKMusic();
        }

        if(GUI.Button(new Rect(0,200,100,100),"停止音乐"))
        {
            MusicMgr.GetInstance().StopBKMusic();
        }

        if(GUI.Button(new Rect(0,300,100,100),"播放音效"))
        {
            MusicMgr.GetInstance().PlaySound("Black", false,(s)=> { audioSource = s; });
        }

        if(GUI.Button(new Rect(0,400,100,100),"停止音效"))
        {
            MusicMgr.GetInstance().StopSound(audioSource);

            audioSource = null;
           
        }
    }
}
