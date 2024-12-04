using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text gameText;
    public GameObject targetContainer;
    private int _targetsToDestroy;
    private float _gameTimer;
    private bool _isGameOver;

    private TargetController[] _targets;

    private void Start()
    {
        _targets = targetContainer.GetComponentsInChildren<TargetController>();
        _targetsToDestroy = _targets.Length;

        foreach (TargetController target in _targets){
            target.onTargetDestroyed = () => {
                OnTargetDestroyed();
            };
        }
    }

    private void OnTargetDestroyed(){
        _targetsToDestroy--;

        if(_targetsToDestroy == 0){
            _isGameOver = true;
            gameText.text = "You Won!..";
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown("n")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(!_isGameOver){
            gameText.text = "Shoot The Targets!";
            gameText.text += "\nTime: " + Mathf.Floor(_gameTimer);
            _gameTimer += Time.deltaTime;
        }else{
            gameText.text = "You Won!";
            gameText.text += "\nYour Time: " + Mathf.Floor(_gameTimer);
        }
    }
}
