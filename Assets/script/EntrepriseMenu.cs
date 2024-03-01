using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject shopcanva;

    void Start()
    {
        shopcanva.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("player"))
        {
            Debug.Log("rentrer2");
            shopcanva.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("sorti");
        if (other.CompareTag("player"))
        {
            shopcanva.SetActive(false);
        }
    }
    
}
