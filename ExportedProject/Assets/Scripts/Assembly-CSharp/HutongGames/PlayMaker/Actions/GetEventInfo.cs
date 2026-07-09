using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200114D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6758", Offset = "0x5A6758")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x5A6758", Offset = "0x5A6758")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6758", Offset = "0x5A6758")]
	public class GetEventInfo : FsmStateAction
	{
		[Token(Token = "0x400520E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5AD8", Offset = "0x5F5AD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5AD8", Offset = "0x5F5AD8")]
		public FsmGameObject sentByGameObject;

		[Token(Token = "0x400520F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5B28", Offset = "0x5F5B28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5B28", Offset = "0x5F5B28")]
		public FsmString fsmName;

		[Token(Token = "0x4005210")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5B78", Offset = "0x5F5B78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5B78", Offset = "0x5F5B78")]
		public FsmBool getBoolData;

		[Token(Token = "0x4005211")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5BC8", Offset = "0x5F5BC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5BC8", Offset = "0x5F5BC8")]
		public FsmInt getIntData;

		[Token(Token = "0x4005212")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5C18", Offset = "0x5F5C18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5C18", Offset = "0x5F5C18")]
		public FsmFloat getFloatData;

		[Token(Token = "0x4005213")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5C68", Offset = "0x5F5C68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5C68", Offset = "0x5F5C68")]
		public FsmVector2 getVector2Data;

		[Token(Token = "0x4005214")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5CB8", Offset = "0x5F5CB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5CB8", Offset = "0x5F5CB8")]
		public FsmVector3 getVector3Data;

		[Token(Token = "0x4005215")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5D08", Offset = "0x5F5D08")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5D08", Offset = "0x5F5D08")]
		public FsmString getStringData;

		[Token(Token = "0x4005216")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5D58", Offset = "0x5F5D58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5D58", Offset = "0x5F5D58")]
		public FsmGameObject getGameObjectData;

		[Token(Token = "0x4005217")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5DA8", Offset = "0x5F5DA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5DA8", Offset = "0x5F5DA8")]
		public FsmRect getRectData;

		[Token(Token = "0x4005218")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5DF8", Offset = "0x5F5DF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5DF8", Offset = "0x5F5DF8")]
		public FsmQuaternion getQuaternionData;

		[Token(Token = "0x4005219")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5E48", Offset = "0x5F5E48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5E48", Offset = "0x5F5E48")]
		public FsmMaterial getMaterialData;

		[Token(Token = "0x400521A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5E98", Offset = "0x5F5E98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5E98", Offset = "0x5F5E98")]
		public FsmTexture getTextureData;

		[Token(Token = "0x400521B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5EE8", Offset = "0x5F5EE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5EE8", Offset = "0x5F5EE8")]
		public FsmColor getColorData;

		[Token(Token = "0x400521C")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5F38", Offset = "0x5F5F38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5F38", Offset = "0x5F5F38")]
		public FsmObject getObjectData;

		[Token(Token = "0x6006651")]
		[Address(RVA = "0x105FBF4", Offset = "0x105FBF4", VA = "0x105FBF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006652")]
		[Address(RVA = "0x105FC14", Offset = "0x105FC14", VA = "0x105FC14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006653")]
		[Address(RVA = "0x105FFA4", Offset = "0x105FFA4", VA = "0x105FFA4")]
		public GetEventInfo()
		{
		}
	}
}
