using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Player _player;
    [SerializeField] private WeaponView _tempLate;
    [SerializeField] private GameObject _itemContainer;

    private void Start() 
    {
        for (int i = 0; i < _weapons.Count; i++)
        {
            AddItem(_weapons[i]);
        }
    }

    private void AddItem(Weapon weapon)
    {
        var view = Instantiate(_tempLate, _itemContainer.transform);
        view.SellButtonClick += OnSellButtonClick;
        view.Render(weapon);
    }

    private void OnSellButtonClick(Weapon weapon, WeaponView view)
    {
        TrySellWeapon(weapon, view);
    }

    private void TrySellWeapon(Weapon weapon, WeaponView view)
    {
        _player.BuyWeapon(weapon);
        weapon.Buy();
        view.SellButtonClick -= OnSellButtonClick;
    }
}