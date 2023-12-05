using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/**
 * DB is an object to access firebase functions the easier 
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
 /*
 private DB db;
void Start()
{
    db = GameObject.Find("DB").GetComponentInChildren<DB>();
    results = db.GET("http://www.somesite.com/someAPI.php?someaction=AWESOME");
    Debug.Log(results.text);
}
 */
class DB : MonoBehaviour
{
    void Start() { }

    public WWW GET(string url)
    {
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
        return www;
    }

    public WWW POST(string url, Dictionary<string, string> post)
    {
        WWWForm form = new WWWForm();
        foreach (KeyValuePair<String, String> post_arg in post)
        {
            form.AddField(post_arg.Key, post_arg.Value);
        }
        WWW www = new WWW(url, form);

        StartCoroutine(WaitForRequest(www));
        return www;
    }

    private IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
}