using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemyPrefab;
    public Transform player;
    
    private float rate = 4f;
    private float lastTime;
    private float scaleModifier = 0.1f;
    private float moveSpeedModifier = 0.01f;

    void Start() {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if (Time.time > lastTime + rate) {
            Vector2 position = player.position;
            int randomAreax = Random.Range(0, 2) == 0 ? 1 : -1;
            int randomAreay= Random.Range(0, 2) == 0 ? 1 : -1;
            GameObject enemyObject = (GameObject) Instantiate(enemyPrefab, new Vector2(position.x + 2 * randomAreax, position.y + 2 * randomAreay), Quaternion.identity);
            var localScale = enemyObject.transform.localScale;
            localScale = new Vector2(localScale.x + scaleModifier, localScale.y + scaleModifier);
            enemyObject.transform.localScale = localScale;
            enemyObject.GetComponent<Enemy>().moveSpeed += moveSpeedModifier;
            lastTime = Time.time;
            if (rate > 1)
                rate -= 0.1f;
            if (moveSpeedModifier < 6)
                moveSpeedModifier += 0.05f;
            scaleModifier += 0.1f;
        }
    }
}
