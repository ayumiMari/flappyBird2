using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ControladorMenu : MonoBehaviour
{
    private UIDocument document;
    private Button botao;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("btnJogar");
        botao.RegisterCallback<ClickEvent>(onPlay);
    }

    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("MenuJogar");
    }
}
