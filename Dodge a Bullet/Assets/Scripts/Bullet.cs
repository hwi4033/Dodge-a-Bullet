using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject target;

    [SerializeField] float speed = 10.0f;

    private void Awake()
    {
        // player = GetComponent<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime; 
    }
}
