using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    public GameObject level2;

    void Start()
    {
        level2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("player"))
        {
            Debug.Log("rentrer2");
            level2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("sorti");
        if (other.CompareTag("player"))
        {
            level2.SetActive(false);
        }
        
    }
    
}
