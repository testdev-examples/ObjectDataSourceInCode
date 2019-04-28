using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;

namespace ObjectDataSourceInCode.Sample4
{

    // This sample demonstrates how to bind a report to the data that an object's method exposes. This data is filtered by the method's parameters.
    public class CodeSample {
        public static XtraReport CreateReport() {

            var objectDS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource() {
                Name = "ObjectDataSource1",
                Parameters = {
                    new DevExpress.DataAccess.ObjectBinding.Parameter(
                        "parameter1",
                        typeof(DevExpress.DataAccess.Expression), 
                        new DevExpress.DataAccess.Expression("?reportParameter1", typeof(int))),
                    
                    new DevExpress.DataAccess.ObjectBinding.Parameter(
                        "parameter2",
                        typeof(int),
                        5)
                },
                DataMember = "GetData",
                DataSource = typeof(DataModel),
            };

            var report = new XtraReport() {
                Bands = {
                    new TopMarginBand() { Name = "TopMargin" },
                    new DetailBand() {
                        Name = "Detail",
                        Controls = {
                            new XRLabel() { 
                                Name = "label1",
                                ExpressionBindings = { new ExpressionBinding("Text", "[Name]") },
                                Size = new System.Drawing.Size(100, 23)
                            },
                        }
                    },
                    new BottomMarginBand() { Name = "BottomMargin" },
                },
                Parameters = {
                    new DevExpress.XtraReports.Parameters.Parameter() {
                        Name = "reportParameter1",
                        Type = typeof(int),
                        Value = 10
                    }
                },
                DataSource = objectDS
            };

            return report;
        }
    }
    public class DataModel {
        public static List<DataItem> GetData(int parameter1, int parameter2) {
            return new List<DataItem>(
                Enumerable.Range(parameter1, parameter2).Select(item => new DataItem() { Name = "Name " + item })
            );
        }
    }
    public class DataItem {
        public string Name { get; set; }
    }
}
