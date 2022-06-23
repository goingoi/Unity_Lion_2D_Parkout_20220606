using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera cmr;
    [SerializeField] SphereCollider scillider;
    [SerializeField] Transform sphereTransform;
    [SerializeField] Transform capsuleTransform;
    [SerializeField] Rigidbody capsulerigibody;
    void Start()
    {
        print(cmr.depth);
        print(scillider.radius);
        cmr.backgroundColor = Color.white;
        capsuleTransform.localScale = new Vector3(3, 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        sphereTransform.rotation = Quaternion.Euler(0, Time.time * 10, 0);
        capsulerigibody.velocity = new Vector3(0,10,0);
    }
}
