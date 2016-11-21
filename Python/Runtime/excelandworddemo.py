import numbers
import runtime
import excel
import word
import datetime
import json
import exceldemolib
import worddemolib

if __name__ == "__main__":
    #set context to excel
    requestUrlAndHeaders = runtime.RequestUrlAndHeaderInfo();
    requestUrlAndHeaders.url = "http://localhost:8052";
    runtime.ClientRequestContext.defaultRequestUrlAndHeaders = requestUrlAndHeaders
    context = excel.RequestContext()
    print("Populating data");
    exceldemolib.ExcelDemoLib.populateData(context)
    print("Populated data");
    exceldemolib.ExcelDemoLib.analyzeData(context)
    print("Analyzed data")
    imageBase64 = exceldemolib.ExcelDemoLib.getChartImage(context)
    runtime.ClientRequestContext.defaultRequestUrlAndHeaders = None

    # switch context to word
    requestUrlAndHeaders = runtime.RequestUrlAndHeaderInfo();
    requestUrlAndHeaders.url = "http://localhost:8054";
    runtime.ClientRequestContext.defaultRequestUrlAndHeaders = requestUrlAndHeaders
    context = word.RequestContext()
    print("Insert image");
    worddemolib.WordDemoLib.insertPictureAtEnd(context, imageBase64)
    runtime.ClientRequestContext.defaultRequestUrlAndHeaders = None

