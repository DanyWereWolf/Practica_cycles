using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SumOfEvenNumbersInArray : MonoBehaviour
{
    [SerializeField] private Text AnswerText;

    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � �������� �������: {got} - {message}");
        AnswerText.text = got.ToString();
    }

    private int SumEvenNumbersInArray(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
}
