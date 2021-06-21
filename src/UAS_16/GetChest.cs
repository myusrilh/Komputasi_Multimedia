using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetChest : MonoBehaviour
{
    // Start is called before the first frame update
    public Text chestText;
    private bool carryingChest = false;
    public AudioSource audioSource;
    public string nameScene;
    void Start()
    {
        UpdateChestText();
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider hit){
        if(hit.gameObject.tag == "Chest"){
            audioSource.Play();
            carryingChest = true;
            UpdateChestText();
            Destroy(hit.gameObject);
            StartCoroutine(LoadScene());
        }
    }

    void UpdateChestText()
    {
        string chestMessage = "Chest : belum didapat";
        if (carryingChest) chestMessage = "Chest : sudah didapat. Selamat!";
        chestText.text = chestMessage;   
    }

    IEnumerator LoadScene(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(nameScene);
    }
}
