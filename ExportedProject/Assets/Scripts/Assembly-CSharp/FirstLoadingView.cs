using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000666")]
public class FirstLoadingView : BaseLoadingView
{
	[Token(Token = "0x2000667")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595848", Offset = "0x595848")]
	private sealed class _003CCheckGDPRVersion_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002382")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x20")]
		public FirstLoadingView _003C_003E4__this;

		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x28")]
		private PopupManager _003Cpm_003E5__2;

		[Token(Token = "0x1700055B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002992")]
			[Address(RVA = "0x87118C", Offset = "0x87118C", VA = "0x87118C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002994")]
			[Address(RVA = "0x8711D4", Offset = "0x8711D4", VA = "0x8711D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600298F")]
		[Address(RVA = "0x870FC8", Offset = "0x870FC8", VA = "0x870FC8")]
		[DebuggerHidden]
		public _003CCheckGDPRVersion_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002990")]
		[Address(RVA = "0x870FF4", Offset = "0x870FF4", VA = "0x870FF4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002991")]
		[Address(RVA = "0x870FF8", Offset = "0x870FF8", VA = "0x870FF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002993")]
		[Address(RVA = "0x871194", Offset = "0x871194", VA = "0x871194", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000668")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595858", Offset = "0x595858")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x10")]
		public int loadedVersion;

		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x18")]
		public FirstLoadingView _003C_003E4__this;

		[Token(Token = "0x6002995")]
		[Address(RVA = "0x870F4C", Offset = "0x870F4C", VA = "0x870F4C")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6002996")]
		[Address(RVA = "0x870F54", Offset = "0x870F54", VA = "0x870F54")]
		internal bool _003CTestOldVersion_003Eb__0(GeneralConfig.OldSaveGameVersionPopupInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000669")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595868", Offset = "0x595868")]
	private sealed class _003C_003Ec__DisplayClass14_1
	{
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x10")]
		public OfferReference loader;

		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002997")]
		[Address(RVA = "0x870F78", Offset = "0x870F78", VA = "0x870F78")]
		public _003C_003Ec__DisplayClass14_1()
		{
		}

		[Token(Token = "0x6002998")]
		[Address(RVA = "0x870F80", Offset = "0x870F80", VA = "0x870F80")]
		internal void _003CTestOldVersion_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200066A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595878", Offset = "0x595878")]
	private sealed class _003CTestOldVersion_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x20")]
		public FirstLoadingView _003C_003E4__this;

		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x1700055D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600299C")]
			[Address(RVA = "0x871774", Offset = "0x871774", VA = "0x871774", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600299E")]
			[Address(RVA = "0x8717BC", Offset = "0x8717BC", VA = "0x8717BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002999")]
		[Address(RVA = "0x8711DC", Offset = "0x8711DC", VA = "0x8711DC")]
		[DebuggerHidden]
		public _003CTestOldVersion_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600299A")]
		[Address(RVA = "0x871208", Offset = "0x871208", VA = "0x871208", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600299B")]
		[Address(RVA = "0x87120C", Offset = "0x87120C", VA = "0x87120C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600299D")]
		[Address(RVA = "0x87177C", Offset = "0x87177C", VA = "0x87177C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400237B")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UISlider _loadingSlider;

	[Token(Token = "0x400237C")]
	private const float LOAD_PROGRESSION_SPEED = 2f;

	[Token(Token = "0x400237D")]
	[FieldOffset(Offset = "0x0")]
	private static int _sceneLoadIndex;

	[Token(Token = "0x400237E")]
	[FieldOffset(Offset = "0x4")]
	private static float _loadProgression;

	[Token(Token = "0x400237F")]
	[FieldOffset(Offset = "0x98")]
	private float _loadLastUpdateTime;

	[Token(Token = "0x4002380")]
	[FieldOffset(Offset = "0x9C")]
	private bool _installPaused;

	[Token(Token = "0x4002381")]
	[FieldOffset(Offset = "0xA0")]
	private int _totalNumberOfSectionToDownload;

	[Token(Token = "0x600297D")]
	[Address(RVA = "0x956B5C", Offset = "0x956B5C", VA = "0x956B5C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600297E")]
	[Address(RVA = "0x957588", Offset = "0x957588", VA = "0x957588", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600297F")]
	[Address(RVA = "0x9576C0", Offset = "0x9576C0", VA = "0x9576C0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002980")]
	[Address(RVA = "0x95774C", Offset = "0x95774C", VA = "0x95774C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002981")]
	[Address(RVA = "0x957098", Offset = "0x957098", VA = "0x957098")]
	private void OnLoadingDone(bool display)
	{
	}

	[Token(Token = "0x6002982")]
	[Address(RVA = "0x957204", Offset = "0x957204", VA = "0x957204")]
	private void OnDownloadCompleted(bool completed)
	{
	}

	[Token(Token = "0x6002983")]
	[Address(RVA = "0x9578FC", Offset = "0x9578FC", VA = "0x9578FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DCE8", Offset = "0x61DCE8")]
	private IEnumerator CheckGDPRVersion()
	{
		return null;
	}

	[Token(Token = "0x6002984")]
	[Address(RVA = "0x957968", Offset = "0x957968", VA = "0x957968")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DD48", Offset = "0x61DD48")]
	private IEnumerator TestOldVersion()
	{
		return null;
	}

	[Token(Token = "0x6002985")]
	[Address(RVA = "0x9579D4", Offset = "0x9579D4", VA = "0x9579D4")]
	private void GrantOldVersionReward(Offer offer)
	{
	}

	[Token(Token = "0x6002986")]
	[Address(RVA = "0x957A58", Offset = "0x957A58", VA = "0x957A58")]
	private void LoadScene()
	{
	}

	[Token(Token = "0x6002987")]
	[Address(RVA = "0x957A5C", Offset = "0x957A5C", VA = "0x957A5C")]
	private void LoginToFirstPartySocial()
	{
	}

	[Token(Token = "0x6002988")]
	[Address(RVA = "0x957C58", Offset = "0x957C58", VA = "0x957C58")]
	private void OnLinkCallBack(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6002989")]
	[Address(RVA = "0x957D80", Offset = "0x957D80", VA = "0x957D80")]
	private void LoadGamePlay()
	{
	}

	[Token(Token = "0x600298A")]
	[Address(RVA = "0x957E10", Offset = "0x957E10", VA = "0x957E10")]
	private static void OnLoadStart(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600298B")]
	[Address(RVA = "0x957E64", Offset = "0x957E64", VA = "0x957E64")]
	protected void Update()
	{
	}

	[Token(Token = "0x600298C")]
	[Address(RVA = "0x957344", Offset = "0x957344", VA = "0x957344")]
	private void RefreshInstallProgression()
	{
	}

	[Token(Token = "0x600298D")]
	[Address(RVA = "0x957E68", Offset = "0x957E68", VA = "0x957E68")]
	private static float GetPercentage(int toDownload, int downloaded, int sectionCount)
	{
		return default(float);
	}

	[Token(Token = "0x600298E")]
	[Address(RVA = "0x957E90", Offset = "0x957E90", VA = "0x957E90")]
	public FirstLoadingView()
	{
	}
}
