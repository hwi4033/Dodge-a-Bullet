using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PadManager : MonoBehaviour
{
    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomRotate", 3, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomRotate()
    {
        int rotate = Random.Range(0, 361);

        transform.Rotate(Vector3.up, rotate);

        Debug.Log(rotate);
    }
}