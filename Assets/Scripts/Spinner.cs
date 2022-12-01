using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotationX = 0;
    [SerializeField] float rotationY = 0.5f;
    [SerializeField] float rotationZ = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
