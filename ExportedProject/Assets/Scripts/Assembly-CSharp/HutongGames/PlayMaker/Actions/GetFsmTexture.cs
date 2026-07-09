using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200115F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A71EC", Offset = "0x5A71EC")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A71EC", Offset = "0x5A71EC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A71EC", Offset = "0x5A71EC")]
	public class GetFsmTexture : FsmStateAction
	{
		[Token(Token = "0x4005282")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F746C", Offset = "0x5F746C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005283")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F74B8", Offset = "0x5F74B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F74B8", Offset = "0x5F74B8")]
		public FsmString fsmName;

		[Token(Token = "0x4005284")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7508", Offset = "0x5F7508")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7508", Offset = "0x5F7508")]
		public FsmString variableName;

		[Token(Token = "0x4005285")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7568", Offset = "0x5F7568")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7568", Offset = "0x5F7568")]
		public FsmTexture storeValue;

		[Token(Token = "0x4005286")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F75C8", Offset = "0x5F75C8")]
		public bool everyFrame;

		[Token(Token = "0x4005287")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005288")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005289")]
		[FieldOffset(Offset = "0x88")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x600669F")]
		[Address(RVA = "0x10628DC", Offset = "0x10628DC", VA = "0x10628DC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066A0")]
		[Address(RVA = "0x1062948", Offset = "0x1062948", VA = "0x1062948", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066A1")]
		[Address(RVA = "0x1062B60", Offset = "0x1062B60", VA = "0x1062B60", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066A2")]
		[Address(RVA = "0x1062984", Offset = "0x1062984", VA = "0x1062984")]
		private void DoGetFsmVariable()
		{
		}

		[Token(Token = "0x60066A3")]
		[Address(RVA = "0x1062B64", Offset = "0x1062B64", VA = "0x1062B64")]
		public GetFsmTexture()
		{
		}
	}
}
