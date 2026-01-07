using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.GameScene);

        });
        quitButton.onClick.AddListener(() => {
            quitButton.image.color = new Color32(96, 47, 47, 255);
            Application.Quit();
        });
    }

}
