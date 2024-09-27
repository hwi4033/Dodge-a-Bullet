using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletSpawer : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] float spawnPosition = 12.0f;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateBullet", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBullet()
    {
        float angle = Random.Range(0, 361);

        

        GameObject bullet = Instantiate(prefab, Vector3.forward * spawnPosition, transform.rotation, gameObject.transform);
    }
}