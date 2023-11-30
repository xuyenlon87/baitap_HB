using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Control : MonoBehaviour
{
    public Button caculate;
    public Button caculateDelete;
    public TMP_InputField input_1;
    public TextMeshProUGUI resultText_array;
    public TextMeshProUGUI resultText_list;
    public TextMeshProUGUI resultText_dictionary;

    private int[] numberArray = new int[10];
    private List<int> numberList = new List<int>();
    private Dictionary<string, int> numberDictionary = new Dictionary<string, int>();

    int count = 0;
    int key = 0;

    private void Start()
    {
        caculate.onClick.AddListener(caculateMath);
        caculateDelete.onClick.AddListener(CaculateDelete);
    }

    public void caculateMath()
    {
        int input;
        if (input_1 != null)
        {
            input = int.Parse(input_1.text);
            numberDictionary.Add(key.ToString(), input);
            numberArray[count] = input;
            count++;
            key++;
            numberList.Add(input);
            printToScreen();
        }
    }

    public void CaculateDelete()
    {
        int input;
        if (input_1 != null)
        {
            input = int.Parse(input_1.text);
            for(int i = 0; i < numberArray.Length; i++)
            {
                if(input == numberArray[i])
                {
                    Array.Clear(numberArray, numberArray[i], numberArray.Length-1);
                }
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                if (input == numberList[i])
                {
                    numberList.RemoveAt(i);
                }
            }
            deleteToScreen();
        }
    }

    private void printToScreen()
    {
        string textArray = "";
        for (int i = 0; i < 10; i++)
        {
            textArray += numberArray[i].ToString() + ",";
        }
        resultText_array.text = textArray;
        textArray = "";
        for (int i = 0; i < numberList.Count; i++)
        {
            textArray += numberList[i].ToString() + ",";
        }
        resultText_list.text = textArray;
        textArray = "";
        // foreach
        foreach (var item in numberDictionary.Values)
        {
            textArray += item.ToString() + ",";
            Debug.Log(textArray);
        }
        resultText_dictionary.text = textArray;
    }

    private void deleteToScreen()
    {
        string textArray = "";
        for (int i = 0; i < 10; i++)
        {
            textArray += numberArray[i].ToString() + ",";
        }
        resultText_array.text = textArray;
        textArray = "";
        for (int i = 0; i < numberList.Count; i++)
        {
            textArray += numberList[i].ToString() + ",";
        }
        resultText_list.text = textArray;
        textArray = "";
        // foreach
        foreach (var item in numberDictionary.Values)
        {
            textArray += item.ToString() + ",";
            Debug.Log(textArray);
        }
        resultText_dictionary.text = textArray;
    }


}