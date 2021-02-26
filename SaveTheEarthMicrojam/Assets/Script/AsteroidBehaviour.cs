using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    public GameObject littleAsteroidPrefab;
    public float AsteroidSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * AsteroidSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Earth"))
        {
            Time.timeScale = 0;
        }

        if (collision.CompareTag("Bullet"))
        {
            for (int asteroid = 0; asteroid < 4; asteroid++)
            {
                Instantiate(littleAsteroidPrefab, this.transform.position, Quaternion.identity);
            }

            Destroy(this.gameObject);
        }
    }
}
