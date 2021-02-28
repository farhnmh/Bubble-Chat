using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalData : MonoBehaviour
{
    public GameObject bubbleText;
    public WritingAnimation writing;
    public RequestData requesting;
    HumanStruct human;

    void Start()
    {
        bubbleText.SetActive(false);
    }

    void Update()
    {
        if (requesting.got)
        {
            human = new HumanStruct();

            human.id = requesting.data[0];
            human.name = requesting.data[1];
            human.avatar = requesting.data[2];
            human.email = requesting.data[3];

            writing.fullText =  "Hello guys!\n" + 
                                "My name is\n" + human.name + "\n" + 
                                "and you can contact me on\n" + human.email;

            bubbleText.SetActive(true);

            StartCoroutine(writing.ShowText());
            requesting.got = false;
        }
    }
}
