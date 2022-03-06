using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidanDik : MonoBehaviour
{
    public GameObject acilacakFidan;
    public GameObject acilacakSu;
    public GameObject kapanacakCanvas;
    public GameObject tickGorev2;
    public GameObject player;
    public GameObject tabela;
    void Start()
    {
        
    }
    public void Fidandikme()
    {
        acilacakFidan.SetActive(true);
        acilacakSu.SetActive(true);
        kapanacakCanvas.SetActive(false);
        tabela.SetActive(false);
        player.GetComponent<ClickMov>().enabled = true;
        tickGorev2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
