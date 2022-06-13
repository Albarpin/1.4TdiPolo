using UnityEngine;
using System.Collections;

public class saniye : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(7);
        Object.Destroy(this.gameObject);
    }
}