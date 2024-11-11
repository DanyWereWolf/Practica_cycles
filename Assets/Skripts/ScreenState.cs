using UnityEngine;
using UnityEngine.UI;
using System;

public class ScreenState : MonoBehaviour
{
    [Header("—цены")]
    [SerializeField] private GameObject fierstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private GameObject thirdScreen;
    [SerializeField] private GameObject fourthScreen;
    [SerializeField] private GameObject fifthScreen;

    private GameObject _currentScreen;



    private void Start()
    {
        fierstScreen.SetActive(true);
        _currentScreen = fierstScreen;
    }

    public void ChangeState(GameObject state)
    {
        if (_currentScreen != null)
        {
            _currentScreen.SetActive(false);
            state.SetActive(true);
            _currentScreen = state;
        }

    }
}
