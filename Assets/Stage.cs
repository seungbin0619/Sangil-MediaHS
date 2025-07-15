using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {
    public Transform spawnPoint;

    private void Awake() {
        spawnPoint.gameObject.SetActive(false);
    }

    public void Enter() {
        gameObject.SetActive(true);
        GameManager.instance.player.transform.position = spawnPoint.position;
    }

    public void Restart() {
        
    }

    public void Exit() {
        gameObject.SetActive(false);
    }
}
