using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.AssetBundle;
using Technology.Core.Common;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BCA")]
	public abstract class Bundle : IBundable
	{
		[Token(Token = "0x2000BCB")]
		private class RequestState
		{
			[Token(Token = "0x4003B56")]
			[FieldOffset(Offset = "0x10")]
			public WebRequest Request;

			[Token(Token = "0x4003B57")]
			[FieldOffset(Offset = "0x18")]
			public long ContentLength;

			[Token(Token = "0x4003B58")]
			[FieldOffset(Offset = "0x20")]
			public WebException Exception;

			[Token(Token = "0x6004AD7")]
			[Address(RVA = "0x860824", Offset = "0x860824", VA = "0x860824")]
			public RequestState()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000BCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5983B4", Offset = "0x5983B4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003B59")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003B5A")]
			[FieldOffset(Offset = "0x8")]
			public static AsyncCallback _003C_003E9__109_0;

			[Token(Token = "0x6004AD9")]
			[Address(RVA = "0x8600DC", Offset = "0x8600DC", VA = "0x8600DC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004ADA")]
			[Address(RVA = "0x8600E4", Offset = "0x8600E4", VA = "0x8600E4")]
			internal void _003CFetchDownloadSize_003Eb__109_0(IAsyncResult result)
			{
			}
		}

		[Token(Token = "0x2000BCD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5983C4", Offset = "0x5983C4")]
		private sealed class _003CFetchDownloadSize_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003B5B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003B5C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003B5D")]
			[FieldOffset(Offset = "0x20")]
			public Bundle _003C_003E4__this;

			[Token(Token = "0x4003B5E")]
			[FieldOffset(Offset = "0x28")]
			private RequestState _003Cstate_003E5__2;

			[Token(Token = "0x4003B5F")]
			[FieldOffset(Offset = "0x30")]
			private IAsyncResult _003CasyncResult_003E5__3;

			[Token(Token = "0x17000975")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004ADE")]
				[Address(RVA = "0x860834", Offset = "0x860834", VA = "0x860834", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000976")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004AE0")]
				[Address(RVA = "0x86087C", Offset = "0x86087C", VA = "0x86087C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004ADB")]
			[Address(RVA = "0x8603B0", Offset = "0x8603B0", VA = "0x8603B0")]
			[DebuggerHidden]
			public _003CFetchDownloadSize_003Ed__109(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004ADC")]
			[Address(RVA = "0x8603DC", Offset = "0x8603DC", VA = "0x8603DC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004ADD")]
			[Address(RVA = "0x8603E0", Offset = "0x8603E0", VA = "0x8603E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004ADF")]
			[Address(RVA = "0x86083C", Offset = "0x86083C", VA = "0x86083C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003B39")]
		public const int VERSION_NOT_FOUND = -1;

		[Token(Token = "0x4003B3A")]
		protected const string VERSION_KEY_SUFFIX = "Ver";

		[Token(Token = "0x4003B48")]
		[FieldOffset(Offset = "0x68")]
		public bool LoadImmediately;

		[Token(Token = "0x4003B49")]
		[FieldOffset(Offset = "0x6C")]
		public uint LoadOrder;

		[Token(Token = "0x4003B4A")]
		[FieldOffset(Offset = "0x70")]
		private BundleState _state;

		[Token(Token = "0x4003B4B")]
		[FieldOffset(Offset = "0x74")]
		protected bool LoadedFromCache;

		[Token(Token = "0x4003B4C")]
		[FieldOffset(Offset = "0x78")]
		private long _contentLenght;

		[Token(Token = "0x4003B4D")]
		[FieldOffset(Offset = "0x80")]
		private float _downloadProgress;

		[Token(Token = "0x4003B4E")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD7D4", Offset = "0x5BD7D4")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x4003B4F")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD7E4", Offset = "0x5BD7E4")]
		private int _003CVersion_003Ek__BackingField;

		[Token(Token = "0x4003B50")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD7F4", Offset = "0x5BD7F4")]
		private AssetBundle _003CAsset_003Ek__BackingField;

		[Token(Token = "0x4003B51")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD804", Offset = "0x5BD804")]
		private Uri _003CUri_003Ek__BackingField;

		[Token(Token = "0x4003B52")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD814", Offset = "0x5BD814")]
		private string _003CUriResponseData_003Ek__BackingField;

		[Token(Token = "0x4003B53")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD824", Offset = "0x5BD824")]
		private BundleType _003CType_003Ek__BackingField;

		[Token(Token = "0x4003B54")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD834", Offset = "0x5BD834")]
		private uint _003CLoadAttempts_003Ek__BackingField;

		[Token(Token = "0x4003B55")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD844", Offset = "0x5BD844")]
		private string _003CSceneGroup_003Ek__BackingField;

		[Token(Token = "0x17000966")]
		public string Name
		{
			[Token(Token = "0x6004AB0")]
			[Address(RVA = "0xA88254", Offset = "0xA88254", VA = "0xA88254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C10", Offset = "0x627C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB1")]
			[Address(RVA = "0xA8825C", Offset = "0xA8825C", VA = "0xA8825C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C20", Offset = "0x627C20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000967")]
		public int Version
		{
			[Token(Token = "0x6004AB2")]
			[Address(RVA = "0xA88264", Offset = "0xA88264", VA = "0xA88264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C30", Offset = "0x627C30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AB3")]
			[Address(RVA = "0xA8826C", Offset = "0xA8826C", VA = "0xA8826C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C40", Offset = "0x627C40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000968")]
		public AssetBundle Asset
		{
			[Token(Token = "0x6004AB4")]
			[Address(RVA = "0xA88274", Offset = "0xA88274", VA = "0xA88274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C50", Offset = "0x627C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB5")]
			[Address(RVA = "0xA8827C", Offset = "0xA8827C", VA = "0xA8827C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C60", Offset = "0x627C60")]
			set
			{
			}
		}

		[Token(Token = "0x17000969")]
		public Uri Uri
		{
			[Token(Token = "0x6004AB6")]
			[Address(RVA = "0xA88284", Offset = "0xA88284", VA = "0xA88284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C70", Offset = "0x627C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB7")]
			[Address(RVA = "0xA8828C", Offset = "0xA8828C", VA = "0xA8828C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C80", Offset = "0x627C80")]
			set
			{
			}
		}

		[Token(Token = "0x1700096A")]
		public string UriResponseData
		{
			[Token(Token = "0x6004AB8")]
			[Address(RVA = "0xA88294", Offset = "0xA88294", VA = "0xA88294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C90", Offset = "0x627C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB9")]
			[Address(RVA = "0xA8829C", Offset = "0xA8829C", VA = "0xA8829C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627CA0", Offset = "0x627CA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700096B")]
		public BundleType Type
		{
			[Token(Token = "0x6004ABA")]
			[Address(RVA = "0xA882A4", Offset = "0xA882A4", VA = "0xA882A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627CB0", Offset = "0x627CB0")]
			get
			{
				return default(BundleType);
			}
			[Token(Token = "0x6004ABB")]
			[Address(RVA = "0xA882AC", Offset = "0xA882AC", VA = "0xA882AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627CC0", Offset = "0x627CC0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700096C")]
		public bool IsRemote
		{
			[Token(Token = "0x6004ABC")]
			[Address(RVA = "0xA882B4", Offset = "0xA882B4", VA = "0xA882B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700096D")]
		public bool IsCacheable
		{
			[Token(Token = "0x6004ABD")]
			[Address(RVA = "0xA883D8", Offset = "0xA883D8", VA = "0xA883D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700096E")]
		public bool IsCached
		{
			[Token(Token = "0x6004ABE")]
			[Address(RVA = "0xA884F4", Offset = "0xA884F4", VA = "0xA884F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700096F")]
		public uint LoadAttempts
		{
			[Token(Token = "0x6004ABF")]
			[Address(RVA = "0xA88548", Offset = "0xA88548", VA = "0xA88548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627CD0", Offset = "0x627CD0")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6004AC0")]
			[Address(RVA = "0xA88550", Offset = "0xA88550", VA = "0xA88550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627CE0", Offset = "0x627CE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000970")]
		public bool IsVersionFound
		{
			[Token(Token = "0x6004AC1")]
			[Address(RVA = "0xA88558", Offset = "0xA88558", VA = "0xA88558")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000971")]
		public string SceneGroup
		{
			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0xA88568", Offset = "0xA88568", VA = "0xA88568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627CF0", Offset = "0x627CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AC3")]
			[Address(RVA = "0xA88570", Offset = "0xA88570", VA = "0xA88570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627D00", Offset = "0x627D00")]
			set
			{
			}
		}

		[Token(Token = "0x17000972")]
		public BundleState State
		{
			[Token(Token = "0x6004AC4")]
			[Address(RVA = "0xA88578", Offset = "0xA88578", VA = "0xA88578")]
			get
			{
				return default(BundleState);
			}
			[Token(Token = "0x6004AC5")]
			[Address(RVA = "0xA88580", Offset = "0xA88580", VA = "0xA88580")]
			set
			{
			}
		}

		[Token(Token = "0x17000973")]
		public bool FromCache
		{
			[Token(Token = "0x6004AC6")]
			[Address(RVA = "0xA886F4", Offset = "0xA886F4", VA = "0xA886F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000974")]
		public float DownloadProgress
		{
			[Token(Token = "0x6004AC7")]
			[Address(RVA = "0xA88798", Offset = "0xA88798", VA = "0xA88798")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6004AC8")]
			[Address(RVA = "0xA88824", Offset = "0xA88824", VA = "0xA88824")]
			internal set
			{
			}
		}

		[Token(Token = "0x1400011C")]
		public static event BundleEventHandler OnLoadedBundle
		{
			[Token(Token = "0x6004A95")]
			[Address(RVA = "0xA86DC0", Offset = "0xA86DC0", VA = "0xA86DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A70", Offset = "0x627A70")]
			add
			{
			}
			[Token(Token = "0x6004A96")]
			[Address(RVA = "0xA86E7C", Offset = "0xA86E7C", VA = "0xA86E7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A80", Offset = "0x627A80")]
			remove
			{
			}
		}

		[Token(Token = "0x1400011D")]
		public static event BundleEventHandler OnDownloadReady
		{
			[Token(Token = "0x6004A97")]
			[Address(RVA = "0xA86F38", Offset = "0xA86F38", VA = "0xA86F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A90", Offset = "0x627A90")]
			add
			{
			}
			[Token(Token = "0x6004A98")]
			[Address(RVA = "0xA86FF8", Offset = "0xA86FF8", VA = "0xA86FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627AA0", Offset = "0x627AA0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400011E")]
		public event BundleEventHandler OnLoading
		{
			[Token(Token = "0x6004A9A")]
			[Address(RVA = "0xA87494", Offset = "0xA87494", VA = "0xA87494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627AB0", Offset = "0x627AB0")]
			add
			{
			}
			[Token(Token = "0x6004A9B")]
			[Address(RVA = "0xA87534", Offset = "0xA87534", VA = "0xA87534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627AC0", Offset = "0x627AC0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400011F")]
		public event BundleEventHandler OnLoaded
		{
			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0xA875D4", Offset = "0xA875D4", VA = "0xA875D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627AD0", Offset = "0x627AD0")]
			add
			{
			}
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0xA87674", Offset = "0xA87674", VA = "0xA87674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627AE0", Offset = "0x627AE0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000120")]
		public event BundleEventHandler OnUnloaded
		{
			[Token(Token = "0x6004A9E")]
			[Address(RVA = "0xA87714", Offset = "0xA87714", VA = "0xA87714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627AF0", Offset = "0x627AF0")]
			add
			{
			}
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0xA877B4", Offset = "0xA877B4", VA = "0xA877B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B00", Offset = "0x627B00")]
			remove
			{
			}
		}

		[Token(Token = "0x14000121")]
		public event BundleEventHandler OnError
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0xA87854", Offset = "0xA87854", VA = "0xA87854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B10", Offset = "0x627B10")]
			add
			{
			}
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0xA878F4", Offset = "0xA878F4", VA = "0xA878F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B20", Offset = "0x627B20")]
			remove
			{
			}
		}

		[Token(Token = "0x14000122")]
		public event BundleEventHandler OnLoadingFromCache
		{
			[Token(Token = "0x6004AA2")]
			[Address(RVA = "0xA87994", Offset = "0xA87994", VA = "0xA87994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B30", Offset = "0x627B30")]
			add
			{
			}
			[Token(Token = "0x6004AA3")]
			[Address(RVA = "0xA87A34", Offset = "0xA87A34", VA = "0xA87A34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B40", Offset = "0x627B40")]
			remove
			{
			}
		}

		[Token(Token = "0x14000123")]
		public event BundleEventHandler OnLoadingFromRemote
		{
			[Token(Token = "0x6004AA4")]
			[Address(RVA = "0xA87AD4", Offset = "0xA87AD4", VA = "0xA87AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B50", Offset = "0x627B50")]
			add
			{
			}
			[Token(Token = "0x6004AA5")]
			[Address(RVA = "0xA87B74", Offset = "0xA87B74", VA = "0xA87B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B60", Offset = "0x627B60")]
			remove
			{
			}
		}

		[Token(Token = "0x14000124")]
		public event BundleEventHandler OnLoadedFromRemote
		{
			[Token(Token = "0x6004AA6")]
			[Address(RVA = "0xA87C14", Offset = "0xA87C14", VA = "0xA87C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B70", Offset = "0x627B70")]
			add
			{
			}
			[Token(Token = "0x6004AA7")]
			[Address(RVA = "0xA87CB4", Offset = "0xA87CB4", VA = "0xA87CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B80", Offset = "0x627B80")]
			remove
			{
			}
		}

		[Token(Token = "0x14000125")]
		public event BundleEventHandler OnLoadedFromCache
		{
			[Token(Token = "0x6004AA8")]
			[Address(RVA = "0xA87D54", Offset = "0xA87D54", VA = "0xA87D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627B90", Offset = "0x627B90")]
			add
			{
			}
			[Token(Token = "0x6004AA9")]
			[Address(RVA = "0xA87DF4", Offset = "0xA87DF4", VA = "0xA87DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627BA0", Offset = "0x627BA0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000126")]
		public event BundleEventHandler OnLoadedFromGame
		{
			[Token(Token = "0x6004AAA")]
			[Address(RVA = "0xA87E94", Offset = "0xA87E94", VA = "0xA87E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627BB0", Offset = "0x627BB0")]
			add
			{
			}
			[Token(Token = "0x6004AAB")]
			[Address(RVA = "0xA87F34", Offset = "0xA87F34", VA = "0xA87F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627BC0", Offset = "0x627BC0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000127")]
		public event BundleEventHandler OnDownloaded
		{
			[Token(Token = "0x6004AAC")]
			[Address(RVA = "0xA87FD4", Offset = "0xA87FD4", VA = "0xA87FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627BD0", Offset = "0x627BD0")]
			add
			{
			}
			[Token(Token = "0x6004AAD")]
			[Address(RVA = "0xA88074", Offset = "0xA88074", VA = "0xA88074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627BE0", Offset = "0x627BE0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000128")]
		public event Action<float, float> OnDownloadProgressChanged
		{
			[Token(Token = "0x6004AAE")]
			[Address(RVA = "0xA88114", Offset = "0xA88114", VA = "0xA88114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627BF0", Offset = "0x627BF0")]
			add
			{
			}
			[Token(Token = "0x6004AAF")]
			[Address(RVA = "0xA881B4", Offset = "0xA881B4", VA = "0xA881B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627C00", Offset = "0x627C00")]
			remove
			{
			}
		}

		[Token(Token = "0x6004A99")]
		[Address(RVA = "0xA870B8", Offset = "0xA870B8", VA = "0xA870B8")]
		public static void RaiseOnDownloadReady(Bundle bundle)
		{
		}

		[Token(Token = "0x6004AC9")]
		public abstract IEnumerator Load();

		[Token(Token = "0x6004ACA")]
		protected abstract void HandleState(BundleState state);

		[Token(Token = "0x6004ACB")]
		protected abstract void ToJSON(JSONNode rootNode);

		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0xA8894C", Offset = "0xA8894C", VA = "0xA8894C")]
		protected Bundle(string name, string group, BundleType type, bool loadImmediately, uint loadorder, int version, Uri uri)
		{
		}

		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0xA88AE8", Offset = "0xA88AE8", VA = "0xA88AE8")]
		public static int GetVersion(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0xA88B5C", Offset = "0xA88B5C", VA = "0xA88B5C", Slot = "4")]
		public JSONNode ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0xA88D08", Offset = "0xA88D08", VA = "0xA88D08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0xA88D28", Offset = "0xA88D28", VA = "0xA88D28", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0xA88DD8", Offset = "0xA88DD8", VA = "0xA88DD8")]
		public void SetVersion(int version)
		{
		}

		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0xA88E44", Offset = "0xA88E44", VA = "0xA88E44", Slot = "8")]
		public void Unload()
		{
		}

		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0xA88F08", Offset = "0xA88F08", VA = "0xA88F08")]
		public long DownloadSize()
		{
			return default(long);
		}

		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0xA886DC", Offset = "0xA886DC", VA = "0xA886DC")]
		private void TriggerEvent(BundleEventHandler bundleevent)
		{
		}

		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0xA88AF0", Offset = "0xA88AF0", VA = "0xA88AF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627D10", Offset = "0x627D10")]
		private IEnumerator FetchDownloadSize()
		{
			return null;
		}

		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0xA88F38", Offset = "0xA88F38", VA = "0xA88F38")]
		private void OnInternetReachable(object sender, NetworkEvent e)
		{
		}
	}
}
