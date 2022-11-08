using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    public int hp = 10;

    public virtual void Receive(int damage)
    {
        this.hp -= damage;
    }
}
