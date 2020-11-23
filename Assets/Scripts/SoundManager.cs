using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static  AudioClip background, death, bomb;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        background = Resources.Load<AudioClip> ("background");
        death = Resources.Load<AudioClip> ("death");
        bomb = Resources.Load<AudioClip> ("bomb");
       
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void PlaySound(string clip)
    {
    	switch (clip)
    	{
    		case "death":
    			audioSrc.PlayOneShot(death);
    			break;
    		case "bomb":
    			audioSrc.PlayOneShot(bomb);
    			break;
    	}
    }
}
