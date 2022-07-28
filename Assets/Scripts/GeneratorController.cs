using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float delaySpawn = 1f;
    public float intervalSpawn = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", delaySpawn, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBullet(){
        Instantiate(bulletPrefab, transform);
    }
}
