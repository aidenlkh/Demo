using Unity.VisualScripting;
using UnityEngine;

public class HpPickup : MonoBehaviour
{
    [SerializeField] AudioClip healUpFx;
    private int hpToAdd = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bool restoredHp = collision.gameObject.GetComponent<Health>().AddHealth(hpToAdd);

            if (restoredHp)
            {
                AudioSource.PlayClipAtPoint(healUpFx, transform.position, 1f);
                Destroy(gameObject);
            }
        }
        
    }


}
