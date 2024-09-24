using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _stopPauseButton;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private Button _mainMenuButton;

    private void Start()
    {
        _pauseButton.onClick.AddListener(PauseButton);
        _stopPauseButton.onClick.AddListener(StopPauseButton);
        _mainMenuButton.onClick.AddListener(ExitToMainMenu);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        _pausePanel.SetActive(true);
    }

    public void StopPauseButton()
    {
        Time.timeScale = 1.0f;
        _pausePanel.SetActive(false);
    }
}
