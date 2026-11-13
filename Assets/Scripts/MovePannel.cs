using UnityEngine;
using UnityEngine.UI;

public class MovePannel : MonoBehaviour
{
    public RectTransform content;
    public Scrollbar scrollbar;
    public void ScrollPannel()
    {
        content.anchoredPosition = new Vector2(scrollbar.value * 200f, content.anchoredPosition.y);
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
