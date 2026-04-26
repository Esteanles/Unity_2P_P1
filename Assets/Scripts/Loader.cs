using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image loader; 
    private float _progress = 0;
    void Start()
    {
        loader.fillAmount = _progress;
        StartCoroutine(LoadScene());
        
    }
public void StartProgress()
    {
        StartCoroutine(LoadScene());
    }
private IEnumerator LoadScene()
    {
        while (_progress < 1)
        {
        _progress += 0.1f;
        loader.fillAmount = _progress;
        yield return new WaitForSeconds(0.5f);
    }
    if (_progress >= 1)
    {
        SceneManager.LoadSceneAsync("Rebote");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
        
        }
}


