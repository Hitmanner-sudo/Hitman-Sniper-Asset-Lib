using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200125E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC6D4", Offset = "0x5AC6D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC6D4", Offset = "0x5AC6D4")]
	public class Vector2HighPassFilter : FsmStateAction
	{
		[Token(Token = "0x40057F0")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609B58", Offset = "0x609B58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609B58", Offset = "0x609B58")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057F1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609BB8", Offset = "0x609BB8")]
		public FsmFloat filteringFactor;

		[Token(Token = "0x40057F2")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 filteredVector;

		[Token(Token = "0x6006B76")]
		[Address(RVA = "0x13C616C", Offset = "0x13C616C", VA = "0x13C616C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B77")]
		[Address(RVA = "0x13C61A0", Offset = "0x13C61A0", VA = "0x13C61A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B78")]
		[Address(RVA = "0x13C61C0", Offset = "0x13C61C0", VA = "0x13C61C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B79")]
		[Address(RVA = "0x13C62A0", Offset = "0x13C62A0", VA = "0x13C62A0")]
		public Vector2HighPassFilter()
		{
		}
	}
}
