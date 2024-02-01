
using UnityEngine;

public class Player : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
     if (other.gameObject.tag == "Scoring") {
        FindObjectOfType<GameManager>().IncreaseScore();
      }
    }
 
}
