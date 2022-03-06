using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopToplama : MonoBehaviour
{

    DBmanager managedb;

    public GameObject ok1;
    public GameObject ok2;
    public GameObject ok3;
    public GameObject sutext;
    public GameObject check;
    public GameObject check2;
    public GameObject check3;

    public GameObject panelsatinalcanvas;
    public GameObject fidandikcanvas;

    int kac_cop=0;
    void Start()
    {
        managedb = GameObject.FindGameObjectWithTag("dbmanager").GetComponent<DBmanager>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if(kac_cop >= 2)
        {
           
            ok1.SetActive(true);
            ok2.SetActive(true);
            ok3.SetActive(true);
            kac_cop = 0;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tabela")
        {
        
            panelsatinalcanvas.SetActive(true);
            this.GetComponent<ClickMov>().enabled = false;

        }

        else
        {
            this.GetComponent<ClickMov>().enabled = true;
            panelsatinalcanvas.SetActive(false);
        }

        if (other.gameObject.tag == "fidantabela")
        {
            fidandikcanvas.SetActive(true);
            this.GetComponent<ClickMov>().enabled = false;

        }


        if (other.gameObject.tag == "sukovasi")
        {
            Destroy(other.gameObject);
            sutext.SetActive(true);
        }
        if (other.gameObject.tag == "copler")
        {
            Destroy(other.gameObject);
            kac_cop += 1;
            if(kac_cop >= 2)
            {
                check.SetActive(true);
               
                


            }
        }
        if (other.gameObject.tag == "kutu")
        {
            managedb.SaveData();
            managedb.tokenyazdir();
            ok1.SetActive(false);
            ok2.SetActive(false);
            ok3.SetActive(false);
        }

        //if (other.gameObject.tag == "kutu")
        //{
        //    Debug.Log("acýlamk");
        //    cop.SetActive(true);
        //}

    }
}
