using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200090D")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x596EA8", Offset = "0x596EA8")]
public class LocalizationConfiguration : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200090E")]
	internal class UIAtlasLocalizer
	{
		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x10")]
		public UIAtlas _atlas;

		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0x18")]
		public Material _primaryMaterial;

		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x20")]
		public Material _alternativeMatrial;

		[Token(Token = "0x60039ED")]
		[Address(RVA = "0x8C2B08", Offset = "0x8C2B08", VA = "0x8C2B08")]
		internal void SetMaterial(bool usePrimary)
		{
		}

		[Token(Token = "0x60039EE")]
		[Address(RVA = "0x8C2B3C", Offset = "0x8C2B3C", VA = "0x8C2B3C")]
		public UIAtlasLocalizer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200090F")]
	internal class RogueDataLocalizer
	{
		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x10")]
		public RogueData _data;

		[Token(Token = "0x40031B8")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D _primaryTexture;

		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D _alternativeTexture;

		[Token(Token = "0x60039EF")]
		[Address(RVA = "0x8C2A34", Offset = "0x8C2A34", VA = "0x8C2A34")]
		internal void SetData(bool usePrimary, Material atlasMaterial)
		{
		}

		[Token(Token = "0x60039F0")]
		[Address(RVA = "0x8C2B00", Offset = "0x8C2B00", VA = "0x8C2B00")]
		public RogueDataLocalizer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000910")]
	internal class IntelUnlockableDataLocalizer
	{
		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x10")]
		public IntelUnlockable _data;

		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x18")]
		public LazyTexture2D _primaryTexture;

		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x20")]
		public LazyTexture2D _alternativeTexture;

		[Token(Token = "0x60039F1")]
		[Address(RVA = "0x8C29FC", Offset = "0x8C29FC", VA = "0x8C29FC")]
		internal void SetData(bool usePrimary)
		{
		}

		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x8C2A2C", Offset = "0x8C2A2C", VA = "0x8C2A2C")]
		public IntelUnlockableDataLocalizer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000911")]
	internal class BodyBagOverride
	{
		[Token(Token = "0x40031BD")]
		[FieldOffset(Offset = "0x10")]
		public HierarchicalCollision _bagPrefab;

		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0x18")]
		public ThirdPersonCharacter _npcPrefab;

		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x8C29EC", Offset = "0x8C29EC", VA = "0x8C29EC")]
		public BodyBagOverride()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000912")]
	internal class CharacterJointBinding
	{
		[Token(Token = "0x40031BF")]
		[FieldOffset(Offset = "0x10")]
		public string _bagJoint;

		[Token(Token = "0x40031C0")]
		[FieldOffset(Offset = "0x18")]
		public string[] _npcJoints;

		[Token(Token = "0x60039F4")]
		[Address(RVA = "0x8C29F4", Offset = "0x8C29F4", VA = "0x8C29F4")]
		public CharacterJointBinding()
		{
		}
	}

	[Token(Token = "0x2000913")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596EFC", Offset = "0x596EFC")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0x10")]
		public ThirdPersonCharacter character;

		[Token(Token = "0x60039F5")]
		[Address(RVA = "0x8C285C", Offset = "0x8C285C", VA = "0x8C285C")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x8C2864", Offset = "0x8C2864", VA = "0x8C2864")]
		internal bool _003CGetBodyBag_003Eb__0(BodyBagOverride o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000914")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596F0C", Offset = "0x596F0C")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x40031C2")]
		[FieldOffset(Offset = "0x10")]
		public Transform bagJoint;

		[Token(Token = "0x60039F7")]
		[Address(RVA = "0x8C2894", Offset = "0x8C2894", VA = "0x8C2894")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x8C289C", Offset = "0x8C289C", VA = "0x8C289C")]
		internal bool _003CFindJointTransforms_003Eb__0(CharacterJointBinding j)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000915")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596F1C", Offset = "0x596F1C")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x10")]
		public string characterJointName;

		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x18")]
		public Func<string, bool> _003C_003E9__1;

		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x8C28EC", Offset = "0x8C28EC", VA = "0x8C28EC")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x8C28F4", Offset = "0x8C28F4", VA = "0x8C28F4")]
		internal bool _003CFindBagJointName_003Eb__0(CharacterJointBinding j)
		{
			return default(bool);
		}

		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x8C29D0", Offset = "0x8C29D0", VA = "0x8C29D0")]
		internal bool _003CFindBagJointName_003Eb__1(string n)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40031AD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIAtlasLocalizer _roguesListAsset;

	[Token(Token = "0x40031AE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RogueDataLocalizer[] _rogueDataSet;

	[Token(Token = "0x40031AF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private IntelUnlockableDataLocalizer[] _intelUnlockableDataSet;

	[Token(Token = "0x40031B0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _matchBagWithNPCOnInit;

	[Token(Token = "0x40031B1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private HierarchicalCollision _defaultBagPreab;

	[Token(Token = "0x40031B2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private BodyBagOverride[] _bodyBagOverrides;

	[Token(Token = "0x40031B3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CharacterJointBinding[] _jointBindings;

	[Token(Token = "0x1700074C")]
	internal bool MatchBagWithNPCOnInit
	{
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x9D8490", Offset = "0x9D8490", VA = "0x9D8490")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700074D")]
	internal UIAtlasLocalizer RoguesListAtlas
	{
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x9D8498", Offset = "0x9D8498", VA = "0x9D8498")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60039E6")]
	[Address(RVA = "0x9D84A0", Offset = "0x9D84A0", VA = "0x9D84A0")]
	private void LocalizeRogueDataSet(bool usePrimary)
	{
	}

	[Token(Token = "0x60039E7")]
	[Address(RVA = "0x9D8548", Offset = "0x9D8548", VA = "0x9D8548")]
	private void LocalizeIntelUnlockableDataSet(bool usePrimary)
	{
	}

	[Token(Token = "0x60039E8")]
	[Address(RVA = "0x9D85C4", Offset = "0x9D85C4", VA = "0x9D85C4")]
	internal void ApplyLocalization()
	{
	}

	[Token(Token = "0x60039E9")]
	[Address(RVA = "0x9D86C8", Offset = "0x9D86C8", VA = "0x9D86C8")]
	internal HierarchicalCollision GetBodyBag(ThirdPersonCharacter character)
	{
		return null;
	}

	[Token(Token = "0x60039EA")]
	[Address(RVA = "0x9D88B8", Offset = "0x9D88B8", VA = "0x9D88B8")]
	internal Transform[] FindJointTransforms(Transform bagJoint, HierarchicalCollision npcHC)
	{
		return null;
	}

	[Token(Token = "0x60039EB")]
	[Address(RVA = "0x9D8B34", Offset = "0x9D8B34", VA = "0x9D8B34")]
	internal string FindBagJointName(string characterJointName)
	{
		return null;
	}

	[Token(Token = "0x60039EC")]
	[Address(RVA = "0x9D8C54", Offset = "0x9D8C54", VA = "0x9D8C54")]
	public LocalizationConfiguration()
	{
	}
}
