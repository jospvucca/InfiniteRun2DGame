using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float _lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, _lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
