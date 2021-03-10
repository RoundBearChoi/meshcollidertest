using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{
    public float force = 0f;

    void Start()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    }
}
