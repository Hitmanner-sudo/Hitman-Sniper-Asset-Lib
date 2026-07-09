using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000565")]
public class UpgradeController : UIController
{
	[Serializable]
	[Token(Token = "0x2000566")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5952A4", Offset = "0x5952A4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001C8E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001C8F")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Target> _003C_003E9__7_0;

		[Token(Token = "0x600221E")]
		[Address(RVA = "0xA3FED4", Offset = "0xA3FED4", VA = "0xA3FED4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600221F")]
		[Address(RVA = "0xA3FEDC", Offset = "0xA3FEDC", VA = "0xA3FEDC")]
		internal bool _003CGetMainTarget_003Eb__7_0(Target t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001C89")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _healBlinkButtonHandler;

	[Token(Token = "0x4001C8A")]
	[FieldOffset(Offset = "0x58")]
	private int _healCostIndex;

	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x60")]
	private RogueData _rogue;

	[Token(Token = "0x4001C8C")]
	[FieldOffset(Offset = "0x68")]
	private Target _mainTarget;

	[Token(Token = "0x4001C8D")]
	[FieldOffset(Offset = "0x70")]
	private ChallengeData _challengeData;

	[Token(Token = "0x6002217")]
	[Address(RVA = "0xB9CE10", Offset = "0xB9CE10", VA = "0xB9CE10", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002218")]
	[Address(RVA = "0xB9D1BC", Offset = "0xB9D1BC", VA = "0xB9D1BC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002219")]
	[Address(RVA = "0xB9D064", Offset = "0xB9D064", VA = "0xB9D064")]
	private Target GetMainTarget()
	{
		return null;
	}

	[Token(Token = "0x600221A")]
	[Address(RVA = "0xB9D398", Offset = "0xB9D398", VA = "0xB9D398", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600221B")]
	[Address(RVA = "0xB9D490", Offset = "0xB9D490", VA = "0xB9D490")]
	private void HealButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600221C")]
	[Address(RVA = "0xB9D7B0", Offset = "0xB9D7B0", VA = "0xB9D7B0")]
	public UpgradeController()
	{
	}
}
