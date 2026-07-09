using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001183")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A831C", Offset = "0x5A831C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A831C", Offset = "0x5A831C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A831C", Offset = "0x5A831C")]
	public class SetFsmQuaternion : FsmStateAction
	{
		[Token(Token = "0x400533B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9604", Offset = "0x5F9604")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400533C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9650", Offset = "0x5F9650")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9650", Offset = "0x5F9650")]
		public FsmString fsmName;

		[Token(Token = "0x400533D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F96A0", Offset = "0x5F96A0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F96A0", Offset = "0x5F96A0")]
		public FsmString variableName;

		[Token(Token = "0x400533E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9700", Offset = "0x5F9700")]
		[RequiredField]
		public FsmQuaternion setValue;

		[Token(Token = "0x400533F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F974C", Offset = "0x5F974C")]
		public bool everyFrame;

		[Token(Token = "0x4005340")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005341")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005342")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x600674C")]
		[Address(RVA = "0x103BA6C", Offset = "0x103BA6C", VA = "0x103BA6C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600674D")]
		[Address(RVA = "0x103BAD8", Offset = "0x103BAD8", VA = "0x103BAD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600674E")]
		[Address(RVA = "0x103BB14", Offset = "0x103BB14", VA = "0x103BB14")]
		private void DoSetFsmQuaternion()
		{
		}

		[Token(Token = "0x600674F")]
		[Address(RVA = "0x103BD50", Offset = "0x103BD50", VA = "0x103BD50", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006750")]
		[Address(RVA = "0x103BD54", Offset = "0x103BD54", VA = "0x103BD54")]
		public SetFsmQuaternion()
		{
		}
	}
}
