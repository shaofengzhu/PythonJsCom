﻿using System;
using System.Collections.Generic;
using Microsoft.OfficeExtension.CodeGen;

[assembly: ClientCallableNamespaceMap("ExcelApi", ComInterfaceNamespaceName="ExcelApi", ComCoClassNamespaceName = "ExcelApiImpl", TypeScriptNamespaceName = "FakeExcelApi", WacNamespaceName="ExcelApiWac")]

// Do not add E_ABORT as we want to test the case when E_ABORT is defined on the method level
// [assembly: HResultError(ExcelApi.HResultExpressions.E_ABORT, HttpStatusCode.InternalServerError, ExcelApi.ErrorCodes.Aborted, ExcelApi.ErrorMessageIds.Aborted)]
[assembly: HResultError(ExcelApi.HResultExpressions.E_ACCESSDENIED, HttpStatusCode.Unauthorized, ExcelApi.ErrorCodes.AccessDenied, ExcelApi.ErrorMessageIds.AccessDenied)]
[assembly: HResultError(ExcelApi.HResultExpressions.E_BOUNDS, HttpStatusCode.BadRequest, ExcelApi.ErrorCodes.OutOfRange, ExcelApi.ErrorMessageIds.OutOfRange)]
[assembly: HResultError(ExcelApi.HResultExpressions.E_CHANGED_STATE, HttpStatusCode.Conflict, ExcelApi.ErrorCodes.Conflict, ExcelApi.ErrorMessageIds.Conflict)]
[assembly: HResultError(ExcelApi.HResultExpressions.E_INVALIDARG, HttpStatusCode.BadRequest, ExcelApi.ErrorCodes.InvalidParameter, ExcelApi.ErrorMessageIds.InvalidParameter)]
[assembly: HResultDefaultError(HttpStatusCode.InternalServerError, ExcelApi.ErrorCodes.GeneralException, ExcelApi.ErrorMessageIds.GeneralException)]

namespace ExcelApi
{
	/// <summary>
	/// Dispatch id. Order by the type name, then order by the dispatch id
	/// </summary>
	internal static class DispatchIds
	{
		internal const int Application_ActiveWorkbook = 1;
		internal const int Application_TestWorkbook = 2;
		internal const int Application_GetObjectTypeNameByReferenceId = 3;
		internal const int Application_GetObjectByReferenceId = 4;
		internal const int Application_RemoveReference = 5;
		internal const int Application_HasBase = 6;

		internal const int Chart_Name = 1;
		internal const int Chart_ChartType = 2;
		internal const int Chart_Title = 3;
		internal const int Chart_Delete = 4;
		internal const int Chart_Id = 5;
		internal const int Chart_NullableChartType = 6;
		internal const int Chart_NullableShowLabel = 7;
		internal const int Chart_ImageData = 8;
		internal const int Chart_GetAsImage = 9;

		internal const int ChartCollection_Count = 1;
		internal const int ChartCollection_Indexer = 2;
		internal const int ChartCollection_Add = 3;
		internal const int ChartCollection_GetItemAt = 4;

		internal const int QueryWithSortField_RowLimit = 1;
		internal const int QueryWithSortField_Field = 2;

		internal const int Range_RowIndex = 1;
		internal const int Range_ColumnIndex = 2;
		internal const int Range_Value = 3;
		internal const int Range_ReplaceValue = 4;
		internal const int Range_Activate = 5;
		internal const int Range_Text = 6;
		internal const int Range_ValueArray = 7;
		internal const int Range_TextArray = 8;
		internal const int Range_LogText = 9;
		internal const int Range_ReferenceId = 10;
		internal const int Range_KeepReference = 11;
		internal const int Range_ValueArray2 = 12;
		internal const int Range_GetValueArray2 = 13;
		internal const int Range_SetValueArray2 = 14;
		internal const int Range_OnAccess = 15;
		internal const int Range_ValueTypeArray = 16;
		internal const int Range_NotRestMethod = 17;
		internal const int Range_Sort = 18;

		internal const int RangeSort_Apply = 1;
		internal const int RangeSort_Fields = 2;
		internal const int RangeSort_ApplyAndReturnFirstField = 3;
		internal const int RangeSort_QueryField = 4;
		internal const int RangeSort_ApplyQueryWithSortField = 5;
		internal const int RangeSort_ApplyMixed = 6;
		internal const int RangeSort_Fields2 = 7;

