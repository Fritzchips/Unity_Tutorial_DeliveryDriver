using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColour = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColour = new Color32(1, 1, 1, 1);
    [SerializeField] float deleteDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hitt!!!!!!!!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Package") && !hasPackage)
        {
            Destroy(collision.gameObject, deleteDelay);
            spriteRenderer.color = hasPackageColour;
            hasPackage = true;
        }

        if (collision.tag.Equals("Customer") && hasPackage)
        {
            spriteRenderer.color = noPackageColour;
            hasPackage = false;
        }
    }
}
