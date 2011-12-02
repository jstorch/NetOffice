﻿//Generated by LateBindingApi.CodeGenerator
using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using LateBindingApi.Core;

namespace AccessApi.Utils
{
	#pragma warning disable
    /// <summary>
    /// necessary factory info, used from LateBindingApi.Core.Factory while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Field

        private string   _namespace     = "NetOffice.AccessApi";
        private Guid     _componentGuid = new Guid("4AFFC9A0-5F99-101B-AF4E-00AA003F0F07");
        private Assembly _assembly;
		private Type[]	 _exportedTypes;

        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

		public bool Contains(string className)
		{
			if(null == _exportedTypes)
				_exportedTypes = Assembly.GetExportedTypes();
			
			foreach (Type item in _exportedTypes)
            {
				if (item.Name.EndsWith(className, StringComparison.InvariantCultureIgnoreCase))
					return true;
            }
				
			return false;			
		}
		
        public string Namespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        #endregion
    }
    #pragma warning restore
}