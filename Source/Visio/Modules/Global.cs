//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.VisioApi.GlobalHelperModules
{
	///<summary>
	/// Module GlobalModule
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsModule)]
	public static class GlobalModule
	{

		#region Fields

		private static COMObject _instance;

        internal static COMObject Instance
        {
	        get
	        {
		        return _instance;
	        }
	        set
	        {
		        if( (null == value) || (null == _instance) )
			        _instance = value;				
        	}
        }

		#endregion
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVDocument ActiveDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveDocument", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVPage ActivePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActivePage", paramsArray);
				NetOffice.VisioApi.IVPage newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVPage;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVWindow ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveWindow", paramsArray);
				NetOffice.VisioApi.IVWindow newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVDocuments Documents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Documents", paramsArray);
				NetOffice.VisioApi.IVDocuments newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVDocuments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVWindows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Windows", paramsArray);
				NetOffice.VisioApi.IVWindows newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static NetOffice.VisioApi.IVAddons Addons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Addons", paramsArray);
				NetOffice.VisioApi.IVAddons newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVAddons;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public static object Vbe
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Vbe", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
	}
}