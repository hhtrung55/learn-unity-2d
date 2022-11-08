using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerPosition : MonoBehaviour
{
    List<GameObject> minions;
    public GameObject minionPrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    int minionId = 0;

    // Start is called before the first frame update
    private void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();
        this.CheckMinionDead();
    }

    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;
        int index = this.minions.Count;
        if (this.minions.Count >= 2) return;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bom #" + ++minionId;
        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if (minion == null) this.minions.RemoveAt(i);

        }
    }

}
