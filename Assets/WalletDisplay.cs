using System;
using TMPro;
using UnityEngine;

public class WalletDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private Wallet wallet;
    public void UpdateUI() => textMeshPro.text = wallet._money.ToString();
}
