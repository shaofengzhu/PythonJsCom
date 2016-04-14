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
	public class ChartDataLabels: OfficeExtension.ClientObject
	{
		private Microsoft.ExcelServices.ChartDataLabelFormat m_format;
		private string m_position;
		private string m_separator;
		private bool m_showBubbleSize;
		private bool m_showCategoryName;
		private bool m_showLegendKey;
		private bool m_showPercentage;
		private bool m_showSeriesName;
		private bool m_showValue;

		/* Begin_PlaceHolder_ChartDataLabels_Custom_Members */
		/* End_PlaceHolder_ChartDataLabels_Custom_Members */
		public ChartDataLabels(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		
		
		public Microsoft.ExcelServices.ChartDataLabelFormat Format
		{
			get
			{
				if (this.m_format == null)
				{
					this.m_format = new Microsoft.ExcelServices.ChartDataLabelFormat(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Format", false /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_format;
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

		public string Separator
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "separator", this.m_separator);
				return this.m_separator;
			}

			set
			{
				this.m_separator = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "Separator", value);
			}
		}

		public bool ShowBubbleSize
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "showBubbleSize", this.m_showBubbleSize);
				return this.m_showBubbleSize;
			}

			set
			{
				this.m_showBubbleSize = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "ShowBubbleSize", value);
			}
		}

		public bool ShowCategoryName
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "showCategoryName", this.m_showCategoryName);
				return this.m_showCategoryName;
			}

			set
			{
				this.m_showCategoryName = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "ShowCategoryName", value);
			}
		}

		public bool ShowLegendKey
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "showLegendKey", this.m_showLegendKey);
				return this.m_showLegendKey;
			}

			set
			{
				this.m_showLegendKey = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "ShowLegendKey", value);
			}
		}

		public bool ShowPercentage
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "showPercentage", this.m_showPercentage);
				return this.m_showPercentage;
			}

			set
			{
				this.m_showPercentage = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "ShowPercentage", value);
			}
		}

		public bool ShowSeriesName
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "showSeriesName", this.m_showSeriesName);
				return this.m_showSeriesName;
			}

			set
			{
				this.m_showSeriesName = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "ShowSeriesName", value);
			}
		}

		public bool ShowValue
		{
			get
			{
				OfficeExtension.Utility._ThrowIfNotLoaded(this, "showValue", this.m_showValue);
				return this.m_showValue;
			}

			set
			{
				this.m_showValue = value;
				OfficeExtension.ActionFactory._CreateSetPropertyAction(this.Context, this, "ShowValue", value);
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
			if (!OfficeExtension.Utility._IsUndefined(obj["Position"]))
			{
				this.LoadedPropertyNames.Add("Position");
				this.m_position = obj["Position"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["Separator"]))
			{
				this.LoadedPropertyNames.Add("Separator");
				this.m_separator = obj["Separator"].ToObject<string>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["ShowBubbleSize"]))
			{
				this.LoadedPropertyNames.Add("ShowBubbleSize");
				this.m_showBubbleSize = obj["ShowBubbleSize"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["ShowCategoryName"]))
			{
				this.LoadedPropertyNames.Add("ShowCategoryName");
				this.m_showCategoryName = obj["ShowCategoryName"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["ShowLegendKey"]))
			{
				this.LoadedPropertyNames.Add("ShowLegendKey");
				this.m_showLegendKey = obj["ShowLegendKey"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["ShowPercentage"]))
			{
				this.LoadedPropertyNames.Add("ShowPercentage");
				this.m_showPercentage = obj["ShowPercentage"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["ShowSeriesName"]))
			{
				this.LoadedPropertyNames.Add("ShowSeriesName");
				this.m_showSeriesName = obj["ShowSeriesName"].ToObject<bool>();
			}
		
			if (!OfficeExtension.Utility._IsUndefined(obj["ShowValue"]))
			{
				this.LoadedPropertyNames.Add("ShowValue");
				this.m_showValue = obj["ShowValue"].ToObject<bool>();
			}
		
		    if (!OfficeExtension.Utility._IsUndefined(obj["Format"]))
			{
		        this.Format._HandleResult(obj["Format"]);
			}
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.ChartDataLabels Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

