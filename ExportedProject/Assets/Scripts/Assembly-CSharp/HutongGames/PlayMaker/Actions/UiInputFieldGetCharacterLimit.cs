using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200121F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB324", Offset = "0x5AB324")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB324", Offset = "0x5AB324")]
	public class UiInputFieldGetCharacterLimit : ComponentAction<InputField>
	{
		[Token(Token = "0x40056B8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604DFC", Offset = "0x604DFC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604DFC", Offset = "0x604DFC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056B9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604E90", Offset = "0x604E90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x604E90", Offset = "0x604E90")]
		[RequiredField]
		public FsmInt characterLimit;

		[Token(Token = "0x40056BA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604EF0", Offset = "0x604EF0")]
		public FsmEvent hasNoLimitEvent;

		[Token(Token = "0x40056BB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604F28", Offset = "0x604F28")]
		public FsmEvent isLimitedEvent;

		[Token(Token = "0x40056BC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604F60", Offset = "0x604F60")]
		public bool everyFrame;

		[Token(Token = "0x40056BD")]
		[FieldOffset(Offset = "0x90")]
		private InputField inputField;

		[Token(Token = "0x6006A38")]
		[Address(RVA = "0xB8EFE0", Offset = "0xB8EFE0", VA = "0xB8EFE0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A39")]
		[Address(RVA = "0xB8EFEC", Offset = "0xB8EFEC", VA = "0xB8EFEC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A3A")]
		[Address(RVA = "0xB8F150", Offset = "0xB8F150", VA = "0xB8F150", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A3B")]
		[Address(RVA = "0xB8F088", Offset = "0xB8F088", VA = "0xB8F088")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A3C")]
		[Address(RVA = "0xB8F154", Offset = "0xB8F154", VA = "0xB8F154")]
		public UiInputFieldGetCharacterLimit()
		{
		}
	}
}
