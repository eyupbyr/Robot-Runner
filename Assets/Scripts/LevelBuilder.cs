using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab = default;
    [SerializeField] private GameObject[] roadPartPrefabs = default;
    [SerializeField] private float roadPartLength = 200f;

    private float zSpawn;
    private List<GameObject> roadPartsInGame = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < roadPartPrefabs.Length; i++)
        {
            SpawnRoadPart(roadPartPrefabs[i]);
            zSpawn += roadPartLength;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPrefab.transform.position.z + roadPartLength*2f > zSpawn)
        {
            SpawnRoadPart(roadPartPrefabs[Random.Range(0,roadPartPrefabs.Length)]);
            zSpawn += roadPartLength;
            DeleteRoadPart();
        }
    }

    private void SpawnRoadPart(GameObject roadPart)
    {
        GameObject _roadPart = Instantiate(roadPart, transform.forward * zSpawn, transform.rotation);
        roadPartsInGame.Add(_roadPart);
    }

    private void DeleteRoadPart()
    {
        Destroy(roadPartsInGame[0]);
        roadPartsInGame.RemoveAt(0);
    }

}
