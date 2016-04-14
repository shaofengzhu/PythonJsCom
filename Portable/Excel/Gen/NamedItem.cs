﻿/*
 * This is a generated file. 
 * If there are content placeholders, only edit content inside content placeholders.
 * If there are no content placeholders, do not edit this file directly.
 */
namespace Microsoft.ExcelServices
{
	using System;
	/* Begin_PlaceHolder_UsingHeader */
	/* End_PlaceHolder_UsingHeader */

	/* Begin_PlaceHolder_Header */
	/* End_PlaceHolder_Header */
	public class NamedItem: OfficeExtension.ClientObject
	{
		private string m_name;
		private string m_type;
		private object m_value;
		private bool m_visible;
		private string m__Id;

		/* Begin_PlaceHolder_NamedItem_Custom_Members */
		/* End_PlaceHolder_NamedItem_Custom_Members */
		public NamedItem(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		

		public string Name
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "name", this.m_name);
				return this.m_name;
			}
		}

		public string Type
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "type", this.m_type);
				return this.m_type;
			}
		}

		public object Value
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "value", this.m_value);
				return this.m_value;
			}
		}

		public bool Visible
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "visible", this.m_visible);
				return this.m_visible;
			}

			set
			{
				this.m_visible = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Visible", value);
			}
		}

		public string _Id
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "_Id", this.m__Id);
				return this.m__Id;
			}
		}

		public Microsoft.ExcelServices.Range GetRange()
		{
			/* Begin_PlaceHolder_NamedItem_GetRange */
			/* End_PlaceHolder_NamedItem_GetRange */
			return new Microsoft.ExcelServices.Range(this.Context, OfficeExtension.ObjectPathFactory._CreateMethodObjectPath(this.Context, this, "GetRange", OfficeExtension.OperationType.Read, new object[] {}, false /*isCollection*/, true /*isInvalidAfterRequest*/));
		}

			/** Handle results returned from the document
			 */
		public override void _HandleResult(Newtonsoft.Json.Linq.JToken value)
		{
			if (OfficeExtension.Utility._IsNullOrUndefined(value))
			{
				return;
			}
			Newtonsoft.Json.Linq.JObject obj = value as Newtonsoft.Json.Linq.JObject;
			if (obj == null)
			{
				return;
			}
		
			OfficeExtension.Utility._FixObjectPathIfNecessary(this, obj);
			if (!OfficeExtension.Utility._IsUndefined(obj["Name"]))
			{
				this.LoadedPropertyNames.Add("Name");
				this.m_name = obj["Name"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Type"]))
			{
				this.LoadedPropertyNames.Add("Type");
				this.m_type = obj["Type"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Value"]))
			{
				this.LoadedPropertyNames.Add("Value");
				this.m_value = obj["Value"].ToObject<object>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Visible"]))
			{
				this.LoadedPropertyNames.Add("Visible");
				this.m_visible = obj["Visible"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["_Id"]))
			{
				this.LoadedPropertyNames.Add("_Id");
				this.m__Id = obj["_Id"].ToObject<string>();
			}
		
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.NamedItem Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

