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
	public class ChartFont: OfficeExtension.ClientObject
	{
		private bool m_bold;
		private string m_color;
		private bool m_italic;
		private string m_name;
		private double m_size;
		private string m_underline;

		/* Begin_PlaceHolder_ChartFont_Custom_Members */
		/* End_PlaceHolder_ChartFont_Custom_Members */
		public ChartFont(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		

		public bool Bold
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "bold", this.m_bold);
				return this.m_bold;
			}

			set
			{
				this.m_bold = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Bold", value);
			}
		}

		public string Color
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "color", this.m_color);
				return this.m_color;
			}

			set
			{
				this.m_color = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Color", value);
			}
		}

		public bool Italic
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "italic", this.m_italic);
				return this.m_italic;
			}

			set
			{
				this.m_italic = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Italic", value);
			}
		}

		public string Name
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "name", this.m_name);
				return this.m_name;
			}

			set
			{
				this.m_name = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Name", value);
			}
		}

		public double Size
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "size", this.m_size);
				return this.m_size;
			}

			set
			{
				this.m_size = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Size", value);
			}
		}

		public string Underline
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "underline", this.m_underline);
				return this.m_underline;
			}

			set
			{
				this.m_underline = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Underline", value);
			}
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
			if (!OfficeExtension.Utility._IsUndefined(obj["Bold"]))
			{
				this.LoadedPropertyNames.Add("Bold");
				this.m_bold = obj["Bold"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Color"]))
			{
				this.LoadedPropertyNames.Add("Color");
				this.m_color = obj["Color"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Italic"]))
			{
				this.LoadedPropertyNames.Add("Italic");
				this.m_italic = obj["Italic"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Name"]))
			{
				this.LoadedPropertyNames.Add("Name");
				this.m_name = obj["Name"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Size"]))
			{
				this.LoadedPropertyNames.Add("Size");
				this.m_size = obj["Size"].ToObject<double>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Underline"]))
			{
				this.LoadedPropertyNames.Add("Underline");
				this.m_underline = obj["Underline"].ToObject<string>();
			}
		
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.ChartFont Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

