using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class UnityCoding : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool tbool;
    public Toggle toggleTest;

    public void ToggleTest()
    {
        tbool = toggleTest.GetComponent<Toggle>().isOn;
        if (tbool == false) //(!toggle)
        {
            Debug.Log("Toggle False"); 
        }
        else if (tbool == true) //(toggle)
        {
            Debug.Log("Toggle True");
        }
    }

    private void Start()
    {

    }

    private void Update()//Tlanslate, MoveToward, Lerp
    {
        //rb.AddForce( new Vector3(0, 1, 0));
        //rb.linearVelocity = new Vector3(0,1,0) 5 ;
        //Physics2D.OverlapCircleAll(transform.position, 100f);
        // rb.AddTorque(-770f);
    }

    private void OnTriggerEnter2D(Collider2D you) //둘다 콜라이더 O, 하나 이상 rigid,둘중 하나만 istrigger
    {
        //you.gameObject.SetActive(false);
        you.GetComponent<SpriteRenderer>().color = Color.blue;
    }

    private void OnTriggerStay2D(Collider2D you)
    {
        you.transform.localScale += new Vector3(1, 1, 0) * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D you)
    {
        //you.gameObject.SetActive(true);
        you.GetComponent<SpriteRenderer>().color = Color.white;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.gameObject.transform.localScale -= new Vector3(1, 1, 0) * Time.deltaTime;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}