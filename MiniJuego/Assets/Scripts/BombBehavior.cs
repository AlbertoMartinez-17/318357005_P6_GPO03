using System.Collections;
using UnityEngine;

public class BombBehavior : MonoBehaviour
{
    public GameObject explosionEffect; // Arrástrale un efecto de explosión desde el inspector
    private bool hasExploded = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (hasExploded) return;

        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(ExplodeAfterDelay(2f));
        }
        else if (collision.gameObject.CompareTag("Capsule"))
        {
            FindObjectOfType<UIManager>().RegistrarExplosion();
            Explode();
        }
    }

    private IEnumerator ExplodeAfterDelay(float delay)
    {
        hasExploded = true;
        yield return new WaitForSeconds(delay);
        Explode();
    }

    private void Explode()
    {
        hasExploded = true;

        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }

}
