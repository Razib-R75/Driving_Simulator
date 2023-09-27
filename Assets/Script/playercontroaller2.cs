using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroaller2 : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    [SerializeField] float Xrange = 10.0f;
    [SerializeField] GameObject PrefabPizza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }
        if( transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }

        float Horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Horizontalinput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PrefabPizza,transform.position, PrefabPizza.transform.rotation);
        }
    }

}
