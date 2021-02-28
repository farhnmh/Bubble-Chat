using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class WritingAnimation : MonoBehaviour
{
    [Header("General Attribute")]
    public float speed;
    
    [TextArea(5, 10)]
    public string fullText;
    string currentText = "";

    public IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(speed);
        }
    }
}
