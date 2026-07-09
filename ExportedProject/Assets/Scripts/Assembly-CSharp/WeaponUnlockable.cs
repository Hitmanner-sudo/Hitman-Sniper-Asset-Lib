using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x20003B0")]
public class WeaponUnlockable : Unlockable
{
	[Serializable]
	[Token(Token = "0x20003B1")]
	public class LazyWeapon : LazyReference<GameObject>
	{
		[Token(Token = "0x170003B7")]
		public Weapon WeaponScript
		{
			[Token(Token = "0x600171E")]
			[Address(RVA = "0xA42EEC", Offset = "0xA42EEC", VA = "0xA42EEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600171F")]
		[Address(RVA = "0xA42FD8", Offset = "0xA42FD8", VA = "0xA42FD8")]
		public LazyWeapon()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003B2")]
	public class RequiredPartInfo
	{
		[Token(Token = "0x20003B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5935DC", Offset = "0x5935DC")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4001519")]
			[FieldOffset(Offset = "0x10")]
			public WeaponPart weaponpart;

			[Token(Token = "0x6001723")]
			[Address(RVA = "0xA43250", Offset = "0xA43250", VA = "0xA43250")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6001724")]
			[Address(RVA = "0xA477B4", Offset = "0xA477B4", VA = "0xA477B4")]
			internal bool _003Cget_Quantity_003Eb__0(NonConsumable x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001518")]
		[FieldOffset(Offset = "0x10")]
		public string ResourcePath;

		[Token(Token = "0x170003B8")]
		public int Quantity
		{
			[Token(Token = "0x6001720")]
			[Address(RVA = "0xA43024", Offset = "0xA43024", VA = "0xA43024")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001721")]
			[Address(RVA = "0xA43258", Offset = "0xA43258", VA = "0xA43258")]
			set
			{
			}
		}

		[Token(Token = "0x6001722")]
		[Address(RVA = "0xA4325C", Offset = "0xA4325C", VA = "0xA4325C")]
		public RequiredPartInfo()
		{
		}
	}

	[Token(Token = "0x20003B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5935EC", Offset = "0x5935EC")]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0x10")]
		public PlayerProfileData profile;

		[Token(Token = "0x6001725")]
		[Address(RVA = "0xA42E20", Offset = "0xA42E20", VA = "0xA42E20")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6001726")]
		[Address(RVA = "0xA42E28", Offset = "0xA42E28", VA = "0xA42E28")]
		internal WeaponUnlockable _003CGetMaxModSlotCountForAllWeapons_003Eb__0(LazyWeaponUnlockable w)
		{
			return null;
		}
	}

	[Token(Token = "0x20003B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5935FC", Offset = "0x5935FC")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x10")]
		public PlayerProfileData profile;

		[Token(Token = "0x6001727")]
		[Address(RVA = "0xA42E70", Offset = "0xA42E70", VA = "0xA42E70")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6001728")]
		[Address(RVA = "0xA42E78", Offset = "0xA42E78", VA = "0xA42E78")]
		internal WeaponUnlockable _003CGetMaxPowerUpSlotCountForAllWeapons_003Eb__0(LazyWeaponUnlockable w)
		{
			return null;
		}
	}

	[Token(Token = "0x20003B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59360C", Offset = "0x59360C")]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x10")]
		public string resourceName;

		[Token(Token = "0x6001729")]
		[Address(RVA = "0xA42EC0", Offset = "0xA42EC0", VA = "0xA42EC0")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x600172A")]
		[Address(RVA = "0xA42EC8", Offset = "0xA42EC8", VA = "0xA42EC8")]
		internal bool _003CPartQuantityRequired_003Eb__0(RequiredPartInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x0")]
	public static EventHandler OnWeaponAssembled;

	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x8")]
	public static EventHandler OnWeaponCompleted;

	[Token(Token = "0x4001503")]
	[FieldOffset(Offset = "0x58")]
	public bool BlueprintCompleteByDefault;

	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x59")]
	public bool AssembledByDefault;

	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x5A")]
	public bool UnlockedByTokens;

	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x60")]
	public RequiredPartInfo[] RequiredPartsInfo;

	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x68")]
	public LazyWeapon Weapon;

	[Token(Token = "0x4001508")]
	[FieldOffset(Offset = "0x70")]
	public LazyGameObject UIWeapon;

	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x78")]
	public OfferReference UpgradeOffer;

	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x80")]
	public WeaponXPUpgrade[] Upgrades;

	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x88")]
	public LazyMaterial LockedMaterial;

	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 VisualWeaponHolderScale;

	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0x9C")]
	public Vector3 VisualWeaponHolderScaleWithExtraDisplay;

	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0xA8")]
	public Vector2 VisualWeaponHolderAnchorOffsetWithExtraDisplay;

	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0xB0")]
	public LazyGameObject ExtraUIDisplay;

	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 ExtraUIDisplayAnchorOffset;

	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0xC0")]
	public Color ArmoryBackLightColor;

	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0xD0")]
	public Color ArmoryKeyLightColor;

	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0xE0")]
	public bool UnlocksAllIntel;

	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0xE1")]
	public bool HalfPricePerk;

	[Token(Token = "0x4001515")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private BlueprintItemViewCustomization _customization;

	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private LazyWeaponSuggestionImage _weaponSuggestionPrefab;

	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0xF8")]
	private WeaponTier _tier;

	[Token(Token = "0x170003B1")]
	public BlueprintItemViewCustomization Customization
	{
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x879930", Offset = "0x879930", VA = "0x879930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B2")]
	public WeaponSuggestionImage WeaponSuggestionPrefab
	{
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x879938", Offset = "0x879938", VA = "0x879938")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B3")]
	public WeaponTier Tier
	{
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x879ACC", Offset = "0x879ACC", VA = "0x879ACC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x879AD4", Offset = "0x879AD4", VA = "0x879AD4")]
		set
		{
		}
	}

	[Token(Token = "0x170003B4")]
	public WeaponData WeaponData
	{
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x879B58", Offset = "0x879B58", VA = "0x879B58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B5")]
	public new WeaponUnlockableSaveData UnlockableData
	{
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x879C10", Offset = "0x879C10", VA = "0x879C10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x879C8C", Offset = "0x879C8C", VA = "0x879C8C")]
		set
		{
		}
	}

	[Token(Token = "0x170003B6")]
	public override bool Unlocked
	{
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x879C94", Offset = "0x879C94", VA = "0x879C94", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x879DF8", Offset = "0x879DF8", VA = "0x879DF8")]
	public static int GetMaxModSlotCountForAllWeapons()
	{
		return default(int);
	}

	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x87A2C4", Offset = "0x87A2C4", VA = "0x87A2C4")]
	public static int GetMaxPowerUpSlotCountForAllWeapons()
	{
		return default(int);
	}

	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x87A720", Offset = "0x87A720", VA = "0x87A720")]
	public void Complete(bool showNewFeedback)
	{
	}

	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x87A7B8", Offset = "0x87A7B8", VA = "0x87A7B8")]
	public void Assemble(bool showNewFeedback)
	{
	}

	[Token(Token = "0x60016EB")]
	[Address(RVA = "0x87A938", Offset = "0x87A938", VA = "0x87A938")]
	public int PartQuantityRequired(string resourceName)
	{
		return default(int);
	}

	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x87AA40", Offset = "0x87AA40", VA = "0x87AA40")]
	public void GetPartsCollectionInfo(out int numToCollect, out int numCollected, out int numCompleted)
	{
	}

	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x87ACD0", Offset = "0x87ACD0", VA = "0x87ACD0", Slot = "8")]
	public override void Equip(PlayerController player)
	{
	}

	[Token(Token = "0x60016EE")]
	[Address(RVA = "0x87B190", Offset = "0x87B190", VA = "0x87B190", Slot = "9")]
	public override void UnEquip()
	{
	}

	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x87B340", Offset = "0x87B340", VA = "0x87B340", Slot = "7")]
	public override void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x87AE40", Offset = "0x87AE40", VA = "0x87AE40")]
	private List<WeaponMod> GetUnlockedMods()
	{
		return null;
	}

	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x87B434", Offset = "0x87B434", VA = "0x87B434")]
	private bool IsCustomizableModSlotFilled(WeaponUnlockableSaveData.AttachmentSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x87B4DC", Offset = "0x87B4DC", VA = "0x87B4DC")]
	public float GetPreviousScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x87B76C", Offset = "0x87B76C", VA = "0x87B76C")]
	public float GetCurrentScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x87B85C", Offset = "0x87B85C", VA = "0x87B85C")]
	public float GetNextScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x87BACC", Offset = "0x87BACC", VA = "0x87BACC")]
	public float GetMaxScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x87B7B8", Offset = "0x87B7B8", VA = "0x87B7B8")]
	public float GetCurrentLevelScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x87BC24", Offset = "0x87BC24", VA = "0x87BC24")]
	public float GetNextLevelScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x87BC98", Offset = "0x87BC98", VA = "0x87BC98")]
	public float GetMaxLevelScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x87B548", Offset = "0x87B548", VA = "0x87B548")]
	private float GetScoreMultiplierForUpgradeIndex(int upgradeIndex)
	{
		return default(float);
	}

	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x87BCD0", Offset = "0x87BCD0", VA = "0x87BCD0", Slot = "10")]
	public virtual int GetUpgradeIndex(int xp, bool ignoreUnlockables = false)
	{
		return default(int);
	}

	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x87BEF8", Offset = "0x87BEF8", VA = "0x87BEF8")]
	public int GetUpgradeLevel(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x87BF00", Offset = "0x87BF00", VA = "0x87BF00")]
	public int GetMaxUpgrades()
	{
		return default(int);
	}

	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x87A248", Offset = "0x87A248", VA = "0x87A248")]
	public int GetMaxModSlots()
	{
		return default(int);
	}

	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x87A718", Offset = "0x87A718", VA = "0x87A718")]
	public int GetMaxPowerUpSlots()
	{
		return default(int);
	}

	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x87BFA4", Offset = "0x87BFA4", VA = "0x87BFA4")]
	public int GetCurrentPowerUpCount()
	{
		return default(int);
	}

	[Token(Token = "0x6001700")]
	[Address(RVA = "0x87BF1C", Offset = "0x87BF1C", VA = "0x87BF1C")]
	private int GetPowerUpCount(int xp)
	{
		return default(int);
	}

	[Token(Token = "0x6001701")]
	[Address(RVA = "0x87BFD4", Offset = "0x87BFD4", VA = "0x87BFD4")]
	public WeaponXPUpgrade GetCurrentUpgrade()
	{
		return null;
	}

	[Token(Token = "0x6001702")]
	[Address(RVA = "0x87C03C", Offset = "0x87C03C", VA = "0x87C03C")]
	public WeaponXPUpgrade GetNextUpgrade()
	{
		return null;
	}

	[Token(Token = "0x6001703")]
	[Address(RVA = "0x87C09C", Offset = "0x87C09C", VA = "0x87C09C")]
	public WeaponXPUpgrade GetUpgradeByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6001704")]
	[Address(RVA = "0x87C0E4", Offset = "0x87C0E4", VA = "0x87C0E4")]
	public void SetUpgradedData(WeaponData data)
	{
	}

	[Token(Token = "0x6001705")]
	[Address(RVA = "0x87C3B4", Offset = "0x87C3B4", VA = "0x87C3B4")]
	public void SetDataClipSize(WeaponData data, GameplayConfig config, int grade)
	{
	}

	[Token(Token = "0x6001706")]
	[Address(RVA = "0x87C400", Offset = "0x87C400", VA = "0x87C400")]
	public void SetDataSway(WeaponData data, GameplayConfig config, int grade)
	{
	}

	[Token(Token = "0x6001707")]
	[Address(RVA = "0x87C4B8", Offset = "0x87C4B8", VA = "0x87C4B8")]
	public void SetDataFirerate(WeaponData data, GameplayConfig config, int grade)
	{
	}

	[Token(Token = "0x6001708")]
	[Address(RVA = "0x87C5B8", Offset = "0x87C5B8", VA = "0x87C5B8")]
	public void SetDataDamage(WeaponData data, GameplayConfig config, int grade)
	{
	}

	[Token(Token = "0x6001709")]
	[Address(RVA = "0x87C618", Offset = "0x87C618", VA = "0x87C618")]
	public void SetDataBulletSpeed(WeaponData data, GameplayConfig config, int grade)
	{
	}

	[Token(Token = "0x600170A")]
	[Address(RVA = "0x87C678", Offset = "0x87C678", VA = "0x87C678", Slot = "11")]
	public virtual int GetCurrentUpgradeIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600170B")]
	[Address(RVA = "0x87B660", Offset = "0x87B660", VA = "0x87B660")]
	public WeaponMasteryUpgrade GetPreviousMasteryUpgrade()
	{
		return default(WeaponMasteryUpgrade);
	}

	[Token(Token = "0x600170C")]
	[Address(RVA = "0x87C6B4", Offset = "0x87C6B4", VA = "0x87C6B4")]
	public WeaponMasteryUpgrade GetCurrentMasteryUpgrade()
	{
		return default(WeaponMasteryUpgrade);
	}

	[Token(Token = "0x600170D")]
	[Address(RVA = "0x87B920", Offset = "0x87B920", VA = "0x87B920")]
	public WeaponMasteryUpgrade GetNextMasteryUpgrade()
	{
		return default(WeaponMasteryUpgrade);
	}

	[Token(Token = "0x600170E")]
	[Address(RVA = "0x87BB2C", Offset = "0x87BB2C", VA = "0x87BB2C")]
	public WeaponMasteryUpgrade GetMaxMasteryUpgrade()
	{
		return default(WeaponMasteryUpgrade);
	}

	[Token(Token = "0x600170F")]
	[Address(RVA = "0x87B7E8", Offset = "0x87B7E8", VA = "0x87B7E8")]
	public float GetCurrentMasteryScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6001710")]
	[Address(RVA = "0x87C7E0", Offset = "0x87C7E0", VA = "0x87C7E0")]
	public float GetNextMasteryScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6001711")]
	[Address(RVA = "0x87C924", Offset = "0x87C924", VA = "0x87C924")]
	public float GetMaxMasteryScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6001712")]
	[Address(RVA = "0x87BA4C", Offset = "0x87BA4C", VA = "0x87BA4C")]
	public float GetFullyMasteredScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6001713")]
	[Address(RVA = "0x87C998", Offset = "0x87C998", VA = "0x87C998")]
	public void ConvertTokensToXp()
	{
	}

	[Token(Token = "0x6001714")]
	[Address(RVA = "0x878DDC", Offset = "0x878DDC", VA = "0x878DDC")]
	public bool IsMaxLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6001715")]
	[Address(RVA = "0x879080", Offset = "0x879080", VA = "0x879080")]
	public bool IsMaxMasteryLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6001716")]
	[Address(RVA = "0x87C874", Offset = "0x87C874", VA = "0x87C874")]
	public bool IsOneBeforeMaxMastery()
	{
		return default(bool);
	}

	[Token(Token = "0x6001717")]
	[Address(RVA = "0x87CB38", Offset = "0x87CB38", VA = "0x87CB38")]
	public Unlockable GetNextLevelUnlockable()
	{
		return null;
	}

	[Token(Token = "0x6001718")]
	[Address(RVA = "0x87CAD0", Offset = "0x87CAD0", VA = "0x87CAD0")]
	public WeaponXPUpgrade GetHighestUpgrade()
	{
		return null;
	}

	[Token(Token = "0x6001719")]
	[Address(RVA = "0x87BA9C", Offset = "0x87BA9C", VA = "0x87BA9C")]
	public int GetNextUpgradeIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600171A")]
	[Address(RVA = "0x87CC90", Offset = "0x87CC90", VA = "0x87CC90")]
	public int GetNextUpgradeIndex(int xpFrom)
	{
		return default(int);
	}

	[Token(Token = "0x600171B")]
	[Address(RVA = "0x87CEA8", Offset = "0x87CEA8", VA = "0x87CEA8")]
	public bool IsOnSale()
	{
		return default(bool);
	}

	[Token(Token = "0x600171C")]
	[Address(RVA = "0x87CF88", Offset = "0x87CF88", VA = "0x87CF88")]
	public bool IsFullyCustomizable()
	{
		return default(bool);
	}

	[Token(Token = "0x600171D")]
	[Address(RVA = "0x87D158", Offset = "0x87D158", VA = "0x87D158")]
	public WeaponUnlockable()
	{
	}
}
