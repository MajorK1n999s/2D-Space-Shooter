using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBomb_Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform PlayerTransform;

    public GameObject astroidPrefab;
    public GameObject coinPrefab;
    public GameObject blastPrefab;

    public static BulletBomb_Spawner Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BulletSpawner", 0.5f, 0.3f);
        InvokeRepeating("AstroidSpawner", 1f, 2f);
        InvokeRepeating("CoinSpawner", 1.5f, 5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BulletSpawner()
    {
       Instantiate(bulletPrefab, PlayerTransform.position, Quaternion.identity);
    }

    void AstroidSpawner()
    {
        Instantiate(astroidPrefab, new Vector3(Random.Range(-1.8f, 1.8f),6.5f,0f), Quaternion.identity);
    }
   
    void CoinSpawner()
    {
        Instantiate(coinPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6.5f, 0f), Quaternion.identity);
    }
}
