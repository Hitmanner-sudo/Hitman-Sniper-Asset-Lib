using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F42")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C410", Offset = "0x59C410")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C410", Offset = "0x59C410")]
	public class WorldToScreenPoint : FsmStateAction
	{
		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD1B0", Offset = "0x5CD1B0")]
		public FsmGameObject camera;

		[Token(Token = "0x40047FA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CD1E8", Offset = "0x5CD1E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD1E8", Offset = "0x5CD1E8")]
		public FsmVector3 worldPosition;

		[Token(Token = "0x40047FB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD238", Offset = "0x5CD238")]
		public FsmFloat worldX;

		[Token(Token = "0x40047FC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD270", Offset = "0x5CD270")]
		public FsmFloat worldY;

		[Token(Token = "0x40047FD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD2A8", Offset = "0x5CD2A8")]
		public FsmFloat worldZ;

		[Token(Token = "0x40047FE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CD2E0", Offset = "0x5CD2E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD2E0", Offset = "0x5CD2E0")]
		public FsmVector3 storeScreenPoint;

		[Token(Token = "0x40047FF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CD330", Offset = "0x5CD330")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD330", Offset = "0x5CD330")]
		public FsmFloat storeScreenX;

		[Token(Token = "0x4004800")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CD380", Offset = "0x5CD380")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD380", Offset = "0x5CD380")]
		public FsmFloat storeScreenY;

		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD3D0", Offset = "0x5CD3D0")]
		public FsmBool normalize;

		[Token(Token = "0x4004802")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD408", Offset = "0x5CD408")]
		public bool everyFrame;

		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject cameraGameObject;

		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0xA8")]
		private Camera screenCamera;

		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x87FE2C", Offset = "0x87FE2C", VA = "0x87FE2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x87FEF0", Offset = "0x87FEF0", VA = "0x87FEF0")]
		private void InitCamera()
		{
		}

		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x880098", Offset = "0x880098", VA = "0x880098", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D63")]
		[Address(RVA = "0x880324", Offset = "0x880324", VA = "0x880324", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D64")]
		[Address(RVA = "0x8800D4", Offset = "0x8800D4", VA = "0x8800D4")]
		private void DoWorldToScreenPoint()
		{
		}

		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x880328", Offset = "0x880328", VA = "0x880328", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x880470", Offset = "0x880470", VA = "0x880470")]
		public WorldToScreenPoint()
		{
		}
	}
}
