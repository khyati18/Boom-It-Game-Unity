using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continuebgmusic : MonoBehaviour
{
    void Awake()
    {	
    	DontDestroyOnLoad(transform.gameObject);
    }
}
