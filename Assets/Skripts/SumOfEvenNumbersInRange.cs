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
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в диапазоне от {min} до {max} включительно: {got} - {message}");
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