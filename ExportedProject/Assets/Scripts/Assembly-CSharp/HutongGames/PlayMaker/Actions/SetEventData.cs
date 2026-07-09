using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001176")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7BCC", Offset = "0x5A7BCC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7BCC", Offset = "0x5A7BCC")]
	public class SetEventData : FsmStateAction
	{
		[Token(Token = "0x40052E8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F863C", Offset = "0x5F863C")]
		public FsmGameObject setGameObjectData;

		[Token(Token = "0x40052E9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8674", Offset = "0x5F8674")]
		public FsmInt setIntData;

		[Token(Token = "0x40052EA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F86AC", Offset = "0x5F86AC")]
		public FsmFloat setFloatData;

		[Token(Token = "0x40052EB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F86E4", Offset = "0x5F86E4")]
		public FsmString setStringData;

		[Token(Token = "0x40052EC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F871C", Offset = "0x5F871C")]
		public FsmBool setBoolData;

		[Token(Token = "0x40052ED")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8754", Offset = "0x5F8754")]
		public FsmVector2 setVector2Data;

		[Token(Token = "0x40052EE")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F878C", Offset = "0x5F878C")]
		public FsmVector3 setVector3Data;

		[Token(Token = "0x40052EF")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F87C4", Offset = "0x5F87C4")]
		public FsmRect setRectData;

		[Token(Token = "0x40052F0")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F87FC", Offset = "0x5F87FC")]
		public FsmQuaternion setQuaternionData;

		[Token(Token = "0x40052F1")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8834", Offset = "0x5F8834")]
		public FsmColor setColorData;

		[Token(Token = "0x40052F2")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F886C", Offset = "0x5F886C")]
		public FsmMaterial setMaterialData;

		[Token(Token = "0x40052F3")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F88A4", Offset = "0x5F88A4")]
		public FsmTexture setTextureData;

		[Token(Token = "0x40052F4")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F88DC", Offset = "0x5F88DC")]
		public FsmObject setObjectData;

		[Token(Token = "0x40052F5")]
		[FieldOffset(Offset = "0xB8")]
		public bool everyFrame;

		[Token(Token = "0x6006711")]
		[Address(RVA = "0x10391B4", Offset = "0x10391B4", VA = "0x10391B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006712")]
		[Address(RVA = "0x10394B4", Offset = "0x10394B4", VA = "0x10394B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006713")]
		[Address(RVA = "0x1039718", Offset = "0x1039718", VA = "0x1039718", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006714")]
		[Address(RVA = "0x10394F0", Offset = "0x10394F0", VA = "0x10394F0")]
		private void DoSetData()
		{
		}

		[Token(Token = "0x6006715")]
		[Address(RVA = "0x103971C", Offset = "0x103971C", VA = "0x103971C")]
		public SetEventData()
		{
		}
	}
}