		internal const int SortField_ColumnIndex = 1;
		internal const int SortField_Assending = 2;
		internal const int SortField_UseCurrentCulture = 3;

		internal const int TestCaseObject_CalculateAddressAndSaveToRange = 1;
		internal const int TestCaseObject_TestParamBool = 2;
		internal const int TestCaseObject_TestParamInt = 3;
		internal const int TestCaseObject_TestParamFloat = 4;
		internal const int TestCaseObject_TestParamDouble = 5;
		internal const int TestCaseObject_TestParamString = 6;
		internal const int TestCaseObject_TestParamRange = 7;
		internal const int TestCaseObject_TestUrlKeyValueDecode = 8;
		internal const int TestCaseObject_TestUrlPathEncode = 9;
		internal const int TestCaseObject_Sum = 10;
		internal const int TestCaseObject_MatrixSum = 11;

		internal const int TestWorkbook_ErrorWorksheet = 1;
		internal const int TestWorkbook_ErrorMethod = 2;
		internal const int TestWorkbook_GetObjectCount = 3;
		internal const int TestWorkbook_GetActiveWorksheet = 4;
		internal const int TestWorkbook_ErrorWorksheet2 = 5;
		internal const int TestWorkbook_ErrorMethod2 = 6;
		internal const int TestWorkbook_TestNullableInputValue = 7;
		internal const int TestWorkbook_GetNullableEnumValue = 8;
		internal const int TestWorkbook_GetNullableBoolValue = 9;
		internal const int TestWorkbook_GetCachedObjectCount = 10;

		internal const int Workbook_Sheets = 1;
		internal const int Workbook_ActiveWorksheet = 2;
		internal const int Workbook_Charts = 3;
		internal const int Workbook_GetChartByType = 4;
		internal const int Workbook_GetChartByTypeTitle = 5;
		internal const int Workbook_SomeAction = 6;

		internal const int Worksheet_Range = 1;
		internal const int Worksheet_SomeRangeOperation = 2;
		internal const int Worksheet_Name = 3;
		internal const int Worksheet_ActiveCell = 4;
		internal const int Worksheet_ActiveCellInvalidAfterRequest = 5;
		internal const int Worksheet_Id = 6;
		internal const int Worksheet_CalculatedName = 7;
		internal const int Worksheet_NullRange = 8;
		internal const int Worksheet_NullChart = 9;
		internal const int Worksheet_RestOnly = 10;

		internal const int WorksheetCollection_Indexer = 1;
		internal const int WorksheetCollection_GetActiveWorksheetInvalidAfterRequest = 2;
		internal const int WorksheetCollection_GetItem = 3;
		internal const int WorksheetCollection_FindSheet = 4;
		internal const int WorksheetCollection_Add = 5;
	}

	internal static class HResultExpressions
	{
		internal const string E_ACCESSDENIED = "E_ACCESSDENIED";
		internal const string E_INVALIDARG = "E_INVALIDARG";
		internal const string E_CHANGED_STATE = "E_CHANGED_STATE";
		internal const string E_BOUNDS = "E_BOUNDS";
		internal const string E_ABORT = "E_ABORT";
	}

	internal static class ErrorCodes
	{
		internal const string InvalidParameter = "InvalidArgument";
		internal const string AccessDenied = "AccessDenied";
		internal const string AccessDenied2 = "AccessDenied2";
		internal const string Conflict = "Conflict";
		internal const string Conflict2 = "Conflict2";
		internal const string OutOfRange = "OutOfRange";
		internal const string Aborted = "Aborted";
		internal const string Aborted2 = "Aborted2";
		internal const string GeneralException = "GeneralException";
	}

	internal static class ErrorMessageIds
	{
		internal const string InvalidParameter = "(int)ResourceIds::InvalidParameter";
		internal const string AccessDenied = "(int)ResourceIds::AccessDenied";
		internal const string AccessDenied2 = "(int)ResourceIds::AccessDenied";
		internal const string Conflict = "(int)ResourceIds::Conflict";
		internal const string Conflict2 = "(int)ResourceIds::Conflict";
		internal const string OutOfRange = "(int)ResourceIds::OutOfRange";
		internal const string Aborted = "(int)ResourceIds::Aborted";
		internal const string Aborted2 = "(int)ResourceIds::Aborted";
		internal const string GeneralException = "(int)ResourceIds::GeneralException";
	}

