using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001187")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A85FC", Offset = "0x5A85FC")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A85FC", Offset = "0x5A85FC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A85FC", Offset = "0x5A85FC")]
	public class SetFsmVariable : FsmStateAction
	{
		[Token(Token = "0x400535B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9BDC", Offset = "0x5F9BDC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400535C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9C28", Offset = "0x5F9C28")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F9C28", Offset = "0x5F9C28")]
		public FsmString fsmName;

		[Token(Token = "0x400535D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9C78", Offset = "0x5F9C78")]
		public FsmString variableName;

		[Token(Token = "0x400535E")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9CB0", Offset = "0x5F9CB0")]
		public FsmVar setValue;

		[Token(Token = "0x400535F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F9CFC", Offset = "0x5F9CFC")]
		public bool everyFrame;

		[Token(Token = "0x4005360")]
		[FieldOffset(Offset = "0x78")]
		private PlayMakerFSM targetFsm;

		[Token(Token = "0x4005361")]
		[FieldOffset(Offset = "0x80")]
		private NamedVariable targetVariable;

		[Token(Token = "0x4005362")]
		[FieldOffset(Offset = "0x88")]
		private GameObject cachedGameObject;

		[Token(Token = "0x4005363")]
		[FieldOffset(Offset = "0x90")]
		private string cachedFsmName;

		[Token(Token = "0x4005364")]
		[FieldOffset(Offset = "0x98")]
		private string cachedVariableName;

		[Token(Token = "0x6006760")]
		[Address(RVA = "0x103C644", Offset = "0x103C644", VA = "0x103C644", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006761")]
		[Address(RVA = "0x103C6C8", Offset = "0x103C6C8", VA = "0x103C6C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006762")]
		[Address(RVA = "0x103C9C4", Offset = "0x103C9C4", VA = "0x103C9C4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006763")]
		[Address(RVA = "0x103C704", Offset = "0x103C704", VA = "0x103C704")]
		private void DoSetFsmVariable()
		{
		}

		[Token(Token = "0x6006764")]
		[Address(RVA = "0x103C9C8", Offset = "0x103C9C8", VA = "0x103C9C8")]
		public SetFsmVariable()
		{
		}
	}
}
