//MoveToClickPoint.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickMov : MonoBehaviour
{
    public GameObject karakter;
   public Animator yurudu;
    public float speed = 10f;
    public GameObject gorev1;
    public GameObject gorev2;
    public GameObject gorev3;

    

    
    Vector2 sondokunus;
    bool moving;
    private void Start()
    {
        
    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(3);
        gorev1.SetActive(false);
        gorev2.SetActive(false);
        gorev3.SetActive(false);



    }

    public void gorevac()
    {
        gorev1.SetActive(true);
        gorev2.SetActive(true);
        gorev3.SetActive(true);
        StartCoroutine(ExampleCoroutine());
    }
    public void solust()
    {
        //Debug.Log("sol");
        karakter.transform.localEulerAngles =  new Vector3(0, -30, 0);
    }
    public void sagust()
    {
       // Debug.Log("sag");
        karakter.transform.localEulerAngles = new Vector3(0, 30, 0);
    }
    public void asagý()
    {
        //Debug.Log("asagý");
        karakter.transform.localEulerAngles = new Vector3(0, -180, 0);
    }
    private void Update()
    {
        
        //if (gorev1.activeInHierarchy)
        //{
        //   gorevyapildikapa.SetActive(false);
        //}

        if (Input.GetMouseButton(0))
        {
            sondokunus = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            yurudu.SetBool("walk", true);
            moving = true;
          //  Debug.Log(Input.mousePosition);
        }
        if(moving && (Vector2)transform.position != sondokunus)
        {
            float adým = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, sondokunus, adým);
            

        }
       
        else
        {
            yurudu.SetBool("walk", false);
            moving = false;
        }

    }
}
