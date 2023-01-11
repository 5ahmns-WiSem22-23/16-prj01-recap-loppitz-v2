
using UnityEngine;

public class CollectablesSpawn : MonoBehaviour
{

    public GameObject[] plates;
    public int plateCount = 1;

    public CollectablesManager collectablesManager;


    
    void Start()
    {

        for (int i = 1; i < plateCount; i--)
        {
            plates[i].SetActive(false);
        }

        for (int i = 0; i < plateCount; i--)
        {
            SpawnCollectables(plates[i]);
        }
        
    }


    void Update()
    {
        if (collectablesManager.plate1)
        {
            
            plates[1].SetActive(true);

        }

        if (collectablesManager.plate2)
        {
            
            plates[2].SetActive(true);
        }

        if (collectablesManager.plate3)
        {
            plates[3].SetActive(true);
        }
    }

    void SpawnCollectables(GameObject plate)
    {
       Vector2 spawnPoint = new Vector2(Random.Range(0, 20), Random.Range(0, 20));
        plate.transform.position = spawnPoint;
    }
}

