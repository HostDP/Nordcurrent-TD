using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Button_ButtonPressedEvent()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
