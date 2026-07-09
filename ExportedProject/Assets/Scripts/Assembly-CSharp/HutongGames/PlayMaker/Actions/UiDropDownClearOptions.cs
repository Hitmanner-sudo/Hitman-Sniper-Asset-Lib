using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001210")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAE74", Offset = "0x5AAE74")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAE74", Offset = "0x5AAE74")]
	public class UiDropDownClearOptions : ComponentAction<Dropdown>
	{
		[Token(Token = "0x4005671")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603AA0", Offset = "0x603AA0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603AA0", Offset = "0x603AA0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005672")]
		[FieldOffset(Offset = "0x70")]
		private Dropdown dropDown;

		[Token(Token = "0x60069F3")]
		[Address(RVA = "0x11788A8", Offset = "0x11788A8", VA = "0x11788A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069F4")]
		[Address(RVA = "0x11788B0", Offset = "0x11788B0", VA = "0x11788B0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069F5")]
		[Address(RVA = "0x1178998", Offset = "0x1178998", VA = "0x1178998")]
		public UiDropDownClearOptions()
		{
		}
	}
}
