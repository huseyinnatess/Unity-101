using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text gameText;
    public GameObject targetContainer;
    private int targetsToDestroy;
    private float gameTimer;
    private bool isGameOver;

    private TargetController[] targets;
        void Start()
    {
        targets = targetContainer.GetComponentsInChildren<TargetController>();
        targetsToDestroy = targets.Length;

        foreach (TargetController target in targets){
            target.onTargetDestroyed = () => {
                OnTargetDestroyed();
            };
        }
    }

    void OnTargetDestroyed(){
        targetsToDestroy--;

        if(targetsToDestroy == 0){
            isGameOver = true;
            gameText.text = "You Won!..";
        }
    }

    void Update()
    {
        if(Input.GetKeyDown("n")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(!isGameOver){
            gameText.text = "Shoot The Targets!";
            gameText.text += "\nTime: " + Mathf.Floor(gameTimer);
            gameTimer += Time.deltaTime;
        }else{
            gameText.text = "You Won!";
            gameText.text += "\nYour Time: " + Mathf.Floor(gameTimer);
        }
    }
}
