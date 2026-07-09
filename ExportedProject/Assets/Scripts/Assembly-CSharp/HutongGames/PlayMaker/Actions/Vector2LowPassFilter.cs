using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001262")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC814", Offset = "0x5AC814")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC814", Offset = "0x5AC814")]
	public class Vector2LowPassFilter : FsmStateAction
	{
		[Token(Token = "0x4005803")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609FF0", Offset = "0x609FF0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609FF0", Offset = "0x609FF0")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x4005804")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A050", Offset = "0x60A050")]
		public FsmFloat filteringFactor;

		[Token(Token = "0x4005805")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 filteredVector;

		[Token(Token = "0x6006B87")]
		[Address(RVA = "0x13C6690", Offset = "0x13C6690", VA = "0x13C6690", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B88")]
		[Address(RVA = "0x13C66C4", Offset = "0x13C66C4", VA = "0x13C66C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B89")]
		[Address(RVA = "0x13C66E4", Offset = "0x13C66E4", VA = "0x13C66E4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B8A")]
		[Address(RVA = "0x13C67BC", Offset = "0x13C67BC", VA = "0x13C67BC")]
		public Vector2LowPassFilter()
		{
		}
	}
}
