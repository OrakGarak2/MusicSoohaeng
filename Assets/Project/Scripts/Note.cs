using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum instruments
{
    Piano = 0,
    UltraPiano = 1,
    Otoma = 2,
    Violin = 3
}

public class Note : MonoBehaviour
{
    [SerializeField] List<AudioClip> noteList = new List<AudioClip>();

    [SerializeField] instruments instrument = instruments.Piano;

    [SerializeField] Dropdown dropdown;

    [SerializeField] KeyCode keyCode;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownEvent);
    }

    void OnDropdownEvent(int index)
    {
        if (index >= noteList.Count) { return; }

        instrument = (instruments)index;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            AudioManager.audioSource.PlayOneShot(noteList[(int)instrument]);
        }
    }
}
