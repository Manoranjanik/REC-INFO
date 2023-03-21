using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VolumeText : MonoBehaviour
{
    [SerializeField] private string volumeName;
    [SerializeField] private string textIntro;  //Sound: or Music:
    private TextMeshProUGUI TextMeshProUGUI;

    private void Awake()
    {
        TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        UpdateVolume();
    }

    private void UpdateVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat(volumeName) * 100;
        TextMeshProUGUI.text = textIntro + volumeValue.ToString();

    }
}
