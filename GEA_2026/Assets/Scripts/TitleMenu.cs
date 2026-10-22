using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public string gameSceneName = "SampleScene";
   

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void QuitGame()
    {
        Debug.Log("게임 종료 : 에디터에서는 작동 안합니다!");
        Application.Quit();
    }
}
