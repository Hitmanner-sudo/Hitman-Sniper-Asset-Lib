using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001225")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB504", Offset = "0x5AB504")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB504", Offset = "0x5AB504")]
	public class UiInputFieldGetTextAsFloat : ComponentAction<InputField>
	{
		[Token(Token = "0x40056D6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605624", Offset = "0x605624")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605624", Offset = "0x605624")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056D7")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6056B8", Offset = "0x6056B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6056B8", Offset = "0x6056B8")]
		public FsmFloat value;

		[Token(Token = "0x40056D8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605718", Offset = "0x605718")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605718", Offset = "0x605718")]
		public FsmBool isFloat;

		[Token(Token = "0x40056D9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605768", Offset = "0x605768")]
		public FsmEvent isFloatEvent;

		[Token(Token = "0x40056DA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6057A0", Offset = "0x6057A0")]
		public FsmEvent isNotFloatEvent;

		[Token(Token = "0x40056DB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6057D8", Offset = "0x6057D8")]
		public bool everyFrame;

		[Token(Token = "0x40056DC")]
		[FieldOffset(Offset = "0x98")]
		private InputField inputField;

		[Token(Token = "0x40056DD")]
		[FieldOffset(Offset = "0xA0")]
		private float _value;

		[Token(Token = "0x40056DE")]
		[FieldOffset(Offset = "0xA4")]
		private bool _success;

		[Token(Token = "0x6006A53")]
		[Address(RVA = "0xB8FA24", Offset = "0xB8FA24", VA = "0xB8FA24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A54")]
		[Address(RVA = "0xB8FA34", Offset = "0xB8FA34", VA = "0xB8FA34", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A55")]
		[Address(RVA = "0xB8FBB8", Offset = "0xB8FBB8", VA = "0xB8FBB8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A56")]
		[Address(RVA = "0xB8FAD0", Offset = "0xB8FAD0", VA = "0xB8FAD0")]
		private void DoGetTextValue()
		{
		}

		[Token(Token = "0x6006A57")]
		[Address(RVA = "0xB8FBBC", Offset = "0xB8FBBC", VA = "0xB8FBBC")]
		public UiInputFieldGetTextAsFloat()
		{
		}
	}
}
