using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SumOfEvenNumbersInRange : MonoBehaviour
{
    [SerializeField] private Text resultText;

    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � ��������� �� {min} �� {max} ������������: {got} - {message}");
        resultText.text = got.ToString();
    }
    private int SumEvenNumbersInRange(int min, int max)
    {
        int sum = 0;

        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}