using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopKutusu : MonoBehaviour
{
    public GameObject cop;
    public GameObject cop2;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "karakter")
        {
            cop.SetActive(true);
            cop2.SetActive(true);
        }
    }
}
