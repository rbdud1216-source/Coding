using TMPro;
using UnityEngine;

public class DorpdownDebug : MonoBehaviour
{
    public TextMeshProUGUI debugText;
    public TMP_Dropdown dropdown;

    public void DropdownChangeText()
    {
        int index = dropdown.value;
        string optionText = dropdown.options[index].text;
        debugText.text = optionText;

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
