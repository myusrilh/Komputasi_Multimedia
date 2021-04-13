using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetChest : MonoBehaviour
{
    // Start is called before the first frame update
    public Text chestText;
    private bool carryingChest = false;
    void Start()
    {
        UpdateChestText();
    }

    void OnCollisionEnter(Collision hit){
        if(hit.gameObject.tag == "Chest"){
            carryingChest = true;
            UpdateChestText();
            Destroy(hit.gameObject);
        }
    }

    void UpdateChestText()
    {
        string chestMessage = "Chest : belum didapat";
        if (carryingChest) chestMessage = "Chest : sudah didapat. Selamat!";
        chestText.text = chestMessage;   
    }
}
