using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200124D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC184", Offset = "0x5AC184")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC184", Offset = "0x5AC184")]
	public class UiTextSetText : ComponentAction<Text>
	{
		[Token(Token = "0x40057AE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608B08", Offset = "0x608B08")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608B08", Offset = "0x608B08")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057AF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608B9C", Offset = "0x608B9C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x608B9C", Offset = "0x608B9C")]
		public FsmString text;

		[Token(Token = "0x40057B0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608BEC", Offset = "0x608BEC")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40057B1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608C24", Offset = "0x608C24")]
		public bool everyFrame;

		[Token(Token = "0x40057B2")]
		[FieldOffset(Offset = "0x88")]
		private Text uiText;

		[Token(Token = "0x40057B3")]
		[FieldOffset(Offset = "0x90")]
		private string originalString;

		[Token(Token = "0x6006B24")]
		[Address(RVA = "0xB99BA8", Offset = "0xB99BA8", VA = "0xB99BA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B25")]
		[Address(RVA = "0xB99BB8", Offset = "0xB99BB8", VA = "0xB99BB8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B26")]
		[Address(RVA = "0xB99D28", Offset = "0xB99D28", VA = "0xB99D28", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B27")]
		[Address(RVA = "0xB99C78", Offset = "0xB99C78", VA = "0xB99C78")]
		private void DoSetTextValue()
		{
		}

		[Token(Token = "0x6006B28")]
		[Address(RVA = "0xB99D2C", Offset = "0xB99D2C", VA = "0xB99D2C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B29")]
		[Address(RVA = "0xB99DDC", Offset = "0xB99DDC", VA = "0xB99DDC")]
		public UiTextSetText()
		{
		}
	}
}
