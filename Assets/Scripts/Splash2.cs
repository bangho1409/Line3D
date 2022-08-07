using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash2 : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(4);
    }
}
