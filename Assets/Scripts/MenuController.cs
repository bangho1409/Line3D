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

    // Start is called before the first frame update
    void Start()
    {
        if(musicon.activeSelf)
        {
            menumusic.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        buttonPress.Play(); 
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
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
        float y = Random.Range(276, 300);
        float x = Random.Range(-110, -140);
        float z = Random.Range(0, -2);
        Vector3 Pos = new Vector3(x, y, z);

        Instantiate(balls, Pos, transform.rotation * Quaternion.Euler(90f, 0f, -90f));
    }
}
