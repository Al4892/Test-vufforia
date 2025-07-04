using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> buttons;
    [SerializeField]
    private string showAnimationName;
    [SerializeField]
    private string hiddenAnimationName;
    [SerializeField]
    private float showButtonsDelay = 0.1f;

    public void ShowButtons()
    {
        StartCoroutine(ShowButtonsCouroutine());

    }
    private IEnumerator ShowButtonsCouroutine()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].GetComponent<Animator>().Play(showAnimationName);
            yield return new WaitForSeconds(showButtonsDelay);
        }

    }
    public void HideButtons()
    {
        foreach (GameObject button in buttons)
        {
            button.GetComponent<Animator>().Play(hiddenAnimationName);
         }
     }
}
