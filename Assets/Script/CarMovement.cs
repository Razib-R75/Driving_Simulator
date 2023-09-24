using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 20.0f;
    public float trunSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizental = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed * Vertical);

        transform.Rotate(Vector3.up, Time.deltaTime * trunSpeed * Horizental);
    }
}
