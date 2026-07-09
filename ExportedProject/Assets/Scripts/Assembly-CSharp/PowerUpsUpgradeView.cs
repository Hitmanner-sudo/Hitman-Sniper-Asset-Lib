using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C1")]
public class PowerUpsUpgradeView : View
{
	[Token(Token = "0x40025F4")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid AbilitiesGrid;

	[Token(Token = "0x40025F5")]
	[FieldOffset(Offset = "0x68")]
	public GameObject AbilitySlotViewPrefab;

	[Token(Token = "0x40025F6")]
	[FieldOffset(Offset = "0x70")]
	private List<PowerUpItemSlotViewChallenge> _abilitiesView;

	[Token(Token = "0x6002C71")]
	[Address(RVA = "0xB36E40", Offset = "0xB36E40", VA = "0xB36E40", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002C72")]
	[Address(RVA = "0xB37570", Offset = "0xB37570", VA = "0xB37570")]
	public void UpdatePowerUps()
	{
	}

	[Token(Token = "0x6002C73")]
	[Address(RVA = "0xB371FC", Offset = "0xB371FC", VA = "0xB371FC")]
	private void CreateAttachmentSlotView(int index, UIGrid uiGrid, GameObject gameObjectToSpawn, int currentLevel, int maxLevel, bool isUnlocked, int cost, ChallengeData.WeaponPowerUp weaponPowerUp)
	{
	}

	[Token(Token = "0x6002C74")]
	[Address(RVA = "0xB37488", Offset = "0xB37488", VA = "0xB37488")]
	private void PositionGrid()
	{
	}

	[Token(Token = "0x6002C75")]
	[Address(RVA = "0xB37688", Offset = "0xB37688", VA = "0xB37688", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C76")]
	[Address(RVA = "0xB37804", Offset = "0xB37804", VA = "0xB37804")]
	public PowerUpsUpgradeView()
	{
	}
}
