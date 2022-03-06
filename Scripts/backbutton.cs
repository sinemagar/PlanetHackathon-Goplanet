using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public int sahneid;

    public void sahnedegis()
    {
        SceneManager.LoadScene(sahneid);

    }

}
