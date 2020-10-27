using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody mybody;
    void Start()
    {
        mybody = gameObject.GetComponent<Rigidbody>();
        mybody.AddForce(new Vector3(0, 0, 50), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
