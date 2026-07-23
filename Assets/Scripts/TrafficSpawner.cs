using UnityEngine;

public class Traffic : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;

    [Tooltip("Inital delay before the first vehicle spawns")]
    public float startDelay = 0f;

    [Header("Spawn Delay (X = Min, Y = Max)")]
    public Vector2 spawnDelayRange = new Vector2(1f, 5f);
    private float timer = 0f;
    private float currentInterval;


    void Start()
    {
        currentInterval = startDelay;
    } 

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= currentInterval)
        {
            SpawnVehicle();
            timer = 0f;

            SetNextSpawnInterval();
        }
    }

    void SetNextSpawnInterval()
    {
        currentInterval = Random.Range(spawnDelayRange.x, spawnDelayRange.y);
    }

    void SpawnVehicle()
    {
        if (vehiclePrefabs == null || vehiclePrefabs.Length == 0) return;

        int randomIndex = Random.Range(0, vehiclePrefabs.Length);
        
        if (vehiclePrefabs[randomIndex] != null)
        {
            // 1. Instantiate the object
            GameObject newVehicle = Instantiate(vehiclePrefabs[randomIndex], transform.position, transform.rotation);
            
            // 2. Force it to be active in case the prefab asset is disabled
            newVehicle.SetActive(true);
        }
    }
}
