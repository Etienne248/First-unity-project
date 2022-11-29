using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    //public int my_Int;
    public GameObject obj;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(obj.GetComponent<Transform>().position);
        //obj = transform.Find("Plane").gameObject;
        _rb = obj.GetComponent<Rigidbody>();
        Debug.Log(_rb.velocity);
    }

    // Update is called once per frame
    void Update()
    {
        //obj.GetComponent<Transform>().position += new Vector3(0.1f,0,0);
        //var position = obj.GetComponent<Transform>().position;
        //position = new Vector3(obj.GetComponent<Transform>().position.x + 0.1f, 0, 0);
        _rb.velocity = new Vector3(5, 0, 0);
    }
}
