using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public GameObject bulletrefab;
    public float bulletspeed;
    public Transform bulletSpawnpoint;
    public Transform[] spawnPosition;
    public GameObject enemy;

    public static GameplayManager gamePlayManager;

    private void Awake()
    {

        if (gamePlayManager == null)
        {
            gamePlayManager = this;
        }
    }


    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("spawnEnemy", 0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnBullet()
    {
        // Spawn Bullet towards Up
        var bullet = Instantiate(bulletrefab, bulletSpawnpoint.position, bulletSpawnpoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnpoint.forward * bulletspeed;
    }
    void spawnEnemy()
    {
        // Instantiate distraction in  random range of the array in the location of array Transform
        Instantiate(enemy, spawnPosition[Random.Range(0, spawnPosition.Length)]);
    }
}
