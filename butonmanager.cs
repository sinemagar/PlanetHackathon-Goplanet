using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonmanager : MonoBehaviour
{
    public GameObject kapatilacak;
    public GameObject acilacak;
    public int sahneid;

    public void ackapa()
    {
        kapatilacak.SetActive(false);
        acilacak.SetActive(true);

    }

    public void geridon()
    {
        acilacak.SetActive(false);
        kapatilacak.SetActive(true);
    }

    public void sahnedegis()
    {

        SceneManager.LoadScene(sahneid);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
