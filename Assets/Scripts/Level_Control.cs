using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Control : MonoBehaviour
{

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
    
}
