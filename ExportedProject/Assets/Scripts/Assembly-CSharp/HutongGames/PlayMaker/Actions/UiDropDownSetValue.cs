using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001212")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAF14", Offset = "0x5AAF14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAF14", Offset = "0x5AAF14")]
	public class UiDropDownSetValue : ComponentAction<Dropdown>
	{
		[Token(Token = "0x4005679")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603D38", Offset = "0x603D38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603D38", Offset = "0x603D38")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400567A")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603DCC", Offset = "0x603DCC")]
		public FsmInt value;

		[Token(Token = "0x400567B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603E18", Offset = "0x603E18")]
		public bool everyFrame;

		[Token(Token = "0x400567C")]
		[FieldOffset(Offset = "0x80")]
		private Dropdown dropDown;

		[Token(Token = "0x60069FB")]
		[Address(RVA = "0x1178C74", Offset = "0x1178C74", VA = "0x1178C74", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069FC")]
		[Address(RVA = "0x1178C80", Offset = "0x1178C80", VA = "0x1178C80", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069FD")]
		[Address(RVA = "0x1178DE8", Offset = "0x1178DE8", VA = "0x1178DE8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60069FE")]
		[Address(RVA = "0x1178D1C", Offset = "0x1178D1C", VA = "0x1178D1C")]
		private void SetValue()
		{
		}

		[Token(Token = "0x60069FF")]
		[Address(RVA = "0x1178DEC", Offset = "0x1178DEC", VA = "0x1178DEC")]
		public UiDropDownSetValue()
		{
		}
	}
}
