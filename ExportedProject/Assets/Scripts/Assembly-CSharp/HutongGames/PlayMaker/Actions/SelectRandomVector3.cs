using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200126F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACBD4", Offset = "0x5ACBD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACBD4", Offset = "0x5ACBD4")]
	public class SelectRandomVector3 : FsmStateAction
	{
		[Token(Token = "0x4005839")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AB90", Offset = "0x60AB90")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x60AB90", Offset = "0x60AB90")]
		public FsmVector3[] vector3Array;

		[Token(Token = "0x400583A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AC20", Offset = "0x60AC20")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x60AC20", Offset = "0x60AC20")]
		public FsmFloat[] weights;

		[Token(Token = "0x400583B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AC74", Offset = "0x60AC74")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60AC74", Offset = "0x60AC74")]
		[RequiredField]
		public FsmVector3 storeVector3;

		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0xB70648", Offset = "0xB70648", VA = "0xB70648", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0xB70790", Offset = "0xB70790", VA = "0xB70790", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0xB707B8", Offset = "0xB707B8", VA = "0xB707B8")]
		private void DoSelectRandomColor()
		{
		}

		[Token(Token = "0x6006BBF")]
		[Address(RVA = "0xB70848", Offset = "0xB70848", VA = "0xB70848")]
		public SelectRandomVector3()
		{
		}
	}
}
