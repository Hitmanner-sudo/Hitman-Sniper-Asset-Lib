using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001101")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A516C", Offset = "0x5A516C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A516C", Offset = "0x5A516C")]
	public class SetAmbientLight : FsmStateAction
	{
		[Token(Token = "0x4005087")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0188", Offset = "0x5F0188")]
		public FsmColor ambientColor;

		[Token(Token = "0x4005088")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F01D4", Offset = "0x5F01D4")]
		public bool everyFrame;

		[Token(Token = "0x6006521")]
		[Address(RVA = "0x1034A70", Offset = "0x1034A70", VA = "0x1034A70", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006522")]
		[Address(RVA = "0x1034AA4", Offset = "0x1034AA4", VA = "0x1034AA4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006523")]
		[Address(RVA = "0x1034B04", Offset = "0x1034B04", VA = "0x1034B04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006524")]
		[Address(RVA = "0x1034AE0", Offset = "0x1034AE0", VA = "0x1034AE0")]
		private void DoSetAmbientColor()
		{
		}

		[Token(Token = "0x6006525")]
		[Address(RVA = "0x1034B08", Offset = "0x1034B08", VA = "0x1034B08")]
		public SetAmbientLight()
		{
		}
	}
}
