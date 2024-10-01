using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGameButton : ExitButton
{
    public void Button_ButtonPressedEvent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
