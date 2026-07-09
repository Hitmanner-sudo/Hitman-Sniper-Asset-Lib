using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C6")]
public class ScoreTallyRewardView : View
{
	[Serializable]
	[Token(Token = "0x20006C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B28", Offset = "0x595B28")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LootBoxDroppedItem, bool> _003C_003E9__5_0;

		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x8B8A64", Offset = "0x8B8A64", VA = "0x8B8A64")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002C9B")]
		[Address(RVA = "0x8B8A6C", Offset = "0x8B8A6C", VA = "0x8B8A6C")]
		internal bool _003COnEnable_003Eb__5_0(LootBoxDroppedItem i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002614")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _rewardHolder;

	[Token(Token = "0x4002615")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _openButton;

	[Token(Token = "0x4002616")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _claimButton;

	[Token(Token = "0x4002617")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector3 _singleItemOffset;

	[Token(Token = "0x4002618")]
	[FieldOffset(Offset = "0x88")]
	private GameObject _item;

	[Token(Token = "0x6002C96")]
	[Address(RVA = "0xB61314", Offset = "0xB61314", VA = "0xB61314", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C97")]
	[Address(RVA = "0xB618E8", Offset = "0xB618E8", VA = "0xB618E8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002C98")]
	[Address(RVA = "0xB6195C", Offset = "0xB6195C", VA = "0xB6195C")]
	public ScoreTallyRewardView()
	{
	}
}
