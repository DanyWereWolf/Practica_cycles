using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SelectionOfSort : MonoBehaviour
{
    [SerializeField] private Text result_;
    [SerializeField] private int result;
public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 54, 15, 26, 71, 68 };
        Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 54, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный { 10, 13, 15, 22, 26, 34, 54, 68, 71, 81 }" : "Результат не верный");

        result_.text = sortedArray.SequenceEqual(expectedArray) ? "{ 10, 13, 15, 22, 26, 34, 54, 68, 71, 81 }" : "{ 81, 22, 13, 34, 10, 54, 15, 26, 71, 68 }";
    }

    private int[] SelectionSort(int[] array)
    {
        int indx;
        for (int i = 0; i < array.Length; i++)
        {
            indx = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < array[indx])
                {
                    indx = j; 
                }
            }
            if (array[indx] == array[i])
                continue;
            
            int temp = array[i];
            array[i] = array[indx];
            array[indx] = temp;
        }
        return array;
    }
}