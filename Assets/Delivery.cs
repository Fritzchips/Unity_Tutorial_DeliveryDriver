using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hitt!!!!!!!!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("was HIT");
    }
}