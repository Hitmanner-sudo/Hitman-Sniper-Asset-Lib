using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200040B")]
public class RogueData : ScriptableObject, ISaveable
{
	[Serializable]
	[Token(Token = "0x200040C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593B30", Offset = "0x593B30")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40016AA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40016AB")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<LazyIntelUnlockable, IntelUnlockable> _003C_003E9__38_0;

		[Token(Token = "0x40016AC")]
		[FieldOffset(Offset = "0x10")]
		public static Func<OfferDescription, bool> _003C_003E9__44_0;

		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x8B4F18", Offset = "0x8B4F18", VA = "0x8B4F18")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x8B4F20", Offset = "0x8B4F20", VA = "0x8B4F20")]
		internal IntelUnlockable _003CInitRogueIntel_003Eb__38_0(LazyIntelUnlockable r)
		{
			return null;
		}

		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x8B4FC8", Offset = "0x8B4FC8", VA = "0x8B4FC8")]
		internal bool _003CIsAllIntelUnlockedWeaponOwned_003Eb__44_0(OfferDescription r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0x18")]
	public string GivenName;

	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0x20")]
	public string Name;

	[Token(Token = "0x4001695")]
	[FieldOffset(Offset = "0x28")]
	public Bark BioVoiceOver;

	[Token(Token = "0x4001696")]
	[FieldOffset(Offset = "0x30")]
	public string NicknameKey;

	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _givenNameKey;

	[Token(Token = "0x4001698")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string _lastNameKey;

	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LazyIntelUnlockable[] _rogueIntel;

	[Token(Token = "0x400169A")]
	[FieldOffset(Offset = "0x50")]
	public DropList DropList;

	[Token(Token = "0x400169B")]
	[FieldOffset(Offset = "0x58")]
	public int NumMissionsCompleted;

	[Token(Token = "0x400169C")]
	[FieldOffset(Offset = "0x60")]
	public LazyUITexture Picture;

	[Token(Token = "0x400169D")]
	[FieldOffset(Offset = "0x68")]
	public LazyUIAtlas IconAtlas;

	[Token(Token = "0x400169E")]
	[FieldOffset(Offset = "0x70")]
	public string IconName;

	[Token(Token = "0x400169F")]
	[FieldOffset(Offset = "0x78")]
	public string IconNameDamageLight;

	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x80")]
	public string IconNameDamageHeavy;

	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x88")]
	public string IconNameDead;

	[Token(Token = "0x40016A2")]
	[FieldOffset(Offset = "0x90")]
	public float InitialSpawnTime;

	[Token(Token = "0x40016A3")]
	[FieldOffset(Offset = "0x98")]
	public float[] RespawnTimes;

	[NonSerialized]
	[Token(Token = "0x40016A4")]
	[FieldOffset(Offset = "0xA0")]
	public IntelUnlockable[] RogueIntel;

	[NonSerialized]
	[Token(Token = "0x40016A5")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B584C", Offset = "0x5B584C")]
	public bool BioPlayed;

	[NonSerialized]
	[Token(Token = "0x40016A6")]
	[FieldOffset(Offset = "0xA9")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B585C", Offset = "0x5B585C")]
	public bool ShowNewFeedback;

	[NonSerialized]
	[Token(Token = "0x40016A7")]
	[FieldOffset(Offset = "0xAA")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B586C", Offset = "0x5B586C")]
	public bool Credited;

	[Token(Token = "0x40016A8")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private LazyAIController _overrideCharacterController;

	[Token(Token = "0x40016A9")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B588C", Offset = "0x5B588C")]
	private int _003CCurrentNumDespawns_003Ek__BackingField;

	[Token(Token = "0x170003F9")]
	public int CurrentNumDespawns
	{
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x9718BC", Offset = "0x9718BC", VA = "0x9718BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617674", Offset = "0x617674")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x9718C4", Offset = "0x9718C4", VA = "0x9718C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617684", Offset = "0x617684")]
		set
		{
		}
	}

	[Token(Token = "0x170003FA")]
	public string FullName
	{
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x9718CC", Offset = "0x9718CC", VA = "0x9718CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FB")]
	public string GivenNameLoc
	{
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x97191C", Offset = "0x97191C", VA = "0x97191C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FC")]
	public string NameLoc
	{
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x971984", Offset = "0x971984", VA = "0x971984")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FD")]
	public int IntelLevel
	{
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x971A80", Offset = "0x971A80", VA = "0x971A80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003FE")]
	public AIController OverrideCharacterController
	{
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x971EE0", Offset = "0x971EE0", VA = "0x971EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x9719EC", Offset = "0x9719EC", VA = "0x9719EC")]
	public string FullNameLoc(bool nameInUpper)
	{
		return null;
	}

	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x9720D4", Offset = "0x9720D4", VA = "0x9720D4")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x971AEC", Offset = "0x971AEC", VA = "0x971AEC")]
	private void InitRogueIntel()
	{
	}

	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x972154", Offset = "0x972154", VA = "0x972154")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x96808C", Offset = "0x96808C", VA = "0x96808C")]
	public int GetScore()
	{
		return default(int);
	}

	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x9723A4", Offset = "0x9723A4", VA = "0x9723A4")]
	public int GetScore(int intelLevel)
	{
		return default(int);
	}

	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x97241C", Offset = "0x97241C", VA = "0x97241C")]
	public int GetNextScore()
	{
		return default(int);
	}

	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x972444", Offset = "0x972444", VA = "0x972444")]
	public int GetNextScore(int intelLevel)
	{
		return default(int);
	}

	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x971C38", Offset = "0x971C38", VA = "0x971C38")]
	private static bool IsAllIntelUnlockedWeaponOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x971DF4", Offset = "0x971DF4", VA = "0x971DF4")]
	public int GetRogueIntelQuantity()
	{
		return default(int);
	}

	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x9724B0", Offset = "0x9724B0", VA = "0x9724B0")]
	public bool RogueUnlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x972568", Offset = "0x972568", VA = "0x972568")]
	public void SetIntelToTargetLevel(int targetIntelLevel)
	{
	}

	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x9725DC", Offset = "0x9725DC", VA = "0x9725DC", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x970FC4", Offset = "0x970FC4", VA = "0x970FC4")]
	public static bool operator ==(RogueData lhs, RogueData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x968050", Offset = "0x968050", VA = "0x968050")]
	public static bool operator !=(RogueData lhs, RogueData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x97267C", Offset = "0x97267C", VA = "0x97267C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x972684", Offset = "0x972684", VA = "0x972684")]
	private void OnGameStarted(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x971728", Offset = "0x971728", VA = "0x971728")]
	public string GetIconSpriteName(float healthRatio)
	{
		return null;
	}

	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x97268C", Offset = "0x97268C", VA = "0x97268C", Slot = "6")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x972714", Offset = "0x972714", VA = "0x972714", Slot = "7")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x97278C", Offset = "0x97278C", VA = "0x97278C")]
	public RogueData()
	{
	}
}
