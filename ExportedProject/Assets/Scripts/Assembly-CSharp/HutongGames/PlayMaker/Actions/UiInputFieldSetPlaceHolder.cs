using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001230")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB874", Offset = "0x5AB874")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB874", Offset = "0x5AB874")]
	public class UiInputFieldSetPlaceHolder : ComponentAction<InputField>
	{
		[Token(Token = "0x4005714")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6064C8", Offset = "0x6064C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6064C8", Offset = "0x6064C8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005715")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60655C", Offset = "0x60655C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60655C", Offset = "0x60655C")]
		public FsmGameObject placeholder;

		[Token(Token = "0x4005716")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6065F0", Offset = "0x6065F0")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005717")]
		[FieldOffset(Offset = "0x80")]
		private InputField inputField;

		[Token(Token = "0x4005718")]
		[FieldOffset(Offset = "0x88")]
		private Graphic originalValue;

		[Token(Token = "0x6006A89")]
		[Address(RVA = "0xB91834", Offset = "0xB91834", VA = "0xB91834", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A8A")]
		[Address(RVA = "0xB91840", Offset = "0xB91840", VA = "0xB91840", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A8B")]
		[Address(RVA = "0xB918E0", Offset = "0xB918E0", VA = "0xB918E0")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0xB919FC", Offset = "0xB919FC", VA = "0xB919FC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0xB91AA4", Offset = "0xB91AA4", VA = "0xB91AA4")]
		public UiInputFieldSetPlaceHolder()
		{
		}
	}
}
