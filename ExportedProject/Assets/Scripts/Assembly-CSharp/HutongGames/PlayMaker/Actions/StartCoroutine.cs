using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001132")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5E10", Offset = "0x5A5E10")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5E10", Offset = "0x5A5E10")]
	public class StartCoroutine : FsmStateAction
	{
		[Token(Token = "0x40051AB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3F0C", Offset = "0x5F3F0C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051AC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3F58", Offset = "0x5F3F58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3F58", Offset = "0x5F3F58")]
		[RequiredField]
		public FsmString behaviour;

		[Token(Token = "0x40051AD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3FB8", Offset = "0x5F3FB8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3FB8", Offset = "0x5F3FB8")]
		public FunctionCall functionCall;

		[Token(Token = "0x40051AE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4018", Offset = "0x5F4018")]
		public bool stopOnExit;

		[Token(Token = "0x40051AF")]
		[FieldOffset(Offset = "0x70")]
		private MonoBehaviour component;

		[Token(Token = "0x60065ED")]
		[Address(RVA = "0xD283A4", Offset = "0xD283A4", VA = "0xD283A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065EE")]
		[Address(RVA = "0xD283B4", Offset = "0xD283B4", VA = "0xD283B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065EF")]
		[Address(RVA = "0xD283DC", Offset = "0xD283DC", VA = "0xD283DC")]
		private void DoStartCoroutine()
		{
		}

		[Token(Token = "0x60065F0")]
		[Address(RVA = "0xD28C70", Offset = "0xD28C70", VA = "0xD28C70", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065F1")]
		[Address(RVA = "0xD28D14", Offset = "0xD28D14", VA = "0xD28D14")]
		public StartCoroutine()
		{
		}
	}
}
