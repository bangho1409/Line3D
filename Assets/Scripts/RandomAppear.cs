using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomAppear : MonoBehaviour
{
    public GameObject[] img;
    
    void Start()
    {
        int prefab_num = Random.Range(0, 5);
        img[prefab_num].SetActive(true);
    }

    public void imageappear()
    {
        int prefab_num = Random.Range(0, 5);
        img[prefab_num].SetActive(true);        
    }

    IEnumerator imagess()
    {
        int prefab_num = Random.Range(0, 5);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        img[prefab_num].SetActive(false);
        yield return new WaitForSeconds(1);
        imageappear();
    }


   
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                int prefab_num = Random.Range(0, 5);
                img[prefab_num].SetActive(false);
                StartCoroutine(imagess());
            }
        }
        else if (Time.timeScale == 0)
        {

        }
        
    }
}