	/// <summary>
	/// Chart type
	/// </summary>
	[ApiSet(Version = 1.1)]
	public enum ChartType
	{
		/// <summary>
		/// Not specified
		/// </summary>
		None = 0,
		/// <summary>
		/// Pie chart
		/// </summary>
		Pie = 1,
		/// <summary>
		/// Bar chart
		/// </summary>
		Bar = 2,
		/// <summary>
		/// Line chart
		/// </summary>
		Line = 3,
		/// <summary>
		/// 3D chart
		/// </summary>
		_3DBar = 4,
	}

	public enum RangeValueType
	{
		Unknown = 0,
		Empty = 1,
		String = 2,
		Integer = 3,
		Double = 4,
		Boolean = 5,
		Error = 6,
	}


	[ClientCallableComType(Name = "IApplication", InterfaceId = "669eb674-96a9-431b-b26a-2f0b82b2542a", CoClassName = "Application")]
	public interface Application
	{
		[ClientCallableComMember(DispatchId = DispatchIds.Application_ActiveWorkbook)]
		Workbook ActiveWorkbook { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Application_TestWorkbook)]
		TestWorkbook TestWorkbook { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Application_GetObjectByReferenceId)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		object _GetObjectByReferenceId(string referenceId);

		[ClientCallableComMember(DispatchId = DispatchIds.Application_GetObjectTypeNameByReferenceId)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		string _GetObjectTypeNameByReferenceId(string referenceId);

		[ClientCallableComMember(DispatchId = DispatchIds.Application_RemoveReference)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		void _RemoveReference(string referenceId);

		[ClientCallableComMember(DispatchId = DispatchIds.Application_HasBase)]
		bool HasBase { get; }
	}

	[ClientCallableType(DeleteOperationName = "Delete")]
	[ClientCallableComType(Name = "IChart", InterfaceId = "d0447bab-634b-46ef-b9e9-c05fd58456f3", CoClassName = "Chart")]
	[ApiSet(Version = 1.1)]
	public interface Chart
	{
		[ApiSet(Version = 1.1)]
		[ClientCallableComMember(DispatchId = DispatchIds.Chart_Id)]
		int Id { get; }

		[ApiSet(Version = 1.1)]
		[ClientCallableComMember(DispatchId = DispatchIds.Chart_ChartType)]
		ChartType ChartType { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Chart_NullableChartType)]
		ChartType? NullableChartType { get; [ApiSet(Version = 1.2)] set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Chart_NullableShowLabel)]
		bool? NullableShowLabel { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Chart_Name)]
		string Name { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Chart_Title)]
		string Title { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Chart_ImageData)]
		string ImageData { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Chart_GetAsImage)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		[ApiSet(Version = 1.2)]
		System.IO.Stream GetAsImage([ApiSet(Version = 1.3)]bool large);

		/// <summary>
		/// Delete the chart
		/// </summary>
		[ClientCallableComMember(DispatchId = DispatchIds.Chart_Delete)]
		void Delete();
	}

	/// <summary>
	/// Chart collection
	/// </summary>
	[ClientCallableType(CreateItemOperationName = "Add")]
	[ClientCallableComType(Name = "IChartCollection", InterfaceId = "d22ddf8f-a9a0-4b2a-b860-d7db0ff9eccc", CoClassName = "ChartCollection")]
	public interface ChartCollection : IEnumerable<Chart>
	{
		/// <summary>
		/// Gets the number of charts
		/// </summary>
		[ClientCallableComMember(DispatchId = DispatchIds.ChartCollection_Count)]
		int Count { get; }

		/// <summary>
		/// Get the chart at the index
		/// </summary>
		/// <param name="index">The index</param>
		/// <returns>The chart at the index</returns>
		[ClientCallableComMember(DispatchId = DispatchIds.ChartCollection_Indexer)]
		Chart this[object index] { get; }

		/// <summary>
		/// Add a new chart to the collection
		/// </summary>
		/// <param name="name">The name of the chart to be added</param>
		/// <param name="chartType">The type of the chart to be added</param>
		/// <returns>The newly added chart</returns>
		[ClientCallableComMember(DispatchId = DispatchIds.ChartCollection_Add)]
		Chart Add(string name, ChartType chartType);

		/// <summary>
		/// Get the chart at the position
		/// </summary>
		/// <param name="ordinal">The position</param>
		/// <returns>The chart at the position</returns>
		[ClientCallableOperation(OperationType = OperationType.Read)]
		[ClientCallableComMember(DispatchId = DispatchIds.ChartCollection_GetItemAt)]
		Chart GetItemAt(int ordinal);
	}

	public enum ErrorMethodType
	{
		None = 0,
		AccessDenied = 1,
		StateChanged = 2,
		Bounds = 3,
		Abort = 4,
	}

	[ClientCallableComType(Name = "ITestWorkbook", InterfaceId = "9d460404-bcf7-4f46-99d5-f07e7c4ad2de", CoClassName = "TestWorkbook")]
	public interface TestWorkbook
	{
		/// <summary>
		/// When this property is accessed, the server will return errorCode E_CHANGED_STATE
		/// </summary>
		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_ErrorWorksheet)]
		[ClientCallableProperty(ExcludedFromRest = true)]
		Worksheet ErrorWorksheet { get; }

		/// <summary>
		/// When this property is accessed, the server will return errorCode
		/// </summary>
		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_ErrorWorksheet2)]
		[HResultError(HResultExpressions.E_CHANGED_STATE, HttpStatusCode.Conflict, ErrorCodes.Conflict2, ErrorMessageIds.Conflict2)]
		Worksheet ErrorWorksheet2 { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_GetActiveWorksheet)]
		[ClientCallableOperation(OperationType = OperationType.Read, RESTfulName = "ActiveWorksheet")]
		Worksheet GetActiveWorksheet();

		/// <summary>
		/// When this method is invoked, the server will return errorCode. The errorCode is dependent on the ErrorMethodType input.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_ErrorMethod)]
		string ErrorMethod(ErrorMethodType input);

		/// <summary>
		/// When this method is invoked, the server will return errorCode. The errorCode is dependent on the ErrorMethodType input.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_ErrorMethod2)]
		[HResultError(HResultExpressions.E_ABORT, HttpStatusCode.InternalServerError, ErrorCodes.Aborted2, ErrorMessageIds.Aborted2)]
		[HResultError(HResultExpressions.E_ACCESSDENIED, HttpStatusCode.Forbidden, ErrorCodes.AccessDenied2, ErrorMessageIds.AccessDenied2)]
		string ErrorMethod2(ErrorMethodType input);

		/// <summary>
		/// Get the total count of active COM objects
		/// </summary>
		/// <returns></returns>
		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_GetObjectCount)]
		int GetObjectCount();

		/// <summary>
		/// Get the total count of active cached range data objects
		/// </summary>
		/// <returns></returns>
		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_GetCachedObjectCount)]
		int GetCachedObjectCount();

		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_TestNullableInputValue)]
		string TestNullableInputValue(ChartType? chartType, bool? boolValue);

		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_GetNullableBoolValue)]
		bool? GetNullableBoolValue(bool nullable);

		[ClientCallableComMember(DispatchId = DispatchIds.TestWorkbook_GetNullableEnumValue)]
		ChartType? GetNullableEnumValue(bool nullable);
	}

	[ClientCallableComType(Name = "IWorkbook", InterfaceId = "bb02266c-6204-4e0d-baa3-cc1a928f573e", CoClassName = "Workbook")]
	public interface Workbook
	{
		[ClientCallableComMember(DispatchId = DispatchIds.Workbook_ActiveWorksheet)]
		[ClientCallableProperty(WacAsync = true)]
		Worksheet ActiveWorksheet { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Workbook_Sheets)]
		WorksheetCollection Sheets { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Workbook_Charts)]
		ChartCollection Charts { get; }

		[ClientCallableOperation(OperationType = OperationType.Read)]
		[ClientCallableComMember(DispatchId = DispatchIds.Workbook_GetChartByType)]
		Chart GetChartByType(ChartType chartType);

		[ClientCallableOperation(OperationType = OperationType.Read)]
		[ClientCallableComMember(DispatchId = DispatchIds.Workbook_GetChartByTypeTitle)]
		Chart GetChartByTypeTitle(ChartType chartType, string title);

		[ClientCallableComMember(DispatchId = DispatchIds.Workbook_SomeAction)]
		string SomeAction(int intVal, string strVal, ChartType enumVal);
	}

	[ClientCallableComType(Name = "IWorksheet", InterfaceId = "b86e5ae1-476e-4e56-825d-885468e549f3", CoClassName = "Worksheet")]
	public interface Worksheet
	{
		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_Id)]
		int _Id { get; }

		[ClientCallableProperty(IsVolatile = true)]
		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_ActiveCell)]
		Range ActiveCell { get; }

		[ClientCallableProperty(InvalidateReturnObjectPathAfterRequest = true)]
		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_ActiveCellInvalidAfterRequest)]
		Range ActiveCellInvalidAfterRequest { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_Name)]
		string Name { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_CalculatedName)]
		[ClientCallableProperty(WacAsync = true, ExcludedFromRest = true)]
		string CalculatedName { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_Range, MemberType = ClientCallableComMemberType.PropertyGet)]
		[ClientCallableOperation(OperationType = OperationType.Read, InvalidateReturnObjectPathAfterRequest = true, WacAsync = true, WacName="GetRange")]
		Range Range(string address);

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_NullRange)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		Range NullRange(string address);

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_NullChart)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		Chart NullChart(string address);

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_SomeRangeOperation)]
		[ClientCallableOperation(WacAsync = true)]
		string SomeRangeOperation(string input, Range range);

		[ClientCallableComMember(DispatchId = DispatchIds.Worksheet_RestOnly)]
		[ClientCallableOperation(OperationType = OperationType.Read, RESTfulName = "RestOnlyOperation")]
		string _RestOnly();

		}

	[ClientCallableType(HiddenIndexerMethod = true, CreateItemOperationName = "Add")]
	[ClientCallableComType(Name = "IWorksheetCollection", InterfaceId = "55a36c77-3310-4afb-aa64-3c1a685f2f50", CoClassName = "WorksheetCollection", SupportEnumeration = true)]
	public interface WorksheetCollection: IEnumerable<Worksheet>
	{
		[ClientCallableComMember(DispatchId = DispatchIds.WorksheetCollection_Indexer)]
		Worksheet this[object index] { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.WorksheetCollection_Add)]
		Worksheet Add(string name);

		[ClientCallableComMember(DispatchId = DispatchIds.WorksheetCollection_GetItem)]
		Worksheet GetItem(object index);

		[ClientCallableComMember(DispatchId = DispatchIds.WorksheetCollection_FindSheet)]
		[ClientCallableOperation(WacAsync = true, OperationType = OperationType.Read)]
		Worksheet FindSheet(string text);

		[ClientCallableOperation(OperationType = OperationType.Read, InvalidateReturnObjectPathAfterRequest = true)]
		[ClientCallableComMember(DispatchId = DispatchIds.WorksheetCollection_GetActiveWorksheetInvalidAfterRequest)]
		Worksheet GetActiveWorksheetInvalidAfterRequest();
	}

	[ClientCallableComType(Name = "IRange", InterfaceId = "906962e8-a18a-4cc9-9342-279f056bc293", CoClassName = "Range")]
	public interface Range
	{
		
		[ClientCallableComMember(DispatchId = DispatchIds.Range_ColumnIndex)]
		int ColumnIndex { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_RowIndex)]
		int RowIndex { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_Text)]
		string Text { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_TextArray)]
		string[][] TextArray { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_Value)]
		object Value { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_ValueArray)]
		object[][] ValueArray { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_ValueTypeArray)]
		RangeValueType[][] ValueTypes { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_LogText)]
		string LogText { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_ReferenceId)]
		string _ReferenceId { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_Activate)]
		void Activate();

		[ClientCallableComMember(DispatchId = DispatchIds.Range_ReplaceValue)]
		object ReplaceValue(object newValue);

		[ClientCallableComMember(DispatchId = DispatchIds.Range_KeepReference)]
		[ClientCallableOperation(OperationType = OperationType.Read)]
		void _KeepReference();

		[ClientCallableComMember(DispatchId = DispatchIds.Range_ValueArray2)]
		[TypeScriptType("Array<string>")]
		object ValueArray2 { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.Range_GetValueArray2)]
		[return: TypeScriptType("Array<string>")]
		object GetValueArray2();

		[ClientCallableComMember(DispatchId = DispatchIds.Range_SetValueArray2)]
		void SetValueArray2(
			[TypeScriptType("Array<string>")]
			object valueArray, 
			string text);

		[ClientCallableComMember(DispatchId = DispatchIds.Range_OnAccess)]
		void _OnAccess();

		[ClientCallableComMember(DispatchId = DispatchIds.Range_NotRestMethod)]
		[ClientCallableOperation(OperationType = OperationType.Read, RESTfulName = "")]
		int NotRestMethod();

		[ClientCallableComMember(DispatchId = DispatchIds.Range_Sort)]
		RangeSort Sort { get; }
	}

	[ClientCallableComType(Name = "ITestCaseObject", InterfaceId = "53984705-84a6-4393-87f3-a118cc7bb047", CoClassName = "TestCaseObject", CoClassId = "4c4fd77f-8fb3-4e12-a796-84fde62d4eda")]
	public interface TestCaseObject
	{
		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_CalculateAddressAndSaveToRange)]
		string CalculateAddressAndSaveToRange(string street, string city, Range range);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestParamBool)]
		bool TestParamBool(bool value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestParamInt)]
		int TestParamInt([Optional] int value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestParamDouble)]
		double TestParamDouble(double value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestParamFloat)]
		float TestParamFloat(float value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestParamString)]
		string TestParamString([Optional] string value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestParamRange)]
		Range TestParamRange(Range value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestUrlKeyValueDecode)]
		string TestUrlKeyValueDecode(string value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_TestUrlPathEncode)]
		string TestUrlPathEncode(string value);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_Sum)]
		double Sum(params object[] values);

		[ClientCallableComMember(DispatchId = DispatchIds.TestCaseObject_MatrixSum)]
		double MatrixSum(object[][] matrix);
	}

	[ClientCallableComType(Name = "IRangeSort", InterfaceId = "b0eb6d54-c934-479c-974c-bf872c924656", CoClassName = "RangeSort")]
	public interface RangeSort
	{
		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_Fields)]
		SortField[] Fields { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_Fields2)]
		[KnownType(typeof(SortField))]
		object[] Fields2 { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_QueryField)]
		QueryWithSortField QueryField { get; }

		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_Apply)]
		string Apply(SortField[] fields);

		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_ApplyMixed)]
		int ApplyMixed([KnownType(typeof(SortField))] object[] fields);

		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_ApplyAndReturnFirstField)]
		SortField ApplyAndReturnFirstField(SortField[] fields);

		[ClientCallableComMember(DispatchId = DispatchIds.RangeSort_ApplyQueryWithSortField)]
		QueryWithSortField ApplyQueryWithSortFieldAndReturnLast(QueryWithSortField[] fields);
	}

	[ClientCallableComType(Name = "ISortField", InterfaceId = "337ff52d-6bd6-47b6-8047-d1a57f5abed4", CoClassName = "SortField", CoClassId = "8c274050-f0bd-4ac1-8a1f-3b67ffd4c29d")]
	public struct SortField
	{
		[ClientCallableComMember(DispatchId = DispatchIds.SortField_ColumnIndex)]
		int ColumnIndex { get; set; }
		[ClientCallableComMember(DispatchId = DispatchIds.SortField_Assending)]
		bool Assending { get; set; }

		[ClientCallableComMember(DispatchId = DispatchIds.SortField_UseCurrentCulture)]
		[Optional]
		bool UseCurrentCulture { get; set; }
	}

	[ApiSet(Version = 1.2)]
	[ClientCallableComType(Name = "IQueryWithSortField", InterfaceId = "a4576ceb-16eb-42aa-9c96-ff9221db7699", CoClassName = "QueryWithSortField", CoClassId = "5267b183-56a2-4cc3-a0a1-5511e9564024")]
	public struct QueryWithSortField
	{
		[ClientCallableComMember(DispatchId = DispatchIds.QueryWithSortField_RowLimit)]
		int RowLimit { get; set; }
		[ClientCallableComMember(DispatchId = DispatchIds.QueryWithSortField_Field)]
		SortField Field { get; set; }
	}
}
