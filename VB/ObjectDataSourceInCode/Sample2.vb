﻿Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Linq

Namespace ObjectDataSourceInCode.Sample2

    ' This sample demonstrates how to bind a report to the data that an object's property exposes. This data is filtered by the object constructor's parameters.
    Public Class CodeSample

        Public Shared Function CreateReport() As XtraReport

            Dim objectDS = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource() With { _
                .Name = "ObjectDataSource1", _
                .Constructor = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo(New DevExpress.DataAccess.ObjectBinding.Parameter("parameter1", GetType(DevExpress.DataAccess.Expression), New DevExpress.DataAccess.Expression("?reportParameter1", GetType(Integer))), New DevExpress.DataAccess.ObjectBinding.Parameter("parameter2", GetType(Integer), 5)), _
                .DataMember = "Items", _
                .DataSource = GetType(DataModel) _
            }

            Dim report = New XtraReport() With { _
                .Bands = { _
                    New TopMarginBand() With {.Name = "TopMargin"}, _
                    New DetailBand() With { _
                        .Name = "Detail", _
                        .Controls = { _
                            New XRLabel() With { _
                                .Name = "label1", .ExpressionBindings = { New ExpressionBinding("Text", "[Name]") }, _
                                .Size = New System.Drawing.Size(100, 23) _
                            } _
                        } _
                        _
                    }, _
                    New BottomMarginBand() With {.Name = "BottomMargin"} _
                }, _
                .Parameters = { _
                    New DevExpress.XtraReports.Parameters.Parameter() With { _
                        .Name = "reportParameter1", _
                        .Type = GetType(Integer), _
                        .Value = 10 _
                    } _
                }, _
                _
                .DataSource = objectDS _
            }

            Return report
        End Function
    End Class
    Public Class DataModel
        Public Property Items() As List(Of DataItem)
        Public Sub New(ByVal parameter1 As Integer, ByVal parameter2 As Integer)
            Items = New List(Of DataItem)(Enumerable.Range(parameter1, parameter2).Select(Function(item) New DataItem() With {.Name = "Name " & item}))
        End Sub
    End Class
    Public Class DataItem
        Public Property Name() As String
    End Class
End Namespace
