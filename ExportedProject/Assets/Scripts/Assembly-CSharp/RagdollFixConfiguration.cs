using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008F0")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x596D08", Offset = "0x596D08")]
public class RagdollFixConfiguration : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20008F1")]
	internal class CollidableChild
	{
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x10")]
		public bool _exactSearch;

		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x18")]
		public string _childName;

		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x20")]
		public float _distanceThreadLimitOffset;

		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x24")]
		public float _distanceInterpolator;

		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x28")]
		public float _interpolationSpeedFactor;

		[Token(Token = "0x6003953")]
		[Address(RVA = "0x8B2500", Offset = "0x8B2500", VA = "0x8B2500")]
		public CollidableChild()
		{
		}
	}

	[Token(Token = "0x20008F2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596D5C", Offset = "0x596D5C")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x10")]
		public string childName;

		[Token(Token = "0x6003954")]
		[Address(RVA = "0x8B24BC", Offset = "0x8B24BC", VA = "0x8B24BC")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6003955")]
		[Address(RVA = "0x8B24C4", Offset = "0x8B24C4", VA = "0x8B24C4")]
		internal bool _003CFindChild_003Eb__0(CollidableChild c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003142")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CollidableChild[] _childsToFix;

	[Token(Token = "0x6003951")]
	[Address(RVA = "0xB3E108", Offset = "0xB3E108", VA = "0xB3E108")]
	internal CollidableChild FindChild(string childName)
	{
		return null;
	}

	[Token(Token = "0x6003952")]
	[Address(RVA = "0xB3E21C", Offset = "0xB3E21C", VA = "0xB3E21C")]
	public RagdollFixConfiguration()
	{
	}
}
