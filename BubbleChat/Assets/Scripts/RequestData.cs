using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class RequestData : MonoBehaviour
{
    [Header("General Attribute")]
    public int sequence;
    public string pageSource;
    public bool got;

    [Header("Struct Attribute")]
    public string id;
    public string name;
    public string avatar;
    public string email;

    void Start()
    {
        WWW getting = new WWW(pageSource);
        StartCoroutine(DataRequesting(getting));
    }

    IEnumerator DataRequesting(WWW gettingData)
    {
        yield return gettingData;

        id = GetterId(gettingData.text);
        name = GetterName(gettingData.text);
        avatar = GetterAvatar(gettingData.text);
        email = GetterEmail(gettingData.text);
        got = true;
    }

    public string GetterId(string data)
    {
        JSONArray DataArray = JSON.Parse(data).AsArray;
        return DataArray[sequence]["id"].Value;
    }

    public string GetterName(string data)
    {
        JSONArray DataArray = JSON.Parse(data).AsArray;
        return DataArray[sequence]["name"].Value;
    }

    public string GetterAvatar(string data)
    {
        JSONArray DataArray = JSON.Parse(data).AsArray;
        return DataArray[sequence]["avatar"].Value;
    }
    
    public string GetterEmail(string data)
    {
        JSONArray DataArray = JSON.Parse(data).AsArray;
        return DataArray[sequence]["email"].Value;
    }
}
