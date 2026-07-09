using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000418")]
public class CompletionBonusReward : PerkReward
{
	[Token(Token = "0x2000419")]
	private enum CompletionBonusType
	{
		[Token(Token = "0x40016EB")]
		Accuracy = 0,
		[Token(Token = "0x40016EC")]
		Time = 1,
		[Token(Token = "0x40016ED")]
		Silent = 2
	}

	[Token(Token = "0x40016E7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CompletionBonusType _completionBonusType;

	[Token(Token = "0x40016E8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _rewardBonusRatio;

	[Token(Token = "0x40016E9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x17000409")]
	public override string GetDescription
	{
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x8DF400", Offset = "0x8DF400", VA = "0x8DF400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001947")]
	[Address(RVA = "0x8DF48C", Offset = "0x8DF48C", VA = "0x8DF48C", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001948")]
	[Address(RVA = "0x8DF54C", Offset = "0x8DF54C", VA = "0x8DF54C", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001949")]
	[Address(RVA = "0x8DF6E4", Offset = "0x8DF6E4", VA = "0x8DF6E4")]
	private void OnGameStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600194A")]
	[Address(RVA = "0x8DF6EC", Offset = "0x8DF6EC", VA = "0x8DF6EC")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600194B")]
	[Address(RVA = "0x8DF618", Offset = "0x8DF618", VA = "0x8DF618")]
	private void SetCompletionBonusValue(float value)
	{
	}

	[Token(Token = "0x600194C")]
	[Address(RVA = "0x8DF6F4", Offset = "0x8DF6F4", VA = "0x8DF6F4")]
	private void SetValue(string variableName, float value)
	{
	}

	[Token(Token = "0x600194D")]
	[Address(RVA = "0x8DF760", Offset = "0x8DF760", VA = "0x8DF760")]
	public CompletionBonusReward()
	{
	}
}
