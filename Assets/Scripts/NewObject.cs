using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class NewObject : MonoBehaviour
    {
        [SerializeField] public GameObject[] objectForSpawn;
        public List<SpawnObject> spawnObjectList;
        private int ammountObjectsYouWant = 3;
        
        
        private void Start()
        {
            spawnObjectList = new List<SpawnObject>();
            CreateObjects();


        }
        void CreateObjects()
        {
            for (int i = 0; i < ammountObjectsYouWant; i++)
            {
                Vector3 objectPosition = new Vector3(Random.Range(0, 9), 1, Random.Range(0, 9));
                SpawnObject sO = new SpawnObject(objectPosition);
                spawnObjectList.Add(sO);
            }
            SpawnGameObject();

            void SpawnGameObject()
            {
                
                List<SpawnObject> spawnedObjects = new List<SpawnObject>();
                List<SpawnObject> notSpawnedObjects = new List<SpawnObject>();

                foreach (SpawnObject item in spawnObjectList)
                {
                    
                    Vector3 spawnPosition = new Vector3(Random.Range(0, 9), 1, Random.Range(0, 9));
                    if (item.objectPosition != spawnPosition)
                    {
 
                       GameObject newball = Instantiate(objectForSpawn[Random.Range(0,5)], spawnPosition, transform.rotation * Quaternion.Euler(0f, 0f, 90f)) as GameObject; 
                        spawnedObjects.Add(item);
                    }
                    else
                    {
                        notSpawnedObjects.Add(item);
                    }
                }
                Debug.Log("Object spawned :" + spawnedObjects.Count);
                Debug.Log("Object notSpawned :" + notSpawnedObjects.Count);
            }
        }
        void Update()
        {
            if(Time.timeScale == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    CreateObjects();
                }
            }
            else if (Time.timeScale == 0)
            {

            }
            
        }

    }
    public class SpawnObject
    {
        public Vector3 objectPosition;
        public SpawnObject(Vector3 objectPosition)
        {
            this.objectPosition = objectPosition;
        }

    }
  
}