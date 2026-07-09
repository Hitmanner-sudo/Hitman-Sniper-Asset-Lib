using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BDB")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x598424", Offset = "0x598424")]
	public class LoadMeta
	{
		[Token(Token = "0x2000BDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59845C", Offset = "0x59845C")]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			[Token(Token = "0x4003B7C")]
			[FieldOffset(Offset = "0x10")]
			public Bundle bundle;

			[Token(Token = "0x4003B7D")]
			[FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<string, Bundle>, bool> _003C_003E9__0;

			[Token(Token = "0x6004B3C")]
			[Address(RVA = "0x8C18F4", Offset = "0x8C18F4", VA = "0x8C18F4")]
			public _003C_003Ec__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6004B3D")]
			[Address(RVA = "0x8C18FC", Offset = "0x8C18FC", VA = "0x8C18FC")]
			internal bool _003CRemove_003Eb__0(KeyValuePair<string, Bundle> entry)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000BDD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59846C", Offset = "0x59846C")]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			[Token(Token = "0x4003B7E")]
			[FieldOffset(Offset = "0x10")]
			public string sceneGroup;

			[Token(Token = "0x6004B3E")]
			[Address(RVA = "0x8C1960", Offset = "0x8C1960", VA = "0x8C1960")]
			public _003C_003Ec__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6004B3F")]
			[Address(RVA = "0x8C1968", Offset = "0x8C1968", VA = "0x8C1968")]
			internal bool _003CGetSceneGroupBundles_003Eb__0(Bundle b)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000BDE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59847C", Offset = "0x59847C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003B7F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003B80")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Bundle, uint> _003C_003E9__42_1;

			[Token(Token = "0x6004B41")]
			[Address(RVA = "0x8C18D4", Offset = "0x8C18D4", VA = "0x8C18D4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004B42")]
			[Address(RVA = "0x8C18DC", Offset = "0x8C18DC", VA = "0x8C18DC")]
			internal uint _003CGetSceneGroupBundles_003Eb__42_1(Bundle b)
			{
				return default(uint);
			}
		}

		[Token(Token = "0x4003B74")]
		[FieldOffset(Offset = "0x0")]
		public static readonly char GROUP_SEPARATOR;

		[Token(Token = "0x4003B75")]
		[FieldOffset(Offset = "0x8")]
		public static string editorDefaultSceneDirectory;

		[Token(Token = "0x4003B76")]
		[FieldOffset(Offset = "0x28")]
		private DistributionConfiguration _distributionConfiguration;

		[Token(Token = "0x4003B77")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD884", Offset = "0x5BD884")]
		private Dictionary<string, SceneGroupMeta> _003CLevelHierarchyMap_003Ek__BackingField;

		[Token(Token = "0x4003B78")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _additivePathMap;

		[Token(Token = "0x4003B79")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, Bundle> _bundlesMap;

		[Token(Token = "0x4003B7A")]
		[FieldOffset(Offset = "0x48")]
		private List<Bundle> _additiveBundles;

		[Token(Token = "0x4003B7B")]
		[FieldOffset(Offset = "0x50")]
		private bool _isInitialized;

		[Token(Token = "0x17000983")]
		public Bundle Item
		{
			[Token(Token = "0x6004B28")]
			[Address(RVA = "0x9CD188", Offset = "0x9CD188", VA = "0x9CD188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000984")]
		public DistributionConfiguration DistributionConfig
		{
			[Token(Token = "0x6004B29")]
			[Address(RVA = "0x9CD1EC", Offset = "0x9CD1EC", VA = "0x9CD1EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000985")]
		private bool IsEventOnBundleAddedDefined
		{
			[Token(Token = "0x6004B2A")]
			[Address(RVA = "0x9CDBC8", Offset = "0x9CDBC8", VA = "0x9CDBC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000986")]
		private bool IsEventOnBundleUpdatedDefined
		{
			[Token(Token = "0x6004B2B")]
			[Address(RVA = "0x9CDBD8", Offset = "0x9CDBD8", VA = "0x9CDBD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000987")]
		private bool IsEventOnBundleRemovedDefined
		{
			[Token(Token = "0x6004B2C")]
			[Address(RVA = "0x9CDBE8", Offset = "0x9CDBE8", VA = "0x9CDBE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000988")]
		public Dictionary<string, SceneGroupMeta> LevelHierarchyMap
		{
			[Token(Token = "0x6004B2D")]
			[Address(RVA = "0x9CDBF8", Offset = "0x9CDBF8", VA = "0x9CDBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628190", Offset = "0x628190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B2E")]
			[Address(RVA = "0x9CDC00", Offset = "0x9CDC00", VA = "0x9CDC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6281A0", Offset = "0x6281A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000989")]
		public ReadOnlyCollection<Bundle> AdditiveBundles
		{
			[Token(Token = "0x6004B2F")]
			[Address(RVA = "0x9CC510", Offset = "0x9CC510", VA = "0x9CC510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000129")]
		public event BundleMapEventHandler OnPrefabBundleAdded
		{
			[Token(Token = "0x6004B22")]
			[Address(RVA = "0x9CCDC8", Offset = "0x9CCDC8", VA = "0x9CCDC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628130", Offset = "0x628130")]
			add
			{
			}
			[Token(Token = "0x6004B23")]
			[Address(RVA = "0x9CCE68", Offset = "0x9CCE68", VA = "0x9CCE68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628140", Offset = "0x628140")]
			remove
			{
			}
		}

		[Token(Token = "0x1400012A")]
		public event BundleMapEventHandler OnPrefabBundleUpdated
		{
			[Token(Token = "0x6004B24")]
			[Address(RVA = "0x9CCF08", Offset = "0x9CCF08", VA = "0x9CCF08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628150", Offset = "0x628150")]
			add
			{
			}
			[Token(Token = "0x6004B25")]
			[Address(RVA = "0x9CCFA8", Offset = "0x9CCFA8", VA = "0x9CCFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628160", Offset = "0x628160")]
			remove
			{
			}
		}

		[Token(Token = "0x1400012B")]
		public event BundleMapEventHandler OnPrefabBundleRemoved
		{
			[Token(Token = "0x6004B26")]
			[Address(RVA = "0x9CD048", Offset = "0x9CD048", VA = "0x9CD048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628170", Offset = "0x628170")]
			add
			{
			}
			[Token(Token = "0x6004B27")]
			[Address(RVA = "0x9CD0E8", Offset = "0x9CD0E8", VA = "0x9CD0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628180", Offset = "0x628180")]
			remove
			{
			}
		}

		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x9CAD64", Offset = "0x9CAD64", VA = "0x9CAD64")]
		public LoadMeta()
		{
		}

		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x9CD228", Offset = "0x9CD228", VA = "0x9CD228")]
		protected bool LoadDistributionConfiguration()
		{
			return default(bool);
		}

		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x9CD31C", Offset = "0x9CD31C", VA = "0x9CD31C")]
		protected bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x9CE388", Offset = "0x9CE388", VA = "0x9CE388")]
		public void Add(Bundle bundle)
		{
		}

		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x9CE60C", Offset = "0x9CE60C", VA = "0x9CE60C")]
		public void Remove(Bundle bundle)
		{
		}

		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x9CEA58", Offset = "0x9CEA58", VA = "0x9CEA58")]
		public void Update(DLCEntry l_entry)
		{
		}

		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x9CEDD0", Offset = "0x9CEDD0", VA = "0x9CEDD0")]
		private static void Update(Bundle l_bundle, DLCEntry l_entry)
		{
		}

		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x9CE5A8", Offset = "0x9CE5A8", VA = "0x9CE5A8")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x9CDC08", Offset = "0x9CDC08", VA = "0x9CDC08")]
		private Uri MakeURI(string key, bool remote)
		{
			return null;
		}

		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x9CEEC4", Offset = "0x9CEEC4", VA = "0x9CEEC4")]
		private static Dictionary<string, string> MakeScenePathMap()
		{
			return null;
		}

		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x9CF1FC", Offset = "0x9CF1FC", VA = "0x9CF1FC")]
		public IEnumerable<Bundle> GetSceneGroupBundles(string sceneGroup)
		{
			return null;
		}
	}
}
