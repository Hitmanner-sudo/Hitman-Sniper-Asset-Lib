using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011EB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA324", Offset = "0x5AA324")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA324", Offset = "0x5AA324")]
	public class UiGetSelectedGameObject : FsmStateAction
	{
		[Token(Token = "0x40055DA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60138C", Offset = "0x60138C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60138C", Offset = "0x60138C")]
		public FsmGameObject StoreGameObject;

		[Token(Token = "0x40055DB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6013DC", Offset = "0x6013DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6013DC", Offset = "0x6013DC")]
		public FsmEvent ObjectChangedEvent;

		[Token(Token = "0x40055DC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60142C", Offset = "0x60142C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60142C", Offset = "0x60142C")]
		public bool everyFrame;

		[Token(Token = "0x40055DD")]
		[FieldOffset(Offset = "0x68")]
		private GameObject lastGameObject;

		[Token(Token = "0x6006950")]
		[Address(RVA = "0x117B0CC", Offset = "0x117B0CC", VA = "0x117B0CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006951")]
		[Address(RVA = "0x117B0D8", Offset = "0x117B0D8", VA = "0x117B0D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006952")]
		[Address(RVA = "0x117B190", Offset = "0x117B190", VA = "0x117B190", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006953")]
		[Address(RVA = "0x117B110", Offset = "0x117B110", VA = "0x117B110")]
		private void GetCurrentSelectedGameObject()
		{
		}

		[Token(Token = "0x6006954")]
		[Address(RVA = "0x117B268", Offset = "0x117B268", VA = "0x117B268")]
		public UiGetSelectedGameObject()
		{
		}
	}
}
