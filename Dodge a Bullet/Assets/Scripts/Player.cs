using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] float speed = 10.0f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        OnMove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        if (direction !=  Vector3.zero)
        {
            rigidBody.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}