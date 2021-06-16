using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float _spawnRate = 2f;
    float nextSpawn = 0.0f;
    private void Destroy(float V)
    {
        V = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + _spawnRate;
            RandX = Random.Range(-7.37f, 7.57f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(_prefab, whereToSpawn, Quaternion.identity);
        }
        if (Time.time > 5)
        {
            Destroy(_prefab);
        }
    }
}
