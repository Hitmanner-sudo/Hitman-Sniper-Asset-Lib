using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000411")]
public class CompleteMode : Perk
{
	[Token(Token = "0x40016C5")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private ContractDataModel.DifficultyType _difficultyType;

	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _requireEfficiencyOf;

	[Token(Token = "0x40016C7")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool _allowHoldBreath;

	[Token(Token = "0x40016C8")]
	[FieldOffset(Offset = "0x5D")]
	private bool _isValid;

	[Token(Token = "0x170003FF")]
	public override string GetDescription
	{
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x8DEE6C", Offset = "0x8DEE6C", VA = "0x8DEE6C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001916")]
	[Address(RVA = "0x8DEF28", Offset = "0x8DEF28", VA = "0x8DEF28", Slot = "10")]
	public override void DoStart()
	{
	}

	[Token(Token = "0x6001917")]
	[Address(RVA = "0x8DF04C", Offset = "0x8DF04C", VA = "0x8DF04C", Slot = "11")]
	public override void DoStop()
	{
	}

	[Token(Token = "0x6001918")]
	[Address(RVA = "0x8DF170", Offset = "0x8DF170", VA = "0x8DF170")]
	private void OnGameStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001919")]
	[Address(RVA = "0x8DF2A8", Offset = "0x8DF2A8", VA = "0x8DF2A8")]
	private void OnSlowMotionActivated(object sender, PlayerSlowMotionSystem.SlowMotionActivatedEventArgs e)
	{
	}

	[Token(Token = "0x600191A")]
	[Address(RVA = "0x8DF2E0", Offset = "0x8DF2E0", VA = "0x8DF2E0")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600191B")]
	[Address(RVA = "0x8DF3F0", Offset = "0x8DF3F0", VA = "0x8DF3F0")]
	public CompleteMode()
	{
	}
}
