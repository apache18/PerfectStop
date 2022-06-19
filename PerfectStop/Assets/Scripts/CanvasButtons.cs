using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public Sprite btn, btnPressed;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void PlayGame()
    {
        StartCoroutine(LoadScene("Game"));
    }

    public void SetPressedButton()
    {
        _image.sprite = btnPressed;
        transform.GetChild(0).localPosition -= new Vector3(0, 7, 0);
    }
    public void SetDefaultButton()
    {
        _image.sprite = btn;
        transform.GetChild(0).localPosition += new Vector3(0, 7, 0);
    }

    IEnumerator LoadScene(string name)
    {
        float fadeTime = Camera.main.GetComponent<Fading>().Fade(1f);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(name);
    }
}
