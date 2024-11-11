using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FirstOfOccurrence : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Text textResult;
    [SerializeField] private float result_;

    public void OnFirstOccurrence()
    {

        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
        textResult.text = got.ToString();

        array = new int[] { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
        textResult.text = got.ToString();
    }
    public void Update()
    {
        float.TryParse(inputField.text, out float result);
        result_ = result;
    }
    private int FirstOccurrence(int[] array, int value)
    {
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] == result_)
                return i;
        }
        return -1;
    }
}