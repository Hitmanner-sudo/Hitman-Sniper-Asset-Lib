using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012C1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE524", Offset = "0x5AE524")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE524", Offset = "0x5AE524")]
	public class VideoPlayerSetVideoClip : FsmStateAction
	{
		[Token(Token = "0x40059E4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610B88", Offset = "0x610B88")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610B88", Offset = "0x610B88")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059E5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x610C1C", Offset = "0x610C1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610C1C", Offset = "0x610C1C")]
		public FsmObject videoClip;

		[Token(Token = "0x40059E6")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40059E7")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D77")]
		[Address(RVA = "0x13D21E8", Offset = "0x13D21E8", VA = "0x13D21E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D78")]
		[Address(RVA = "0x13D21F0", Offset = "0x13D21F0", VA = "0x13D21F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D79")]
		[Address(RVA = "0x13D22CC", Offset = "0x13D22CC", VA = "0x13D22CC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D7A")]
		[Address(RVA = "0x13D2384", Offset = "0x13D2384", VA = "0x13D2384")]
		public VideoPlayerSetVideoClip()
		{
		}
	}
}
