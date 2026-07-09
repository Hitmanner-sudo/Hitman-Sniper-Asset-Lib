using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200053D")]
public class PowerUpsController : UIController
{
	[Token(Token = "0x4001BBF")]
	[FieldOffset(Offset = "0x50")]
	public GameObject PowerUpPrefab;

	[Token(Token = "0x4001BC0")]
	[FieldOffset(Offset = "0x58")]
	public UISprite Background;

	[Token(Token = "0x4001BC1")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid PowerUpsGrid;

	[Token(Token = "0x4001BC2")]
	[FieldOffset(Offset = "0x68")]
	private List<KeyValuePair<PowerUp, bool>> _powerUps;

	[Token(Token = "0x4001BC3")]
	[FieldOffset(Offset = "0x70")]
	private List<GameObject> _powerUpGameObjects;

	[Token(Token = "0x4001BC4")]
	[FieldOffset(Offset = "0x78")]
	private List<PowerUpController> _powerUpControllers;

	[Token(Token = "0x60020B4")]
	[Address(RVA = "0xB34AA4", Offset = "0xB34AA4", VA = "0xB34AA4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60020B5")]
	[Address(RVA = "0xB35D24", Offset = "0xB35D24", VA = "0xB35D24", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60020B6")]
	[Address(RVA = "0xB34D28", Offset = "0xB34D28", VA = "0xB34D28")]
	private List<KeyValuePair<PowerUp, bool>> CreatePowerUpsFromWeaponData()
	{
		return null;
	}

	[Token(Token = "0x60020B7")]
	[Address(RVA = "0xB350C8", Offset = "0xB350C8", VA = "0xB350C8")]
	private List<KeyValuePair<PowerUp, bool>> CreatePowerUpsFromChallengeData()
	{
		return null;
	}

	[Token(Token = "0x60020B8")]
	[Address(RVA = "0xB353E0", Offset = "0xB353E0", VA = "0xB353E0")]
	private void CreatePowerUpGameObject(KeyValuePair<PowerUp, bool> powerUpKvp, int index)
	{
	}

	[Token(Token = "0x60020B9")]
	[Address(RVA = "0xB35C58", Offset = "0xB35C58", VA = "0xB35C58")]
	private void RepositionGrid()
	{
	}

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0xB36334", Offset = "0xB36334", VA = "0xB36334")]
	private void RestorePowerUpsGrid()
	{
	}

	[Token(Token = "0x60020BB")]
	[Address(RVA = "0xB35E28", Offset = "0xB35E28", VA = "0xB35E28")]
	private void DestroyPowerupControllers()
	{
	}

	[Token(Token = "0x60020BC")]
	[Address(RVA = "0xB364F0", Offset = "0xB364F0", VA = "0xB364F0")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60020BD")]
	[Address(RVA = "0xB366A4", Offset = "0xB366A4", VA = "0xB366A4")]
	private void OnPowerUpDataUpdated(HUDModel.PowerUpUpgraded PowerUpUpgraded)
	{
	}

	[Token(Token = "0x60020BE")]
	[Address(RVA = "0xB36874", Offset = "0xB36874", VA = "0xB36874")]
	private void UpdateActivePowerUps(PowerUpController currentPowerUp)
	{
	}

	[Token(Token = "0x60020BF")]
	[Address(RVA = "0xB36A88", Offset = "0xB36A88", VA = "0xB36A88")]
	private void OnPowerUpActiveStateChanged(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60020C0")]
	[Address(RVA = "0xB36B74", Offset = "0xB36B74", VA = "0xB36B74")]
	private void UpdateEnabledPowerUps(PowerUpController currentPowerUp)
	{
	}

	[Token(Token = "0x60020C1")]
	[Address(RVA = "0xB36D58", Offset = "0xB36D58", VA = "0xB36D58")]
	private void OnRequestUpdateBlockedPowerUps(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0xB3679C", Offset = "0xB3679C", VA = "0xB3679C")]
	private void UpdatePowerUp(PowerUp powerUpData, int level)
	{
	}

	[Token(Token = "0x60020C3")]
	[Address(RVA = "0xB36328", Offset = "0xB36328", VA = "0xB36328")]
	private int GetTooltipDepth(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0xB36E38", Offset = "0xB36E38", VA = "0xB36E38")]
	public PowerUpsController()
	{
	}
}
