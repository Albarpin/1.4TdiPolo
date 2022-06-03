using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class İnfo : MonoBehaviour
{
    [SerializeField]
    private GameObject star;

    private bool starIsEnabled;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        starIsEnabled = true;
        star.SetActive(starIsEnabled);
    }

    private void TurnOnAndOff()
    {
        starIsEnabled ^= true;
        star.SetActive(starIsEnabled);
    }
}
