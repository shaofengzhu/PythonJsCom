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
	public class ChartLegend: OfficeExtension.ClientObject
	{
		private Microsoft.ExcelServices.ChartLegendFormat m_format;
		private bool m_overlay;
		private string m_position;
		private bool m_visible;

		/* Begin_PlaceHolder_ChartLegend_Custom_Members */
		/* End_PlaceHolder_ChartLegend_Custom_Members */
		public ChartLegend(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		
		
		public Microsoft.ExcelServices.ChartLegendFormat Format
		{
			get
			{
				if (this.m_format == null)
				{
					this.m_format = new Microsoft.ExcelServices.ChartLegendFormat(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Format", false /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_format;
			}
		}

		public bool Overlay
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "overlay", this.m_overlay);
				return this.m_overlay;
			}

			set
			{
				this.m_overlay = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Overlay", value);
			}
		}

		public string Position
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "position", this.m_position);
				return this.m_position;
			}

			set
			{
				this.m_position = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Position", value);
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
			if (!OfficeExtension.Utility._IsUndefined(obj["Overlay"]))
			{
				this.LoadedPropertyNames.Add("Overlay");
				this.m_overlay = obj["Overlay"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Position"]))
			{
				this.LoadedPropertyNames.Add("Position");
				this.m_position = obj["Position"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Visible"]))
			{
				this.LoadedPropertyNames.Add("Visible");
				this.m_visible = obj["Visible"].ToObject<bool>();
			}
		
		    if (!OfficeExtension.Utility._IsUndefined(obj["Format"]))
			{
		        this.Format._HandleResult(obj["Format"]);
			}
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.ChartLegend Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

