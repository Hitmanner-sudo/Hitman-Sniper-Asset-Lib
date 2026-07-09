using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001155")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6AC4", Offset = "0x5A6AC4")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6AC4", Offset = "0x5A6AC4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6AC4", Offset = "0x5A6AC4")]
	public class GetFsmEnum : FsmStateAction
	{
		[Token(Token = "0x4005234")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F64E0", Offset = "0x5F64E0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005235")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F652C", Offset = "0x5F652C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F652C", Offset = "0x5F652C")]
		public FsmString fsmName;

		[Token(Token = "0x4005236")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F657C", Offset = "0x5F657C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F657C", Offset = "0x5F657C")]
		public FsmString variableName;

		[Token(Token = "0x4005237")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F65DC", Offset = "0x5F65DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F65DC", Offset = "0x5F65DC")]
		[RequiredField]
		public FsmEnum storeValue;

		[Token(Token = "0x4005238")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F663C", Offset = "0x5F663C")]
		public bool everyFrame;

		[Token(Token = "0x4005239")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400523A")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400523B")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600666D")]
		[Address(RVA = "0x1061060", Offset = "0x1061060", VA = "0x1061060", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600666E")]
		[Address(RVA = "0x10610BC", Offset = "0x10610BC", VA = "0x10610BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600666F")]
		[Address(RVA = "0x10612D4", Offset = "0x10612D4", VA = "0x10612D4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006670")]
		[Address(RVA = "0x10610F8", Offset = "0x10610F8", VA = "0x10610F8")]
		private void DoGetFsmEnum()
		{
		}

		[Token(Token = "0x6006671")]
		[Address(RVA = "0x10612D8", Offset = "0x10612D8", VA = "0x10612D8")]
		public GetFsmEnum()
		{
		}
	}
}
