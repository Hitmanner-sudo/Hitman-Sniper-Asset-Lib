using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001220")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB374", Offset = "0x5AB374")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB374", Offset = "0x5AB374")]
	public class UiInputFieldGetHideMobileInput : ComponentAction<InputField>
	{
		[Token(Token = "0x40056BE")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604F98", Offset = "0x604F98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604F98", Offset = "0x604F98")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056BF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60502C", Offset = "0x60502C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60502C", Offset = "0x60502C")]
		public FsmBool hideMobileInput;

		[Token(Token = "0x40056C0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60507C", Offset = "0x60507C")]
		public FsmEvent mobileInputHiddenEvent;

		[Token(Token = "0x40056C1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6050B4", Offset = "0x6050B4")]
		public FsmEvent mobileInputShownEvent;

		[Token(Token = "0x40056C2")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x6006A3D")]
		[Address(RVA = "0xB8F1A0", Offset = "0xB8F1A0", VA = "0xB8F1A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0xB8F1AC", Offset = "0xB8F1AC", VA = "0xB8F1AC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A3F")]
		[Address(RVA = "0xB8F234", Offset = "0xB8F234", VA = "0xB8F234")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A40")]
		[Address(RVA = "0xB8F30C", Offset = "0xB8F30C", VA = "0xB8F30C")]
		public UiInputFieldGetHideMobileInput()
		{
		}
	}
}
