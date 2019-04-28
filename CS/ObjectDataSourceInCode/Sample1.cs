using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;

namespace ObjectDataSourceInCode.Sample1 {
    public class CodeSample {

        // This sample demonstrates how to bind a report to the data that an object's property exposes
        public static XtraReport CreateReport() {

            var objectDS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource() {
                Name = "ObjectDataSource1",
                Constructor = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo(),
                DataMember = "Items",
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
                                Size = new System.Drawing.Size(100, 23),
                            }
                        }
                    },
                    new BottomMarginBand() { Name = "BottomMargin" },
                },
                DataSource = objectDS
            };

            return report;
        }
    }
    public class DataModel {
        public List<DataItem> Items { get; set; }
        public DataModel() {
            Items = new List<DataItem>(
                Enumerable.Range(3, 5).Select(item => new DataItem() { Name = "Name " + item })
            );
        }
    }
    public class DataItem {
        public string Name { get; set; }
    }
}
