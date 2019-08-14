using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    public MeshRenderer mesh;
    public Material Red_mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        mesh.material = Red_mat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
