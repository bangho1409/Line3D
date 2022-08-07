using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] public GameObject[] prefeb;

    [SerializeField] public bool random;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnballRandom());


    }


    public void OnSpawnAPrefab()
    {
        if (random)

        {

            float y = 1;
            float x = Random.Range(0, 9);
            float z = Random.Range(0, 9);

            Vector3 Pos = new Vector3(x, y, z);


            int prefeb_num = Random.Range(0, 5);


            GameObject NewBall = Instantiate(prefeb[prefeb_num], Pos, transform.rotation * Quaternion.Euler(0f, 0f, 90f)) as GameObject;
        }

    }

    IEnumerator SpawnballRandom()
    {
        yield return new WaitForSeconds(1);
        OnSpawnAPrefab();
        OnSpawnAPrefab();
        OnSpawnAPrefab();
    }

    IEnumerator SpawnballRandom2()
    {
        yield return new WaitForSeconds(1);
        OnSpawnAPrefab();
        OnSpawnAPrefab();
        OnSpawnAPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(SpawnballRandom2());
        }
        
    }
}
