using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    private bool isShowingMenu = false;
    public TMP_Text Tiltle;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;
    void Start()
    {
        GameMenu.enabled = isShowingMenu;
        Tiltle.text = "Welcome to Unity!";
        Message.text = "Do you want to continue?";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
