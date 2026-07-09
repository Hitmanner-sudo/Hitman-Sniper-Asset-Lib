using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200115E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7134", Offset = "0x5A7134")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7134", Offset = "0x5A7134")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7134", Offset = "0x5A7134")]
	public class GetFsmString : FsmStateAction
	{
		[Token(Token = "0x400527A")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F72D8", Offset = "0x5F72D8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400527B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7324", Offset = "0x5F7324")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7324", Offset = "0x5F7324")]
		public FsmString fsmName;

		[Token(Token = "0x400527C")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7374", Offset = "0x5F7374")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7374", Offset = "0x5F7374")]
		public FsmString variableName;

		[Token(Token = "0x400527D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F73D4", Offset = "0x5F73D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F73D4", Offset = "0x5F73D4")]
		public FsmString storeValue;

		[Token(Token = "0x400527E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7434", Offset = "0x5F7434")]
		public bool everyFrame;

		[Token(Token = "0x400527F")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005280")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005281")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600669A")]
		[Address(RVA = "0x1062674", Offset = "0x1062674", VA = "0x1062674", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600669B")]
		[Address(RVA = "0x10626D0", Offset = "0x10626D0", VA = "0x10626D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600669C")]
		[Address(RVA = "0x10628D0", Offset = "0x10628D0", VA = "0x10628D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600669D")]
		[Address(RVA = "0x106270C", Offset = "0x106270C", VA = "0x106270C")]
		private void DoGetFsmString()
		{
		}

		[Token(Token = "0x600669E")]
		[Address(RVA = "0x10628D4", Offset = "0x10628D4", VA = "0x10628D4")]
		public GetFsmString()
		{
		}
	}
}
