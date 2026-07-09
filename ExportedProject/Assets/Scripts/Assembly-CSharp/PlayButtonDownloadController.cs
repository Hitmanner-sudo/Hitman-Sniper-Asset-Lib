using System;
using Il2CppDummyDll;
using Technology.Core.Common;
using Technology.Distribution;
using UnityEngine;

[Token(Token = "0x2000532")]
public class PlayButtonDownloadController : UIController
{
	[Token(Token = "0x2000533")]
	private enum DownloadState
	{
		[Token(Token = "0x4001B97")]
		Started = 0,
		[Token(Token = "0x4001B98")]
		Completed = 1,
		[Token(Token = "0x4001B99")]
		Failed = 2,
		[Token(Token = "0x4001B9A")]
		Cancelled = 3
	}

	[Token(Token = "0x2000534")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595070", Offset = "0x595070")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4001B9B")]
		[FieldOffset(Offset = "0x10")]
		public SceneGroupMeta sceneGroup;

		[Token(Token = "0x4001B9C")]
		[FieldOffset(Offset = "0x18")]
		public long totalSize;

		[Token(Token = "0x4001B9D")]
		[FieldOffset(Offset = "0x20")]
		public long remainingSize;

		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0x28")]
		public PlayButtonDownloadController _003C_003E4__this;

		[Token(Token = "0x4001B9F")]
		[FieldOffset(Offset = "0x30")]
		public Bundle[] bundles;

		[Token(Token = "0x600207C")]
		[Address(RVA = "0x8D0E18", Offset = "0x8D0E18", VA = "0x8D0E18")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600207D")]
		[Address(RVA = "0x8D0E20", Offset = "0x8D0E20", VA = "0x8D0E20")]
		internal bool _003COnDifficultyChanged_003Eb__0(Bundle bundle)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000535")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595080", Offset = "0x595080")]
	private sealed class _003C_003Ec__DisplayClass11_1
	{
		[Token(Token = "0x4001BA0")]
		[FieldOffset(Offset = "0x10")]
		public ModeView modeView;

		[Token(Token = "0x4001BA1")]
		[FieldOffset(Offset = "0x18")]
		public EventHandler<EventArgs> onFadeOutDone;

		[Token(Token = "0x4001BA2")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600207E")]
		[Address(RVA = "0x8D0F0C", Offset = "0x8D0F0C", VA = "0x8D0F0C")]
		public _003C_003Ec__DisplayClass11_1()
		{
		}

		[Token(Token = "0x600207F")]
		[Address(RVA = "0x8D0F14", Offset = "0x8D0F14", VA = "0x8D0F14")]
		internal void _003COnDifficultyChanged_003Eb__2(object s, EventArgs e)
		{
		}
	}

	[Token(Token = "0x2000536")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595090", Offset = "0x595090")]
	private sealed class _003C_003Ec__DisplayClass11_2
	{
		[Token(Token = "0x4001BA3")]
		[FieldOffset(Offset = "0x10")]
		public long downloadedSize;

		[Token(Token = "0x4001BA4")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6002080")]
		[Address(RVA = "0x8D1208", Offset = "0x8D1208", VA = "0x8D1208")]
		public _003C_003Ec__DisplayClass11_2()
		{
		}

		[Token(Token = "0x6002081")]
		[Address(RVA = "0x8D1210", Offset = "0x8D1210", VA = "0x8D1210")]
		internal void _003COnDifficultyChanged_003Eb__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000537")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5950A0", Offset = "0x5950A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001BA5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001BA6")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Bundle, bool> _003C_003E9__11_1;

		[Token(Token = "0x4001BA7")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Bundle, bool> _003C_003E9__20_0;

		[Token(Token = "0x4001BA8")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Bundle, bool> _003C_003E9__20_1;

		[Token(Token = "0x6002083")]
		[Address(RVA = "0x8D0D9C", Offset = "0x8D0D9C", VA = "0x8D0D9C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002084")]
		[Address(RVA = "0x8D0DA4", Offset = "0x8D0DA4", VA = "0x8D0DA4")]
		internal bool _003COnDifficultyChanged_003Eb__11_1(Bundle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6002085")]
		[Address(RVA = "0x8D0DD4", Offset = "0x8D0DD4", VA = "0x8D0DD4")]
		internal bool _003COnBundleProgressChanged_003Eb__20_0(Bundle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6002086")]
		[Address(RVA = "0x8D0DF4", Offset = "0x8D0DF4", VA = "0x8D0DF4")]
		internal bool _003COnBundleProgressChanged_003Eb__20_1(Bundle b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000538")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5950B0", Offset = "0x5950B0")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x10")]
		public PlayButtonDownloadController _003C_003E4__this;

		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x18")]
		public Bundle[] bundles;

		[Token(Token = "0x4001BAB")]
		[FieldOffset(Offset = "0x20")]
		public Action<float, float> _003C_003E9__0;

		[Token(Token = "0x6002087")]
		[Address(RVA = "0x8D125C", Offset = "0x8D125C", VA = "0x8D125C")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6002088")]
		[Address(RVA = "0x8D1264", Offset = "0x8D1264", VA = "0x8D1264")]
		internal void _003COnDownloadAcceptedClicked_003Eb__0(float prev, float curr)
		{
		}
	}

	[Token(Token = "0x2000539")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5950C0", Offset = "0x5950C0")]
	private sealed class _003C_003Ec__DisplayClass19_1
	{
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x10")]
		public Action<float, float> onProgressChanged;

		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x18")]
		public BundleEventHandler onBundleDownloaded;

		[Token(Token = "0x4001BAE")]
		[FieldOffset(Offset = "0x20")]
		public BundleEventHandler onBundleError;

		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x28")]
		public Action onDisable;

		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x30")]
		public Bundle bundle;

		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x38")]
		public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002089")]
		[Address(RVA = "0x8D1288", Offset = "0x8D1288", VA = "0x8D1288")]
		public _003C_003Ec__DisplayClass19_1()
		{
		}

		[Token(Token = "0x600208A")]
		[Address(RVA = "0x8D1290", Offset = "0x8D1290", VA = "0x8D1290")]
		internal void _003COnDownloadAcceptedClicked_003Eb__1(Bundle downloadedBundle)
		{
		}

		[Token(Token = "0x600208B")]
		[Address(RVA = "0x8D1300", Offset = "0x8D1300", VA = "0x8D1300")]
		internal void _003COnDownloadAcceptedClicked_003Eb__2(Bundle errorBundle)
		{
		}

		[Token(Token = "0x600208C")]
		[Address(RVA = "0x8D1370", Offset = "0x8D1370", VA = "0x8D1370")]
		internal void _003COnDownloadAcceptedClicked_003Eb__3()
		{
		}
	}

	[Token(Token = "0x4001B90")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _downloadButton;

	[Token(Token = "0x4001B91")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ModesModel.MenuPages _pageID;

	[Token(Token = "0x4001B92")]
	[FieldOffset(Offset = "0x5C")]
	private bool _missionModelAdded;

	[Token(Token = "0x4001B93")]
	[FieldOffset(Offset = "0x5D")]
	private bool _errorShown;

	[Token(Token = "0x4001B95")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B79FC", Offset = "0x5B79FC")]
	private static bool _003COnDownloadingDeathValley_003Ek__BackingField;

	[Token(Token = "0x170004D8")]
	public static bool OnDownloadingDeathValley
	{
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x90C8B4", Offset = "0x90C8B4", VA = "0x90C8B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619408", Offset = "0x619408")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x90C900", Offset = "0x90C900", VA = "0x90C900")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619418", Offset = "0x619418")]
		private set
		{
		}
	}

	[Token(Token = "0x14000086")]
	private event Action _onDisable
	{
		[Token(Token = "0x6002069")]
		[Address(RVA = "0x90B8B8", Offset = "0x90B8B8", VA = "0x90B8B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6193E8", Offset = "0x6193E8")]
		add
		{
		}
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x90B958", Offset = "0x90B958", VA = "0x90B958")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6193F8", Offset = "0x6193F8")]
		remove
		{
		}
	}

	[Token(Token = "0x600206B")]
	[Address(RVA = "0x90B9F8", Offset = "0x90B9F8", VA = "0x90B9F8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x90BCB0", Offset = "0x90BCB0", VA = "0x90BCB0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x90BE6C", Offset = "0x90BE6C", VA = "0x90BE6C")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x600206E")]
	[Address(RVA = "0x90BF10", Offset = "0x90BF10", VA = "0x90BF10")]
	private void OnDifficultyChanged()
	{
	}

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x90C550", Offset = "0x90C550", VA = "0x90C550")]
	private static long GetTotalDownloadSize(Bundle[] bundles, out long remainingSize)
	{
		return default(long);
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x90C654", Offset = "0x90C654", VA = "0x90C654")]
	private static void RunInternetReachableTest()
	{
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x90C6B4", Offset = "0x90C6B4", VA = "0x90C6B4")]
	private void OnInternetReachable(object sender, NetworkEvent e)
	{
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x90C954", Offset = "0x90C954", VA = "0x90C954")]
	private void OnDownloadAcceptedClicked(Bundle[] bundles, float progress)
	{
	}

	[Token(Token = "0x6002075")]
	[Address(RVA = "0x90CF00", Offset = "0x90CF00", VA = "0x90CF00")]
	private void OnBundleProgressChanged(Bundle[] bundles)
	{
	}

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x90D428", Offset = "0x90D428", VA = "0x90D428")]
	private void ShowDownloadErrorMessage()
	{
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0x90D600", Offset = "0x90D600", VA = "0x90D600")]
	private void OnDownloadCanceledClicked()
	{
	}

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x90D6E8", Offset = "0x90D6E8", VA = "0x90D6E8")]
	private void OnDownloadButtonClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x90CD64", Offset = "0x90CD64", VA = "0x90CD64")]
	private void SendDownloadStateChangedMetric(DownloadState state)
	{
	}

	[Token(Token = "0x600207A")]
	[Address(RVA = "0x90D6EC", Offset = "0x90D6EC", VA = "0x90D6EC")]
	public PlayButtonDownloadController()
	{
	}

	[Token(Token = "0x600207B")]
	[Address(RVA = "0x90D6FC", Offset = "0x90D6FC", VA = "0x90D6FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619428", Offset = "0x619428")]
	private void _003COnEnable_003Eb__8_0(bool b)
	{
	}
}
