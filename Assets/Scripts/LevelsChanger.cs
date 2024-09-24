using UnityEngine;
using UnityEngine.UI;

public class LevelsChanger : MonoBehaviour
{
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private LevelStart _timerClass;
    

    public LevelsSO _allLevels;
    public int currentLevel = 0;

    private void Start()
    {
        //NextLevel();
        _nextLevelButton.onClick.AddListener(NextLevel);
    }


    private void NextLevel()
    {
        currentLevel++;
        _timerClass.SetCountSeconds(_allLevels.TimeOnLevel[currentLevel]);
        StartCoroutine(_timerClass.LevelTimer());
        _nextLevelButton.gameObject.SetActive(false);
    }


}
