using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainItem : MonoBehaviour
{   
    private Rigidbody _rb;
    public bool IsDisplayed { get; private set; }

    public void DisplayTerrain()
    {
        IsDisplayed = true;
        gameObject.SetActive(true);
    }
    public void HideTerrain()
    {
        IsDisplayed = false;
        gameObject.SetActive(false);
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        Debug.Log(_rb.velocity);
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(-5, 0, 0);
    }
}
