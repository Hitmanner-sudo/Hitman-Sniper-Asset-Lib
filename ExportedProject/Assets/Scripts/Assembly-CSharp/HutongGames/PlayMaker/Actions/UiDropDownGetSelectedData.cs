using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001211")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAEC4", Offset = "0x5AAEC4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAEC4", Offset = "0x5AAEC4")]
	public class UiDropDownGetSelectedData : ComponentAction<Dropdown>
	{
		[Token(Token = "0x4005673")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603B34", Offset = "0x603B34")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603B34", Offset = "0x603B34")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005674")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603BC8", Offset = "0x603BC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x603BC8", Offset = "0x603BC8")]
		public FsmInt index;

		[Token(Token = "0x4005675")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603C18", Offset = "0x603C18")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x603C18", Offset = "0x603C18")]
		public FsmString getText;

		[Token(Token = "0x4005676")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603C68", Offset = "0x603C68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x603C68", Offset = "0x603C68")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x603C68", Offset = "0x603C68")]
		public FsmObject getImage;

		[Token(Token = "0x4005677")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603D00", Offset = "0x603D00")]
		public bool everyFrame;

		[Token(Token = "0x4005678")]
		[FieldOffset(Offset = "0x90")]
		private Dropdown dropDown;

		[Token(Token = "0x60069F6")]
		[Address(RVA = "0x11789E4", Offset = "0x11789E4", VA = "0x11789E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069F7")]
		[Address(RVA = "0x11789F8", Offset = "0x11789F8", VA = "0x11789F8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069F8")]
		[Address(RVA = "0x1178C24", Offset = "0x1178C24", VA = "0x1178C24", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60069F9")]
		[Address(RVA = "0x1178A94", Offset = "0x1178A94", VA = "0x1178A94")]
		private void GetValue()
		{
		}

		[Token(Token = "0x60069FA")]
		[Address(RVA = "0x1178C28", Offset = "0x1178C28", VA = "0x1178C28")]
		public UiDropDownGetSelectedData()
		{
		}
	}
}
