using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelsatinal : MonoBehaviour
{
    public GameObject acilacak;
    public GameObject kapanacak;
    public GameObject tick;
    public GameObject player;
    public GameObject tabela;
    
    public void satinalbuton()
    {
        acilacak.SetActive(true);
        kapanacak.SetActive(false);
        tabela.SetActive(false);
        player.GetComponent<ClickMov>().enabled = true;
        tick.SetActive(true);
     
    }
   


    // Update is called once per frame
    void Update()
    {
        
    }
}
