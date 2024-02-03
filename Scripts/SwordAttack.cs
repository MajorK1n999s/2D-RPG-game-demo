using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordCollider;

    public float damage = 3f;
    Vector2 rightAttackOffset;

    // Start is called before the first frame update
    void Start()
    {
        rightAttackOffset = transform.position;
    }

   

    public void AttackRight()
    {
        print("attack right");
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttactLeft()
    {
        print("attack left");
        swordCollider.enabled = true;
        transform.localPosition = new Vector2(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //deal damage with enemy
            Enemy enemy = collision.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }


}
