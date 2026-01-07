using UnityEngine;

public class FinishUI : MonoBehaviour
{
    private void Start()
    {
        Hide();
    }
    public void FinishShow()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
