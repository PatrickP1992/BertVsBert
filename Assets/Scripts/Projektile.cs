using UnityEngine;

public class Projektile : MonoBehaviour
{
    public Rigidbody2D bulletRb;
    public float shootingSpeed;

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        bulletRb.velocity = new Vector2(shootingSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
