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
            human.id = requesting.id;
            human.name = requesting.name;
            human.avatar = requesting.avatar;
            human.email = requesting.email;

            bubbleText.SetActive(true);
            writing.fullText =  "Hello guys!\n" + 
                                "My name is\n" + human.name + "\n" + 
                                "and you can contact me on\n" + human.email;
            requesting.got = false;
        }
    }
}
