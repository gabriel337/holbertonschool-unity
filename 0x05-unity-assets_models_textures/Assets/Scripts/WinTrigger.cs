using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinTrigger : MonoBehaviour
{
   public GameObject player;
    public TMP_Text TimerText;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        PlayerController Get = player.GetComponent<PlayerController>();
        if (other.tag == "Player")
        {
            Get.CollidedWithFlag = true;
            player.GetComponent<Timer>().enabled = false;
            TimerText.color = Color.green;
            TimerText.fontSize = 60;
        }
    }
}