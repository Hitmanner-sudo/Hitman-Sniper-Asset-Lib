using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Distribution;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x20004AF")]
public class PlayerProfileData : ScriptableObject, ISaveable
{
	[Token(Token = "0x20004B0")]
	public class WeaponUnlockableChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4001961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string UnlockableName;

		[Token(Token = "0x4001962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string UnlockablePath;

		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x8D3DCC", Offset = "0x8D3DCC", VA = "0x8D3DCC")]
		public WeaponUnlockableChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x20004B1")]
	private class ReferenceCountedUnlockable<T>
	{
		[Token(Token = "0x4001963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly T Item;

		[Token(Token = "0x4001964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int RefCount;

		[Token(Token = "0x1700047D")]
		public bool CanBeUnloaded
		{
			[Token(Token = "0x6001CEB")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001CEC")]
		public ReferenceCountedUnlockable(T item)
		{
		}
	}

	[Token(Token = "0x20004B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C68", Offset = "0x594C68")]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		[Token(Token = "0x4001965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Bundle b;

		[Token(Token = "0x4001966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayerProfileData _003C_003E4__this;

		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x8D3C5C", Offset = "0x8D3C5C", VA = "0x8D3C5C")]
		public _003C_003Ec__DisplayClass68_0()
		{
		}

		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x8D3C64", Offset = "0x8D3C64", VA = "0x8D3C64")]
		internal bool _003COnBundleLoaded_003Eb__0(LazyWeaponUnlockable w)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x8D3CB0", Offset = "0x8D3CB0", VA = "0x8D3CB0")]
		internal bool _003COnBundleLoaded_003Eb__1(LazyWeaponUnlockable w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C78", Offset = "0x594C78")]
	private sealed class _003C_003Ec__DisplayClass68_1
	{
		[Token(Token = "0x4001967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4001968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x8D3CFC", Offset = "0x8D3CFC", VA = "0x8D3CFC")]
		public _003C_003Ec__DisplayClass68_1()
		{
		}

		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x8D3D04", Offset = "0x8D3D04", VA = "0x8D3D04")]
		internal WeaponUnlockableChangedEventArgs _003COnBundleLoaded_003Eb__2()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x20004B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C88", Offset = "0x594C88")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400196A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<AttachmentsUnlockableSaveData, WeaponPart> _003C_003E9__80_0;

		[Token(Token = "0x400196B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<AttachmentsUnlockableSaveData, WeaponMod> _003C_003E9__82_0;

		[Token(Token = "0x400196C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<AttachmentsUnlockableSaveData, PowerUp> _003C_003E9__83_0;

		[Token(Token = "0x400196D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<ResourceUnlockableSaveData, ResourceUnlockable> _003C_003E9__84_0;

		[Token(Token = "0x400196E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<UnlockableSaveData, IntelUnlockable> _003C_003E9__85_0;

		[Token(Token = "0x400196F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<UnlockableSaveData, Unlockable> _003C_003E9__86_0;

		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x8D3BFC", Offset = "0x8D3BFC", VA = "0x8D3BFC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x8D3C04", Offset = "0x8D3C04", VA = "0x8D3C04")]
		internal void _003CPatchUpWeaponPartUnlockableList_003Eb__80_0(AttachmentsUnlockableSaveData sd, WeaponPart u)
		{
		}

		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x8D3C28", Offset = "0x8D3C28", VA = "0x8D3C28")]
		internal void _003CPatchUpWeaponModsList_003Eb__82_0(AttachmentsUnlockableSaveData sd, WeaponMod u)
		{
		}

		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x8D3C4C", Offset = "0x8D3C4C", VA = "0x8D3C4C")]
		internal void _003CPatchUpPowerUpsList_003Eb__83_0(AttachmentsUnlockableSaveData sd, PowerUp u)
		{
		}

		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x8D3C50", Offset = "0x8D3C50", VA = "0x8D3C50")]
		internal void _003CPatchUpResourcesList_003Eb__84_0(ResourceUnlockableSaveData sd, ResourceUnlockable u)
		{
		}

		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x8D3C54", Offset = "0x8D3C54", VA = "0x8D3C54")]
		internal void _003CPatchUpIntelUnlockableList_003Eb__85_0(UnlockableSaveData sd, IntelUnlockable u)
		{
		}

		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x8D3C58", Offset = "0x8D3C58", VA = "0x8D3C58")]
		internal void _003CPatchUpWeaponUpgradeUnlockableList_003Eb__86_0(UnlockableSaveData sd, Unlockable u)
		{
		}
	}

	[Token(Token = "0x20004B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C98", Offset = "0x594C98")]
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		[Token(Token = "0x4001970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string itemId;

		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x8D3E30", Offset = "0x8D3E30", VA = "0x8D3E30")]
		public _003C_003Ec__DisplayClass88_0()
		{
		}

		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x8D3E38", Offset = "0x8D3E38", VA = "0x8D3E38")]
		internal bool _003CWeaponUnlockablePreUnload_003Eb__0(Credit c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594CA8", Offset = "0x594CA8")]
	private sealed class _003C_003Ec__DisplayClass89_0
	{
		[Token(Token = "0x4001971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LazyPowerUp powerUpRef;

		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x8D3E58", Offset = "0x8D3E58", VA = "0x8D3E58")]
		public _003C_003Ec__DisplayClass89_0()
		{
		}

		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x8D3E60", Offset = "0x8D3E60", VA = "0x8D3E60")]
		internal bool _003CPreUnloadPowerUps_003Eb__0(LazyPowerUp s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594CB8", Offset = "0x594CB8")]
	private sealed class _003C_003Ec__DisplayClass90_0
	{
		[Token(Token = "0x4001972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LazyWeaponMod weaponModRef;

		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x8D3EC0", Offset = "0x8D3EC0", VA = "0x8D3EC0")]
		public _003C_003Ec__DisplayClass90_0()
		{
		}

		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x8D3EC8", Offset = "0x8D3EC8", VA = "0x8D3EC8")]
		internal bool _003CPreUnloadMods_003Eb__0(LazyWeaponMod s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594CC8", Offset = "0x594CC8")]
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		[Token(Token = "0x4001973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x8D3F28", Offset = "0x8D3F28", VA = "0x8D3F28")]
		public _003C_003Ec__DisplayClass93_0()
		{
		}

		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x8D3F30", Offset = "0x8D3F30", VA = "0x8D3F30")]
		internal bool _003CGetSaveData_003Eb__0(LazyWeaponPart s)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x8D3F70", Offset = "0x8D3F70", VA = "0x8D3F70")]
		internal bool _003CGetSaveData_003Eb__1(LazyWeaponMod s)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x8D3FB0", Offset = "0x8D3FB0", VA = "0x8D3FB0")]
		internal bool _003CGetSaveData_003Eb__2(LazyPowerUp s)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x8D3FF0", Offset = "0x8D3FF0", VA = "0x8D3FF0")]
		internal bool _003CGetSaveData_003Eb__3(LazyWeaponUnlockable s)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x8D4030", Offset = "0x8D4030", VA = "0x8D4030")]
		internal bool _003CGetSaveData_003Eb__4(LazyResourceUnlockable s)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x8D4070", Offset = "0x8D4070", VA = "0x8D4070")]
		internal bool _003CGetSaveData_003Eb__5(LazyIntelUnlockable s)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x8D40B0", Offset = "0x8D40B0", VA = "0x8D40B0")]
		internal bool _003CGetSaveData_003Eb__6(LazyUnlockable s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594CD8", Offset = "0x594CD8")]
	private sealed class _003C_003Ec__DisplayClass94_0
	{
		[Token(Token = "0x4001974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x8D40F0", Offset = "0x8D40F0", VA = "0x8D40F0")]
		public _003C_003Ec__DisplayClass94_0()
		{
		}

		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x8D40F8", Offset = "0x8D40F8", VA = "0x8D40F8")]
		internal bool _003CGetWeaponPowerUpIndex_003Eb__0(LazyPowerUp s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594CE8", Offset = "0x594CE8")]
	private sealed class _003C_003Ec__DisplayClass95_0
	{
		[Token(Token = "0x4001975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x8D4138", Offset = "0x8D4138", VA = "0x8D4138")]
		public _003C_003Ec__DisplayClass95_0()
		{
		}

		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x8D4140", Offset = "0x8D4140", VA = "0x8D4140")]
		internal bool _003CGetWeaponModIndex_003Eb__0(LazyWeaponMod s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594CF8", Offset = "0x594CF8")]
	private sealed class _003C_003Ec__DisplayClass96_0
	{
		[Token(Token = "0x4001976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Unlockable unlockable;

		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x8D4180", Offset = "0x8D4180", VA = "0x8D4180")]
		public _003C_003Ec__DisplayClass96_0()
		{
		}

		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x8D4188", Offset = "0x8D4188", VA = "0x8D4188")]
		internal bool _003CGetResourcePath_003Eb__0(UnlockableSaveData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594D08", Offset = "0x594D08")]
	private sealed class _003C_003Ec__DisplayClass103_0<TUnlockable, TArray> where TUnlockable : Unlockable where TArray : TLazyScriptableObject<TUnlockable>
	{
		[Token(Token = "0x4001977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string unlockableResource;

		[Token(Token = "0x6001D0E")]
		public _003C_003Ec__DisplayClass103_0()
		{
		}

		[Token(Token = "0x6001D0F")]
		internal bool _003CLoadUnlockable_003Eb__0(TArray s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20004BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594D18", Offset = "0x594D18")]
	private sealed class _003C_003Ec__DisplayClass104_0<TUnlockable, TSaveData> where TUnlockable : Unlockable where TSaveData : UnlockableSaveData
	{
		[Token(Token = "0x4001978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TSaveData saveData;

		[Token(Token = "0x6001D10")]
		public _003C_003Ec__DisplayClass104_0()
		{
		}

		[Token(Token = "0x6001D11")]
		internal bool _003CLoadUnlockable_003Eb__0(TSaveData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400192D")]
	private const string PLAYERPROGRESSIONDATA_FILENAME = "PlayerProgressionData";

	[Token(Token = "0x400192E")]
	private const string PENDING_BOXES_NODE_NAME = "_pendingBoxes";

	[Token(Token = "0x4001930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LazyPlayerProgressionData ProgressionData;

	[Token(Token = "0x4001931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LazyFacebookData FacebookData;

	[Token(Token = "0x4001932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int StartWeaponIdx;

	[Token(Token = "0x4001933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6FEC", Offset = "0x5B6FEC")]
	public LeaderboardData LeaderboardData;

	[NonSerialized]
	[Token(Token = "0x4001934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6FFC", Offset = "0x5B6FFC")]
	public string PlayerProfileName;

	[NonSerialized]
	[Token(Token = "0x4001935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B700C", Offset = "0x5B700C")]
	public int FriendInvitedCount;

	[NonSerialized]
	[Token(Token = "0x4001936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B701C", Offset = "0x5B701C")]
	public int Rank;

	[NonSerialized]
	[Token(Token = "0x4001937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B702C", Offset = "0x5B702C")]
	public int Level;

	[NonSerialized]
	[Token(Token = "0x4001938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B703C", Offset = "0x5B703C")]
	public int StarCount;

	[NonSerialized]
	[Token(Token = "0x4001939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B704C", Offset = "0x5B704C")]
	public int NumPlaythroughs;

	[NonSerialized]
	[Token(Token = "0x400193A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public WeaponUnlockable.LazyWeapon Weapon;

	[NonSerialized]
	[Token(Token = "0x400193B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int CurrentWeaponIdx;

	[NonSerialized]
	[Token(Token = "0x400193C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B705C", Offset = "0x5B705C")]
	public int CurrentContractWeaponIdx;

	[NonSerialized]
	[Token(Token = "0x400193D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B706C", Offset = "0x5B706C")]
	public int SelectedContract;

	[NonSerialized]
	[Token(Token = "0x400193E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B707C", Offset = "0x5B707C")]
	public bool HasPostedEveryplayVideo;

	[Token(Token = "0x400193F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B708C", Offset = "0x5B708C")]
	private List<LootBox> _pendingBoxes;

	[Token(Token = "0x4001940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B709C", Offset = "0x5B709C")]
	private List<string> _lootBoxUpdates;

	[Token(Token = "0x4001941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B70AC", Offset = "0x5B70AC")]
	private DailyRewardsData _dailyRewardsData;

	[Token(Token = "0x4001942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B70E4", Offset = "0x5B70E4")]
	private DailyRewardsData _challengeDailyRewardsData;

	[Token(Token = "0x4001943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B711C", Offset = "0x5B711C")]
	private NotificationPermissionData _notificationPermissionData;

	[Token(Token = "0x4001944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B712C", Offset = "0x5B712C")]
	private JustCauseRifleAdData _justCauseRifleAdData;

	[Token(Token = "0x4001945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B713C", Offset = "0x5B713C")]
	private InsufficientFundsAdData _insufficientFundsAdData;

	[Token(Token = "0x4001946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7174", Offset = "0x5B7174")]
	private GDPRData _gdprData;

	[Token(Token = "0x4001947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Dictionary<string, RogueData> RoguePartDrops;

	[Token(Token = "0x4001948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public LazyWeaponUnlockable[] WeaponUnlockables;

	[Token(Token = "0x4001949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public LazyWeaponPart[] WeaponParts;

	[Token(Token = "0x400194A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LazyWeaponMod[] WeaponMods;

	[Token(Token = "0x400194B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public LazyPowerUp[] PowerUps;

	[Token(Token = "0x400194C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public LazyResourceUnlockable[] ResourceUnlockables;

	[Token(Token = "0x400194D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public LazyIntelUnlockable[] IntelUnlockables;

	[Token(Token = "0x400194E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public LazyUnlockable[] WeaponUpgradeUnlockables;

	[NonSerialized]
	[Token(Token = "0x400194F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7184", Offset = "0x5B7184")]
	public WeaponUnlockableSaveData[] WeaponUnlockablesSaveData;

	[NonSerialized]
	[Token(Token = "0x4001950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7194", Offset = "0x5B7194")]
	public AttachmentsUnlockableSaveData[] WeaponPartsSaveData;

	[NonSerialized]
	[Token(Token = "0x4001951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B71A4", Offset = "0x5B71A4")]
	public AttachmentsUnlockableSaveData[] WeaponModsSaveData;

	[NonSerialized]
	[Token(Token = "0x4001952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B71B4", Offset = "0x5B71B4")]
	public AttachmentsUnlockableSaveData[] PowerUpsSaveData;

	[NonSerialized]
	[Token(Token = "0x4001953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B71C4", Offset = "0x5B71C4")]
	public ResourceUnlockableSaveData[] ResourceUnlockablesSaveData;

	[NonSerialized]
	[Token(Token = "0x4001954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B71D4", Offset = "0x5B71D4")]
	public UnlockableSaveData[] IntelUnlockableSaveData;

	[NonSerialized]
	[Token(Token = "0x4001955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B71E4", Offset = "0x5B71E4")]
	public UnlockableSaveData[] WeaponUpgradeUnlockableSaveData;

	[Token(Token = "0x4001956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ReferenceCountedUnlockable<WeaponUnlockable>[] _weaponUnlockablesResource;

	[Token(Token = "0x4001957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private ReferenceCountedUnlockable<WeaponPart>[] _weaponPartsResource;

	[Token(Token = "0x4001958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ReferenceCountedUnlockable<WeaponMod>[] _weaponModsResource;

	[Token(Token = "0x4001959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ReferenceCountedUnlockable<PowerUp>[] _powerUpsResource;

	[Token(Token = "0x400195A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private ReferenceCountedUnlockable<ResourceUnlockable>[] _resourceUnlockablesResource;

	[Token(Token = "0x400195B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ReferenceCountedUnlockable<IntelUnlockable>[] _intelUnlockablesResources;

	[Token(Token = "0x400195C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ReferenceCountedUnlockable<Unlockable>[] _weaponUpgradeUnlockablesResources;

	[NonSerialized]
	[Token(Token = "0x400195D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private WeaponUnlockable _currentWeaponUnlockable;

	[Token(Token = "0x400195E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B71F4", Offset = "0x5B71F4")]
	public PlayerReferralData PlayerReferralData;

	[Token(Token = "0x400195F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7204", Offset = "0x5B7204")]
	public DeepLinkFriendData FriendData;

	[Token(Token = "0x4001960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<UnlockableSaveData> _itemsFreshlyCreated;

	[Token(Token = "0x17000476")]
	public ReadOnlyCollection<LootBox> PendingLootBoxes
	{
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0xAADA9C", Offset = "0xAADA9C", VA = "0xAADA9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000477")]
	public DailyRewardsData DailyRewardsData
	{
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0xAADAF0", Offset = "0xAADAF0", VA = "0xAADAF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000478")]
	public DailyRewardsData ChallengeDailyRewardsData
	{
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0xAADAF8", Offset = "0xAADAF8", VA = "0xAADAF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000479")]
	public NotificationPermissionData NotifcationPermissionData
	{
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0xAADB00", Offset = "0xAADB00", VA = "0xAADB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047A")]
	public JustCauseRifleAdData JustCauseRifleAdData
	{
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0xAADB08", Offset = "0xAADB08", VA = "0xAADB08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047B")]
	public InsufficientFundsAdData InsufficientFundsAdData
	{
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0xAADB10", Offset = "0xAADB10", VA = "0xAADB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047C")]
	public GDPRData GDPRData
	{
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0xAADB18", Offset = "0xAADB18", VA = "0xAADB18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000071")]
	public event EventHandler<WeaponUnlockableChangedEventArgs> OnWeaponUnlockableUpdated
	{
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0xAAD95C", Offset = "0xAAD95C", VA = "0xAAD95C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6186D8", Offset = "0x6186D8")]
		add
		{
		}
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0xAAD9FC", Offset = "0xAAD9FC", VA = "0xAAD9FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6186E8", Offset = "0x6186E8")]
		remove
		{
		}
	}

	[Token(Token = "0x6001C99")]
	[Address(RVA = "0xAADB20", Offset = "0xAADB20", VA = "0xAADB20")]
	private void OnBundleLoaded(Bundle b)
	{
	}

	[Token(Token = "0x6001C9A")]
	[Address(RVA = "0xAAE27C", Offset = "0xAAE27C", VA = "0xAAE27C")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0xAAE3E0", Offset = "0xAAE3E0", VA = "0xAAE3E0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0xAAE4A4", Offset = "0xAAE4A4", VA = "0xAAE4A4")]
	public void AddPendingBox(LootBox box)
	{
	}

	[Token(Token = "0x6001C9D")]
	[Address(RVA = "0xAAE59C", Offset = "0xAAE59C", VA = "0xAAE59C")]
	public void RemovePendingBox(LootBox box)
	{
	}

	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0xAAE654", Offset = "0xAAE654", VA = "0xAAE654")]
	public void ClaimAllPengingBoxes([Optional] Func<LootBox, bool> filter)
	{
	}

	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0xAAE78C", Offset = "0xAAE78C", VA = "0xAAE78C")]
	public void UnloadUnreferencedResources()
	{
	}

	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0xAAE8A8", Offset = "0xAAE8A8", VA = "0xAAE8A8")]
	public void PreLoadProfileData()
	{
	}

	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0xAAE900", Offset = "0xAAE900", VA = "0xAAE900")]
	public void ResetUnlockables()
	{
	}

	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0xAAF1D8", Offset = "0xAAF1D8", VA = "0xAAF1D8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0xAAE8AC", Offset = "0xAAE8AC", VA = "0xAAE8AC")]
	private void PatchUpUnlockableLists()
	{
	}

	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0xAAF270", Offset = "0xAAF270", VA = "0xAAF270")]
	private void PatchUpWeaponPartUnlockableList()
	{
	}

	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0xAAF4E0", Offset = "0xAAF4E0", VA = "0xAAF4E0")]
	private void PatchUpWeaponUnlockableList()
	{
	}

	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0xAAF6E0", Offset = "0xAAF6E0", VA = "0xAAF6E0")]
	private void PatchUpWeaponModsList()
	{
	}

	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0xAAF950", Offset = "0xAAF950", VA = "0xAAF950")]
	private void PatchUpPowerUpsList()
	{
	}

	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0xAAFBC0", Offset = "0xAAFBC0", VA = "0xAAFBC0")]
	private void PatchUpResourcesList()
	{
	}

	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0xAAFE30", Offset = "0xAAFE30", VA = "0xAAFE30")]
	private void PatchUpIntelUnlockableList()
	{
	}

	[Token(Token = "0x6001CAA")]
	[Address(RVA = "0xAB00A0", Offset = "0xAB00A0", VA = "0xAB00A0")]
	private void PatchUpWeaponUpgradeUnlockableList()
	{
	}

	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0xAADE70", Offset = "0xAADE70", VA = "0xAADE70")]
	public void PatchProgressionLockedUnlockableSaveData()
	{
	}

	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0xAB07AC", Offset = "0xAB07AC", VA = "0xAB07AC")]
	private void WeaponUnlockablePreUnload(WeaponUnlockableSaveData item, WeaponUnlockable unlockable)
	{
	}

	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0xAB0A2C", Offset = "0xAB0A2C", VA = "0xAB0A2C")]
	private void PreUnloadPowerUps(WeaponUnlockableSaveData item, WeaponUnlockable unlockable)
	{
	}

	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0xAB0CFC", Offset = "0xAB0CFC", VA = "0xAB0CFC")]
	private void PreUnloadMods(WeaponUnlockableSaveData item, WeaponUnlockable unlockable)
	{
	}

	[Token(Token = "0x6001CAF")]
	private static void LoadUnlockable<TUnlockable, TUnlockableSave, TScriptableObject>(TLazyScriptableObject<TScriptableObject>[] unlockables, TUnlockableSave[] savedata, Func<int, TUnlockable> load, Action<TUnlockableSave, TUnlockable> preunload, Func<TUnlockable, bool> unload) where TUnlockable : Unlockable where TUnlockableSave : UnlockableSaveData where TScriptableObject : ScriptableObject
	{
	}

	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0xAB0310", Offset = "0xAB0310", VA = "0xAB0310")]
	public UnlockableSaveData GetSaveData(string path)
	{
		return null;
	}

	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0xAB0FDC", Offset = "0xAB0FDC", VA = "0xAB0FDC")]
	public int GetWeaponPowerUpIndex(string path)
	{
		return default(int);
	}

	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0xAB10C8", Offset = "0xAB10C8", VA = "0xAB10C8")]
	public int GetWeaponModIndex(string path)
	{
		return default(int);
	}

	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0xAB11B4", Offset = "0xAB11B4", VA = "0xAB11B4")]
	public string GetResourcePath(Unlockable unlockable)
	{
		return null;
	}

	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0xAAE17C", Offset = "0xAAE17C", VA = "0xAAE17C")]
	public void UpdateCurrentWeapon()
	{
	}

	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0xAB1604", Offset = "0xAB1604", VA = "0xAB1604")]
	public bool IsLoadedCurrentWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0xAB1654", Offset = "0xAB1654", VA = "0xAB1654")]
	public WeaponUnlockable GetCurrentWeapon()
	{
		return null;
	}

	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0xAB16A8", Offset = "0xAB16A8", VA = "0xAB16A8")]
	public void SetCurrentWeapon(WeaponUnlockable newWeapon)
	{
	}

	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0xAB188C", Offset = "0xAB188C", VA = "0xAB188C")]
	public Unlockable LoadUnlockable(UnlockableSaveData unlockableData)
	{
		return null;
	}

	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0xAB2120", Offset = "0xAB2120", VA = "0xAB2120")]
	public Unlockable LoadUnlockable(string unlockableResource)
	{
		return null;
	}

	[Token(Token = "0x6001CBA")]
	private static TUnlockable LoadUnlockable<TUnlockable, TArray>(string unlockableResource, TArray[] unlockables, Func<int, TUnlockable> load) where TUnlockable : Unlockable where TArray : TLazyScriptableObject<TUnlockable>
	{
		return null;
	}

	[Token(Token = "0x6001CBB")]
	private static TUnlockable LoadUnlockable<TUnlockable, TSaveData>(TSaveData saveData, TSaveData[] unlockables, Func<int, TUnlockable> load) where TUnlockable : Unlockable where TSaveData : UnlockableSaveData
	{
		return null;
	}

	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0xAACB1C", Offset = "0xAACB1C", VA = "0xAACB1C")]
	public WeaponUnlockable LoadWeaponUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0xAB25F4", Offset = "0xAB25F4", VA = "0xAB25F4")]
	public WeaponUnlockable LoadWeaponUnlockable(string path)
	{
		return null;
	}

	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0xAB1E68", Offset = "0xAB1E68", VA = "0xAB1E68")]
	public WeaponUnlockable LoadWeaponUnlockable(WeaponUnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0xAB2AC0", Offset = "0xAB2AC0", VA = "0xAB2AC0")]
	public WeaponPart LoadWeaponPartUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0xAB233C", Offset = "0xAB233C", VA = "0xAB233C")]
	public WeaponPart LoadWeaponPartUnlockable(string path)
	{
		return null;
	}

	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0xAB1BB0", Offset = "0xAB1BB0", VA = "0xAB1BB0")]
	public WeaponPart LoadWeaponPartUnlockable(AttachmentsUnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0xAB2B5C", Offset = "0xAB2B5C", VA = "0xAB2B5C")]
	public WeaponMod LoadModUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0xAB2424", Offset = "0xAB2424", VA = "0xAB2424")]
	public WeaponMod LoadModUnlockable(string unlockableResource)
	{
		return null;
	}

	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0xAB1C98", Offset = "0xAB1C98", VA = "0xAB1C98")]
	public WeaponMod LoadModUnlockable(AttachmentsUnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0xAB2BF8", Offset = "0xAB2BF8", VA = "0xAB2BF8")]
	public PowerUp LoadPowerUpUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0xAB250C", Offset = "0xAB250C", VA = "0xAB250C")]
	public PowerUp LoadPowerUpUnlockable(string unlockableResource)
	{
		return null;
	}

	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0xAB1D80", Offset = "0xAB1D80", VA = "0xAB1D80")]
	public PowerUp LoadPowerUpUnlockable(AttachmentsUnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0xAB2C94", Offset = "0xAB2C94", VA = "0xAB2C94")]
	public ResourceUnlockable LoadResourceUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0xAB26DC", Offset = "0xAB26DC", VA = "0xAB26DC")]
	public ResourceUnlockable LoadResourceUnlockable(string unlockableResource)
	{
		return null;
	}

	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0xAB1F50", Offset = "0xAB1F50", VA = "0xAB1F50")]
	public ResourceUnlockable LoadResourceUnlockable(UnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0xAB2D30", Offset = "0xAB2D30", VA = "0xAB2D30")]
	public IntelUnlockable LoadIntelUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0xAB27C4", Offset = "0xAB27C4", VA = "0xAB27C4")]
	public IntelUnlockable LoadIntelUnlockable(string unlockableResource)
	{
		return null;
	}

	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0xAB2038", Offset = "0xAB2038", VA = "0xAB2038")]
	public IntelUnlockable LoadIntelUnlockable(UnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0xAB2DCC", Offset = "0xAB2DCC", VA = "0xAB2DCC")]
	public Unlockable LoadWeaponUpgradeUnlockable(int idx)
	{
		return null;
	}

	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0xAB28AC", Offset = "0xAB28AC", VA = "0xAB28AC")]
	public Unlockable LoadWeaponUpgradeUnlockable(string unlockableResource)
	{
		return null;
	}

	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0xAB2E68", Offset = "0xAB2E68", VA = "0xAB2E68")]
	public Unlockable LoadWeaponUpgradeUnlockable(UnlockableSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0xAAEF10", Offset = "0xAAEF10", VA = "0xAAEF10")]
	public bool UnloadUnlockable(Unlockable unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CD2")]
	private static T LoadResource<T>(ReferenceCountedUnlockable<T>[] resourcesArray, TLazyScriptableObject<T>[] resourceLazyRefArray, UnlockableSaveData[] unlockableSaveDataArray, int idx) where T : Unlockable
	{
		return null;
	}

	[Token(Token = "0x6001CD3")]
	private bool UnloadUnlockable<T>(ReferenceCountedUnlockable<T>[] resourcesArray, T unlockable) where T : Unlockable
	{
		return default(bool);
	}

	[Token(Token = "0x6001CD4")]
	private static void UnloadUnreferencedResources<T>(ReferenceCountedUnlockable<T>[] resources)
	{
	}

	[Token(Token = "0x6001CD5")]
	[Address(RVA = "0xAACCF0", Offset = "0xAACCF0", VA = "0xAACCF0")]
	public bool UnloadWeaponUnlockable(WeaponUnlockable unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CD6")]
	[Address(RVA = "0xAB2F50", Offset = "0xAB2F50", VA = "0xAB2F50")]
	public bool UnloadWeaponPartUnlockable(WeaponPart unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0xAB2FB0", Offset = "0xAB2FB0", VA = "0xAB2FB0")]
	public bool UnloadModUnlockable(WeaponMod unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0xAB3010", Offset = "0xAB3010", VA = "0xAB3010")]
	public bool UnloadPowerUpUnlockable(PowerUp unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0xAB3070", Offset = "0xAB3070", VA = "0xAB3070")]
	public bool UnloadResourceUnlockable(ResourceUnlockable unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0xAB30D0", Offset = "0xAB30D0", VA = "0xAB30D0")]
	public bool UnloadIntelUnlockable(IntelUnlockable unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0xAB3130", Offset = "0xAB3130", VA = "0xAB3130")]
	public bool UnloadWeaponUpgradeUnlockable(Unlockable unlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0xAB3190", Offset = "0xAB3190", VA = "0xAB3190")]
	public void BuildRogueDropTable()
	{
	}

	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0xAAF184", Offset = "0xAAF184", VA = "0xAAF184")]
	public void ClearRogueDropTable()
	{
	}

	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0xAB339C", Offset = "0xAB339C", VA = "0xAB339C")]
	public int GetCurrentTotalLevelFromRankLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0xAB33A4", Offset = "0xAB33A4", VA = "0xAB33A4")]
	public int GetTotalLevelFromRankLevel(int rank, int level)
	{
		return default(int);
	}

	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0xAB3470", Offset = "0xAB3470", VA = "0xAB3470")]
	public void SetWeaponToUse()
	{
	}

	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0xAB35F8", Offset = "0xAB35F8", VA = "0xAB35F8")]
	public bool IsHidden(LazyWeaponUnlockable lazyWeaponUnlockable, WeaponUnlockable weaponUnlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0xAB386C", Offset = "0xAB386C", VA = "0xAB386C")]
	public void AddLootBoxUpdate(JSONNode data)
	{
	}

	[Token(Token = "0x6001CE3")]
	[Address(RVA = "0xAB3B44", Offset = "0xAB3B44", VA = "0xAB3B44")]
	public DailyRewardsData GetDailyRewardsDataByItemId(string itemId)
	{
		return null;
	}

	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0xAB3BCC", Offset = "0xAB3BCC", VA = "0xAB3BCC", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0xAB40D0", Offset = "0xAB40D0", VA = "0xAB40D0", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0xAB3F0C", Offset = "0xAB3F0C", VA = "0xAB3F0C")]
	private void DeserializePendingBoxes(JSONNode data)
	{
	}

	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0xAB2994", Offset = "0xAB2994", VA = "0xAB2994")]
	private void SetWeaponTier(WeaponUnlockable weapon, LazyWeaponUnlockable[] lazyWeapons, int idx)
	{
	}

	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0xAB4148", Offset = "0xAB4148", VA = "0xAB4148")]
	public PlayerProfileData()
	{
	}
}
