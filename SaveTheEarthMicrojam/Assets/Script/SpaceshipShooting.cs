using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float RandomRotation = Random.Range(-80, +80);
            Quaternion rotation = Quaternion.Euler(0, 0, RandomRotation);

            Instantiate(BulletPrefab, spawnPoint.position, rotation);
        }
    }
}
