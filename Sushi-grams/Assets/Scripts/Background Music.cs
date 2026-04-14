using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusicInstance;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (backgroundMusicInstance == null)
        {
            backgroundMusicInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
