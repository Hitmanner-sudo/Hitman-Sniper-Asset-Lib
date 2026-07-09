using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA1E4", Offset = "0x5AA1E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA1E4", Offset = "0x5AA1E4")]
	public class UiEventSystemCurrentRayCastAll : FsmStateAction
	{
		[Token(Token = "0x40055A1")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600804", Offset = "0x600804")]
		public FsmVector3 screenPosition;

		[Token(Token = "0x40055A2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600850", Offset = "0x600850")]
		public FsmVector2 orScreenPosition2d;

		[Token(Token = "0x40055A3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600888", Offset = "0x600888")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x600888", Offset = "0x600888")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600888", Offset = "0x600888")]
		public FsmArray gameObjectList;

		[Token(Token = "0x40055A4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60090C", Offset = "0x60090C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60090C", Offset = "0x60090C")]
		public FsmInt hitCount;

		[Token(Token = "0x40055A5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60095C", Offset = "0x60095C")]
		public bool everyFrame;

		[Token(Token = "0x40055A6")]
		[FieldOffset(Offset = "0x78")]
		private PointerEventData pointer;

		[Token(Token = "0x40055A7")]
		[FieldOffset(Offset = "0x80")]
		private List<RaycastResult> raycastResults;

		[Token(Token = "0x6006940")]
		[Address(RVA = "0x1178E38", Offset = "0x1178E38", VA = "0x1178E38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006941")]
		[Address(RVA = "0x1178EB0", Offset = "0x1178EB0", VA = "0x1178EB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006942")]
		[Address(RVA = "0x11791A4", Offset = "0x11791A4", VA = "0x11791A4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006943")]
		[Address(RVA = "0x1178EEC", Offset = "0x1178EEC", VA = "0x1178EEC")]
		private void ExecuteRayCastAll()
		{
		}

		[Token(Token = "0x6006944")]
		[Address(RVA = "0x11791A8", Offset = "0x11791A8", VA = "0x11791A8")]
		public UiEventSystemCurrentRayCastAll()
		{
		}
	}
}
