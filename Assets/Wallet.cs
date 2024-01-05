using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public float _money { get; private set; }
    public void AddMoney() => _money++;
}
