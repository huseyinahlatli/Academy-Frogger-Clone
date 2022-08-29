using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FrogTrigger : MonoBehaviour
{
    private Vector2 startPosition = new Vector2(0f, -4f);
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            GameManager.Instance.score += 100;
            GameManager.Instance.scoreText.text = "Score: " + GameManager.Instance.score.ToString();
            GameManager.Instance.frog.transform.position = startPosition;
        }
        
        if (other.gameObject.CompareTag("Car"))
            GameManager.Instance.RestartGame();
    }
}
