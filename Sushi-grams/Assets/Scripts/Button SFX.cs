using UnityEngine;
using UnityEngine.UI;

public class ButtonSFX : MonoBehaviour
{
   public AudioSource audioSource;
   void Start()
   {
       audioSource = GetComponent<AudioSource>();
   }
   public void PlaySound()
   {
       audioSource.Play();
   }
}