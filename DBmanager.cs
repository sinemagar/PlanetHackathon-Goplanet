using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using UnityEngine.SceneManagement;

public class DBmanager : MonoBehaviour
{
    public InputField usernameinput;
    public InputField passwordinput;
    public InputField loginusernameinput;
    public InputField loginpasswordinput;
    public DatabaseReference usersRef;
    public int token ;
    public string tokentext;


    public Text tokentextgoster;

    public GameObject gameac;
    public GameObject loginkapa;

    int a = 0;

    void Start()
    {

        int.TryParse(tokentext, out token);
        StartCoroutine(Initilization());
    }

    public void sahndegis()
    {
        a = a + 1;
        gameac.SetActive(true);
        loginkapa.SetActive(false);
        tokentextgoster.text = tokentext.ToString();

    }

    private IEnumerator Initilization()
    {
        var task = FirebaseApp.CheckAndFixDependenciesAsync();
        while (!task.IsCompleted)
        {
            yield return null;
        }
        if(task.IsCanceled|| task.IsFaulted)
        {
            Debug.LogError("Database Error:" + task.Exception);
        }
        var dependencyStatus = task.Result;

        if (dependencyStatus == DependencyStatus.Available)
        {
            usersRef = FirebaseDatabase.DefaultInstance.GetReference("Users");
            Debug.Log("init completed");
    
        }
        else
        {
            Debug.LogError("Database Error:");
        }

    }



    public void SaveData()
    {
        Debug.Log("save data calisti");

        string username= usernameinput.text;
        string password = passwordinput.text;

        token = token + 1;
        Dictionary<string, object> user = new Dictionary<string, object>();
        user["username"] = username;
        user["password"] = password;
        user["token"] = token;
     

        string key = username;
        usersRef.Child(key).UpdateChildrenAsync(user);
 
    }

       public void tokenyazdir()
    {
        Debug.Log("tokenyazdir calisti");
        tokentextgoster.text = token.ToString();

    }



    public void GetData()
    {
        StartCoroutine(GetUserData());
    }


    public IEnumerator GetTokenData()
    {
        
        string name = loginusernameinput.text;
        var task = usersRef.Child(name).GetValueAsync();

        while (!task.IsCompleted)
        {
            yield return null;
        }
        if (task.IsCanceled || task.IsFaulted)
        {
            Debug.LogError("Database Error:" + task.Exception);
        }
        DataSnapshot snapshot = task.Result;

        foreach (DataSnapshot user in snapshot.Children)
        {
            if (user.Key == "token")
            {
                tokentext = user.Value.ToString();
                Debug.Log("tokentext: " +tokentext);
                Debug.Log("token: " + user.Value.ToString());

                if (a == 0)
                {
                    sahndegis();
                }
            }
           }
        }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }



    public IEnumerator GetUserData()
    {
        string name = loginusernameinput.text;
        string pass = loginpasswordinput.text;
        var task = usersRef.Child(name).GetValueAsync();
        var task2 = usersRef.Child(pass).GetValueAsync();

        while (!task.IsCompleted && !task2.IsCompleted)
        {
            yield return null;
        }
        if (task.IsCanceled || task.IsFaulted)
        {
            Debug.LogError("Database Error:" + task.Exception);
        }
        DataSnapshot snapshot = task.Result;
        
        

        foreach (DataSnapshot user in snapshot.Children  )
        {
            if (user.Key == "password")
            {
                Debug.Log("Password: " + user.Value.ToString());
                string deneme = user.Value.ToString();

                if (deneme == pass)
                {
                    Debug.Log("tokenyazil");
                    StartCoroutine(GetTokenData());


                }

            }
           
          
        }
    }
}
