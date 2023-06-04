using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy, Coin;

    IEnumerator SpawnEnemies()
    {
        while (true)
        {

            int Randomizer = Random.Range(0, 5);
            yield return new WaitForSeconds(2);
            if (Randomizer <= 2)
            {
                Instantiate(Enemy, Vector3.zero, Quaternion.identity);
            }
            else
            {
                Instantiate(Coin, Vector3.zero, Quaternion.identity);
            }
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
}
