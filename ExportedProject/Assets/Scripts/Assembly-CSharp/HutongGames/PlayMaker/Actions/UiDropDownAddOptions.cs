using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200120F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAE24", Offset = "0x5AAE24")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAE24", Offset = "0x5AAE24")]
	public class UiDropDownAddOptions : ComponentAction<Dropdown>
	{
		[Token(Token = "0x400566C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6038F8", Offset = "0x6038F8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6038F8", Offset = "0x6038F8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400566D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60398C", Offset = "0x60398C")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x60398C", Offset = "0x60398C")]
		public FsmString[] optionText;

		[Token(Token = "0x400566E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x603A1C", Offset = "0x603A1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603A1C", Offset = "0x603A1C")]
		public FsmObject[] optionImage;

		[Token(Token = "0x400566F")]
		[FieldOffset(Offset = "0x80")]
		private Dropdown dropDown;

		[Token(Token = "0x4005670")]
		[FieldOffset(Offset = "0x88")]
		private List<Dropdown.OptionData> options;

		[Token(Token = "0x60069EF")]
		[Address(RVA = "0x1178544", Offset = "0x1178544", VA = "0x1178544", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069F0")]
		[Address(RVA = "0x11785C0", Offset = "0x11785C0", VA = "0x11785C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069F1")]
		[Address(RVA = "0x1178648", Offset = "0x1178648", VA = "0x1178648")]
		private void DoAddOptions()
		{
		}

		[Token(Token = "0x60069F2")]
		[Address(RVA = "0x117885C", Offset = "0x117885C", VA = "0x117885C")]
		public UiDropDownAddOptions()
		{
		}
	}
}
