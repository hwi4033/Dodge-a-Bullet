using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchingPad : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] float parentRotate;

    // Start is called before the first frame update
    void Start()
    {
        parentRotate = transform.parent.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.rotation.y != parentRotate)
        {
            CreateBullet();

            parentRotate = transform.parent.rotation.y;
        }
    }

    void CreateBullet()
    {
        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
    }
}