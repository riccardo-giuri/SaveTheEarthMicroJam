using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject MotherAsteroidPrefab;
    public Transform WaveSpawnPoint;
    public int CurrentWaveSpawned;
    public int WaveLimit;
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        WaveLimit = 3;
        CurrentWaveSpawned = 0;
        Timer = 10;

        SpawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentWaveSpawned < WaveLimit)
        {
            Timer -= Time.deltaTime;
            if (Timer < 0)
            {
                if (CurrentWaveSpawned < WaveLimit)
                {
                    SpawnWave();
                }
            }
        }
        
    }

    public void SpawnWave()
    {
        float RandomRotation = Random.Range(-70, +70);
        Quaternion rotation = Quaternion.Euler(0, 0, RandomRotation);

        Instantiate(MotherAsteroidPrefab, WaveSpawnPoint.position, rotation, this.transform);

        CurrentWaveSpawned++;

        Timer = 10;
    }

    public IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            if(Timer < 10)
            {
                Timer += Time.deltaTime;
            }
            if (Timer > 10)
            {
                yield return new WaitForSeconds(0.05f);
                if(CurrentWaveSpawned < WaveLimit)
                {
                    //SpawnWave();
                }
            }

        }
    }
}
