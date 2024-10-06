using UnityEngine;
using TMPro;

public class TextTutorial : MonoBehaviour
{
    public TMP_Text textTutoList;
    public string[] textAsset;
    void Start()
    {
        textTutoList.text = textAsset[0]; 
    }

    public void NextText()
    {
        textTutoList.text += textAsset[1];
    }
}
