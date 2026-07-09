using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001185")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A848C", Offset = "0x5A848C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A848C", Offset = "0x5A848C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A848C", Offset = "0x5A848C")]
	public class SetFsmString : FsmStateAction
	{
		[Token(Token = "0x400534B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9904", Offset = "0x5F9904")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400534C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9950", Offset = "0x5F9950")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9950", Offset = "0x5F9950")]
		public FsmString fsmName;

		[Token(Token = "0x400534D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F99A0", Offset = "0x5F99A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F99A0", Offset = "0x5F99A0")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x400534E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9A00", Offset = "0x5F9A00")]
		public FsmString setValue;

		[Token(Token = "0x400534F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9A38", Offset = "0x5F9A38")]
		public bool everyFrame;

		[Token(Token = "0x4005350")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005351")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005352")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006756")]
		[Address(RVA = "0x103C04C", Offset = "0x103C04C", VA = "0x103C04C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006757")]
		[Address(RVA = "0x103C0A8", Offset = "0x103C0A8", VA = "0x103C0A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006758")]
		[Address(RVA = "0x103C0E4", Offset = "0x103C0E4", VA = "0x103C0E4")]
		private void DoSetFsmString()
		{
		}

		[Token(Token = "0x6006759")]
		[Address(RVA = "0x103C328", Offset = "0x103C328", VA = "0x103C328", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600675A")]
		[Address(RVA = "0x103C32C", Offset = "0x103C32C", VA = "0x103C32C")]
		public SetFsmString()
		{
		}
	}
}
