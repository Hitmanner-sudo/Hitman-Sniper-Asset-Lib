using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ECC")]
	public abstract class FsmStateActionAnimatorBase : ComponentAction<Animator>
	{
		[Token(Token = "0x2000ECD")]
		public enum AnimatorFrameUpdateSelector
		{
			[Token(Token = "0x4004611")]
			OnUpdate = 0,
			[Token(Token = "0x4004612")]
			OnAnimatorMove = 1,
			[Token(Token = "0x4004613")]
			OnAnimatorIK = 2
		}

		[Token(Token = "0x400460D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4200", Offset = "0x5C4200")]
		public bool everyFrame;

		[Token(Token = "0x400460E")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4238", Offset = "0x5C4238")]
		public AnimatorFrameUpdateSelector everyFrameOption;

		[Token(Token = "0x400460F")]
		[FieldOffset(Offset = "0x70")]
		protected int IklayerIndex;

		[Token(Token = "0x6005B56")]
		public abstract void OnActionUpdate();

		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x95D2C4", Offset = "0x95D2C4", VA = "0x95D2C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x95D2D0", Offset = "0x95D2D0", VA = "0x95D2D0", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x95D338", Offset = "0x95D338", VA = "0x95D338", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x95D38C", Offset = "0x95D38C", VA = "0x95D38C", Slot = "59")]
		public override void DoAnimatorMove()
		{
		}

		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x95D3E4", Offset = "0x95D3E4", VA = "0x95D3E4", Slot = "60")]
		public override void DoAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0x95D440", Offset = "0x95D440", VA = "0x95D440")]
		protected FsmStateActionAnimatorBase()
		{
		}
	}
}
