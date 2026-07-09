using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200129A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD8F4", Offset = "0x5AD8F4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD8F4", Offset = "0x5AD8F4")]
	public class VideoPlayerGetIsPlaying : FsmStateAction
	{
		[Token(Token = "0x400591B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DDDC", Offset = "0x60DDDC")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60DDDC", Offset = "0x60DDDC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400591C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60DE70", Offset = "0x60DE70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DE70", Offset = "0x60DE70")]
		public FsmBool isPlaying;

		[Token(Token = "0x400591D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DEC0", Offset = "0x60DEC0")]
		public FsmEvent isPlayingEvent;

		[Token(Token = "0x400591E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DEF8", Offset = "0x60DEF8")]
		public FsmEvent isNotPlayingEvent;

		[Token(Token = "0x400591F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DF30", Offset = "0x60DF30")]
		public bool everyframe;

		[Token(Token = "0x4005920")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005921")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x4005922")]
		[FieldOffset(Offset = "0x88")]
		private int _isPlaying;

		[Token(Token = "0x6006C98")]
		[Address(RVA = "0x13CD56C", Offset = "0x13CD56C", VA = "0x13CD56C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C99")]
		[Address(RVA = "0x13CD578", Offset = "0x13CD578", VA = "0x13CD578", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0x13CD73C", Offset = "0x13CD73C", VA = "0x13CD73C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C9B")]
		[Address(RVA = "0x13CD654", Offset = "0x13CD654", VA = "0x13CD654")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0x13CD59C", Offset = "0x13CD59C", VA = "0x13CD59C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C9D")]
		[Address(RVA = "0x13CD740", Offset = "0x13CD740", VA = "0x13CD740")]
		public VideoPlayerGetIsPlaying()
		{
		}
	}
}
