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
	public class ChartAxisFormat: OfficeExtension.ClientObject
	{
		private Microsoft.ExcelServices.ChartFont m_font;
		private Microsoft.ExcelServices.ChartLineFormat m_line;

		/* Begin_PlaceHolder_ChartAxisFormat_Custom_Members */
		/* End_PlaceHolder_ChartAxisFormat_Custom_Members */
		public ChartAxisFormat(OfficeExtension.ClientRequestContext context, OfficeExtension.ObjectPath objectPath)
			: base(context, objectPath)
		{
		}
		
		
		public Microsoft.ExcelServices.ChartFont Font
		{
			get
			{
				if (this.m_font == null)
				{
					this.m_font = new Microsoft.ExcelServices.ChartFont(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Font", false /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_font;
			}
		}
		
		public Microsoft.ExcelServices.ChartLineFormat Line
		{
			get
			{
				if (this.m_line == null)
				{
					this.m_line = new Microsoft.ExcelServices.ChartLineFormat(this.Context, OfficeExtension.ObjectPathFactory._CreatePropertyObjectPath(this.Context, this, "Line", false /*isCollection*/, false /*isInvalidAfterRequest*/));	
				}
		
				return this.m_line;
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
		    if (!OfficeExtension.Utility._IsUndefined(obj["Font"]))
			{
		        this.Font._HandleResult(obj["Font"]);
			}
		    if (!OfficeExtension.Utility._IsUndefined(obj["Line"]))
			{
		        this.Line._HandleResult(obj["Line"]);
			}
		}
		
		/*
		 * Queues up a command to load the specified properties of the object. You must call "context.sync()" before reading the properties.
		 */
		public Microsoft.ExcelServices.ChartAxisFormat Load(OfficeExtension.LoadOption option) 
		{
			OfficeExtension.Utility._Load(this, option);
			return this;
		}
	}
}

