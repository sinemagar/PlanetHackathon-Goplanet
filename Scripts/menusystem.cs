using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menusystem : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    // Start is called before the first frame update




    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(3);
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);


    }

    public void menuac()
    {
        menu1.SetActive(true);
        menu2.SetActive(true);
        menu3.SetActive(true);
        StartCoroutine(ExampleCoroutine());

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
