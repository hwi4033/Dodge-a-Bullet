using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float distance = 1.0f;

    [SerializeField] float speed = 10.0f;

    void Awake()
    {
        target = GameObject.Find("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        GroundCheck();
        // TransformDirection : 로컬공간에서의 벡터를  월드공간에서의 벡터로 바꿔주는 함수
        transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
    }

    public void GroundCheck()
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, Vector3.down, out raycastHit, distance))
        {
            if (raycastHit.collider.CompareTag("Ground"))
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit(); // 어플리케이션 종료
#endif
        }
    }
}
