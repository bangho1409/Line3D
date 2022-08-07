using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject musicon;
    public GameObject musicoff;
    public AudioSource menumusic;
    public GameObject balls;
    public GameObject optional;

    
    void Start()
    {
        if(musicon.activeSelf)
        {
            menumusic.Play();
        }
    }

  
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            optional.SetActive(false);
        }
    }

    public void PlayGame()
    {
        buttonPress.Play();
        optional.SetActive(true);

    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void option1()
    {
        SceneManager.LoadScene(1);
    }

    public void option2()
    {
        SceneManager.LoadScene(3);
    }



    public void musicontrol()
    {
        if (musicon.activeSelf)
        {
            musicon.SetActive(false);
            musicoff.SetActive(true);
            menumusic.Stop();
        }
        else if (musicoff.activeSelf)
        {
            musicoff.SetActive(false);
            musicon.SetActive(true);
            menumusic.Play();
        }
    }

    public void addballl()
    {
        float y = Random.Range(276, 350);
        float x = Random.Range (-110, -130);
        float z = Random.Range(20, 35);
        Vector3 Pos = new Vector3(x, y, z);

        Instantiate(balls, Pos, transform.rotation * Quaternion.Euler(90f, 0f, -90f));
    }
}
