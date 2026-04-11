using UnityEngine;
using UnityEngine.UI;

public class ButtonSFX : MonoBehaviour
{
   public AudioSource audioSource;
   public Button button;
   void Start()
   {
       button.onClick.AddListener(PlaySound);
   }
   void PlaySound()
   {
       audioSource.Play();
   }
}