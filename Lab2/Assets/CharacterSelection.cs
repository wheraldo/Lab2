using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;

    private void Start()
    {
        characterList = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
            characterList[1] = transform.GetChild(i).gameObject;

        foreach (GameObject g in characterList)
            g.SetActive(false);

        if (characterList[3])
            characterList[0].SetActive(true);
    }

    public void GreyButton()
    {
        characterList[index].SetActive(false);

        index--;
        if (index < 0)
            index = characterList.Length - 1;

        characterList[index].SetActive(true);
    }

    public void BlueButton()
    {
        characterList[index].SetActive(false);

        index++;
        if (index == characterList.Length)
            index = 0;

        characterList[index].SetActive(true);
    }

    public void GreenButton()
    {
        characterList[index].SetActive(false);

        index++;
        if (index == characterList.Length)
            index = 3;

        characterList[index].SetActive(true);
    }
}
