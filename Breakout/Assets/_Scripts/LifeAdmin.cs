using UnityEngine;
using System.Collections.Generic;

public class LifeAdmin : MonoBehaviour
{
    [HideInInspector] public List<GameObject> lifes;
    public GameObject ballPrefab;
    private Ball ballScript;
    public GameObject GameOverMenu;

    public void Start()
    {
        Transform[] childs = GetComponentsInChildren<Transform>();
        foreach (var child in childs)
        {
            lifes.Add(child.gameObject);
        }
    }

    public void RemoveLife()
    {
        if (lifes.Count > 0)
        {
            var eliminatedLife = lifes[lifes.Count - 1];
            Destroy(eliminatedLife);
            lifes.RemoveAt(lifes.Count - 1);
            if (lifes.Count == 0)
            {
                Time.timeScale = 0;
                GameOverMenu.SetActive(true);
                return;
            }
            var ball = Instantiate(ballPrefab) as GameObject;
            ballScript = ball.GetComponent<Ball>();
            ballScript.ballDestroy.AddListener(this.RemoveLife);
            Debug.Log($"Vidas restantes: {lifes.Count}");
        }
        
    }
}
