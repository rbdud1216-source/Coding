using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IputFieldDebug : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public TMP_InputField inputField;
    public void copyText() //왜 함수에 public을 적을까? 다른 클래스에 쓰려고. 
    {
        myText.text = inputField.text;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
