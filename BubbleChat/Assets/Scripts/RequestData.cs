using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using SimpleJSON;

public class RequestData : MonoBehaviour
{
    [Header("General Attribute")]
    public int sequence;
    public string pageSource;
    public bool got;
    public List<string> data;

    void Start()
    {
        StartCoroutine(DataRequesting(pageSource));
    }

    IEnumerator DataRequesting(string gettingData)
    {
        using (UnityWebRequest webReq = UnityWebRequest.Get(gettingData))
        {
            yield return webReq.SendWebRequest();

            if (webReq.isNetworkError || webReq.isHttpError)
                Debug.Log("Error: " + webReq.error);
            else
                Debug.Log("Received: " + webReq.downloadHandler.text);

            for (int i = 0; i < 4; i++)
            {
                data[i] = GetterData(i, webReq.downloadHandler.text);
            }

            got = true;
        }
    }

    public string GetterData(int index, string data)
    {
        string category = string.Empty;
        JSONArray DataArray = JSON.Parse(data).AsArray;

        switch (index)
        {
            case 0:
                category = "id";
                break;

            case 1:
                category = "name";
                break;

            case 2:
                category = "avatar";
                break;

            case 3:
                category = "email";
                break;
        }

        return DataArray[sequence][category].Value;
    }
}
