using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001216")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB054", Offset = "0x5AB054")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB054", Offset = "0x5AB054")]
	public class UiGraphicSetColor : ComponentAction<Graphic>
	{
		[Token(Token = "0x4005690")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60430C", Offset = "0x60430C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60430C", Offset = "0x60430C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005691")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6043A0", Offset = "0x6043A0")]
		public FsmColor color;

		[Token(Token = "0x4005692")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6043D8", Offset = "0x6043D8")]
		public FsmFloat red;

		[Token(Token = "0x4005693")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604410", Offset = "0x604410")]
		public FsmFloat green;

		[Token(Token = "0x4005694")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604448", Offset = "0x604448")]
		public FsmFloat blue;

		[Token(Token = "0x4005695")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604480", Offset = "0x604480")]
		public FsmFloat alpha;

		[Token(Token = "0x4005696")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6044B8", Offset = "0x6044B8")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005697")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6044F0", Offset = "0x6044F0")]
		public bool everyFrame;

		[Token(Token = "0x4005698")]
		[FieldOffset(Offset = "0xA8")]
		private Graphic uiComponent;

		[Token(Token = "0x4005699")]
		[FieldOffset(Offset = "0xB0")]
		private Color originalColor;

		[Token(Token = "0x6006A0B")]
		[Address(RVA = "0xB8DCD4", Offset = "0xB8DCD4", VA = "0xB8DCD4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A0C")]
		[Address(RVA = "0xB8DDB4", Offset = "0xB8DDB4", VA = "0xB8DDB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A0D")]
		[Address(RVA = "0xB8E024", Offset = "0xB8E024", VA = "0xB8E024", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A0E")]
		[Address(RVA = "0xB8DE78", Offset = "0xB8DE78", VA = "0xB8DE78")]
		private void DoSetColorValue()
		{
		}

		[Token(Token = "0x6006A0F")]
		[Address(RVA = "0xB8E028", Offset = "0xB8E028", VA = "0xB8E028", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A10")]
		[Address(RVA = "0xB8E0DC", Offset = "0xB8E0DC", VA = "0xB8E0DC")]
		public UiGraphicSetColor()
		{
		}
	}
}
