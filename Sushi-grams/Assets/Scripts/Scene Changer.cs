using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        StartCoroutine(WaitToChangeScene(0.5f, sceneName));
    }

    IEnumerator WaitToChangeScene(float waitTime, string sceneName)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(sceneName);
    }
}

