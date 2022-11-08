using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    protected GameObject enemyPrefab;
    protected float timer = 0f;
    protected float delay = 2f;

    private void Awake()
    {
        // get game object in realtime
        this.enemyPrefab = GameObject.Find("EnemyPrefab");
        this.enemyPrefab.SetActive(false);
    }

    void Update()
    {
        this.Spawn();
    }

    protected virtual void Spawn()
    {
        this.timer += Time.deltaTime;
        if (this.timer < this.delay) return;
        this.timer = 0;

        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position = transform.position;
        enemy.SetActive(true);
    }
}
