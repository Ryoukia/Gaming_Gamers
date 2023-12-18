using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    public GameObject spell;
    public float spellSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireProjectile();
        }
    }

    void FireProjectile()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (new Vector2(mousePosition.x, mousePosition.y) - new Vector2(transform.position.x, transform.position.y)).normalized;

        GameObject projectile = Instantiate(spell, transform.position, Quaternion.identity);
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

        Destroy(projectile, 5f);
        projectileRb.velocity = direction * spellSpeed;
    }
}
