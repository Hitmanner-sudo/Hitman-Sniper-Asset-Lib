using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A700", Offset = "0x59A700")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A700", Offset = "0x59A700")]
	public class GetAnimatorLayersAffectMassCenter : ComponentAction<Animator>
	{
		[Token(Token = "0x400468B")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6C38", Offset = "0x5C6C38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6C38", Offset = "0x5C6C38")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400468C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5C6CCC", Offset = "0x5C6CCC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6CCC", Offset = "0x5C6CCC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6CCC", Offset = "0x5C6CCC")]
		public FsmBool affectMassCenter;

		[Token(Token = "0x400468D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6D50", Offset = "0x5C6D50")]
		public FsmEvent affectMassCenterEvent;

		[Token(Token = "0x400468E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6D88", Offset = "0x5C6D88")]
		public FsmEvent doNotAffectMassCenterEvent;

		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x105B3BC", Offset = "0x105B3BC", VA = "0x105B3BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x105B3CC", Offset = "0x105B3CC", VA = "0x105B3CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x105B48C", Offset = "0x105B48C", VA = "0x105B48C")]
		public GetAnimatorLayersAffectMassCenter()
		{
		}
	}
}
