using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012BC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE394", Offset = "0x5AE394")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE394", Offset = "0x5AE394")]
	public class VideoPlayerSetTargetMaterialProperty : FsmStateAction
	{
		[Token(Token = "0x40059CC")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610600", Offset = "0x610600")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610600", Offset = "0x610600")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059CD")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610694", Offset = "0x610694")]
		public FsmString property;

		[Token(Token = "0x40059CE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6106E0", Offset = "0x6106E0")]
		public bool everyFrame;

		[Token(Token = "0x40059CF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059D0")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D5C")]
		[Address(RVA = "0x13D1760", Offset = "0x13D1760", VA = "0x13D1760", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D5D")]
		[Address(RVA = "0x13D176C", Offset = "0x13D176C", VA = "0x13D176C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D5E")]
		[Address(RVA = "0x13D1910", Offset = "0x13D1910", VA = "0x13D1910", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D5F")]
		[Address(RVA = "0x13D1868", Offset = "0x13D1868", VA = "0x13D1868")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D60")]
		[Address(RVA = "0x13D17B0", Offset = "0x13D17B0", VA = "0x13D17B0")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D61")]
		[Address(RVA = "0x13D1914", Offset = "0x13D1914", VA = "0x13D1914")]
		public VideoPlayerSetTargetMaterialProperty()
		{
		}
	}
}
