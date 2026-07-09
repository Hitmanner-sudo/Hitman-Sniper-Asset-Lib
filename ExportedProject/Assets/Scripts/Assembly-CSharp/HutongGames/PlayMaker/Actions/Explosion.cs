using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200106F")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A2120", Offset = "0x5A2120")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A2120", Offset = "0x5A2120")]
	public class Explosion : FsmStateAction
	{
		[Token(Token = "0x4004D2C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1BF8", Offset = "0x5E1BF8")]
		public FsmVector3 center;

		[Token(Token = "0x4004D2D")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1C44", Offset = "0x5E1C44")]
		public FsmFloat force;

		[Token(Token = "0x4004D2E")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1C90", Offset = "0x5E1C90")]
		public FsmFloat radius;

		[Token(Token = "0x4004D2F")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1CDC", Offset = "0x5E1CDC")]
		public FsmFloat upwardsModifier;

		[Token(Token = "0x4004D30")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1D14", Offset = "0x5E1D14")]
		public ForceMode forceMode;

		[NonSerialized]
		[Token(Token = "0x4004D31")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5E1D4C", Offset = "0x5E1D4C")]
		public FsmInt layer;

		[Token(Token = "0x4004D32")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5E1D60", Offset = "0x5E1D60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1D60", Offset = "0x5E1D60")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004D33")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1DB0", Offset = "0x5E1DB0")]
		public FsmBool invertMask;

		[Token(Token = "0x4004D34")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E1DE8", Offset = "0x5E1DE8")]
		public bool everyFrame;

		[Token(Token = "0x6006237")]
		[Address(RVA = "0xE1F584", Offset = "0xE1F584", VA = "0xE1F584", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006238")]
		[Address(RVA = "0xE1F5BC", Offset = "0xE1F5BC", VA = "0xE1F5BC", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006239")]
		[Address(RVA = "0xE1F5DC", Offset = "0xE1F5DC", VA = "0xE1F5DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600623A")]
		[Address(RVA = "0xE1F818", Offset = "0xE1F818", VA = "0xE1F818", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600623B")]
		[Address(RVA = "0xE1F618", Offset = "0xE1F618", VA = "0xE1F618")]
		private void DoExplosion()
		{
		}

		[Token(Token = "0x600623C")]
		[Address(RVA = "0xE1F81C", Offset = "0xE1F81C", VA = "0xE1F81C")]
		private bool ShouldApplyForce(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600623D")]
		[Address(RVA = "0xE1F888", Offset = "0xE1F888", VA = "0xE1F888")]
		public Explosion()
		{
		}
	}
}
