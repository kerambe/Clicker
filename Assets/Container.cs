using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    [SerializeField] private ClickSystem clickSystem;
    [SerializeField] private Wallet wallet;
    [SerializeField] private WalletDisplay walletDisplay;
    [SerializeField] private Spawner spawner;
    private void OnEnable()
    {
        clickSystem.OnClick += wallet.AddMoney;
        clickSystem.OnClick += walletDisplay.UpdateUI;
        clickSystem.OnSpawn += spawner.Spawn;
    }
    private void OnDisable()
    {
        clickSystem.OnClick -= wallet.AddMoney;
        clickSystem.OnClick -= walletDisplay.UpdateUI;
        clickSystem.OnSpawn -= spawner.Spawn;
    }
}
