using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200123B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABBE4", Offset = "0x5ABBE4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABBE4", Offset = "0x5ABBE4")]
	public class UiScrollbarGetValue : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x4005750")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607320", Offset = "0x607320")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607320", Offset = "0x607320")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005751")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6073B4", Offset = "0x6073B4")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6073B4", Offset = "0x6073B4")]
		public FsmFloat value;

		[Token(Token = "0x4005752")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607414", Offset = "0x607414")]
		public bool everyFrame;

		[Token(Token = "0x4005753")]
		[FieldOffset(Offset = "0x80")]
		private Scrollbar scrollbar;

		[Token(Token = "0x6006AC6")]
		[Address(RVA = "0xB962A8", Offset = "0xB962A8", VA = "0xB962A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AC7")]
		[Address(RVA = "0xB962B4", Offset = "0xB962B4", VA = "0xB962B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AC8")]
		[Address(RVA = "0xB963E4", Offset = "0xB963E4", VA = "0xB963E4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006AC9")]
		[Address(RVA = "0xB96350", Offset = "0xB96350", VA = "0xB96350")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006ACA")]
		[Address(RVA = "0xB963E8", Offset = "0xB963E8", VA = "0xB963E8")]
		public UiScrollbarGetValue()
		{
		}
	}
}
