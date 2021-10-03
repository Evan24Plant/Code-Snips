using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
    EnemySpawner enemySpawner;

    private int wave;

    // Start is called before the first frame update
    void Start() {
        wave = 1;
        enemySpawner = gameObject.GetComponent<EnemySpawner>();
        enemySpawner.SpawnWave(wave);
    }

    // Update is called once per frame
    void Update() {
        if (enemySpawner.enemies.Count > 10) {
            Debug.Log(enemySpawner.enemies.Count + "! That's a lot of enemies");
        } else {
            Debug.Log(enemySpawner.enemies.Count + ". This should be easy");
        }
    }
}
