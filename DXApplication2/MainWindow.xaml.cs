using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.XtraReports.UI;

namespace DXApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow ( )
        {
            InitializeComponent ( );
            barcode1.EditValue = "名称：" + "设备" + Environment.NewLine + "内容：" + "安钢" + Environment.NewLine + "型号：" + "未知" + Environment.NewLine + "数量：" + "10";
        }

        private void btnPrint_ItemClick ( object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e )
        {
            XtraReport1 report1 = new XtraReport1 ( );
            report1.Print ( );          
        }

        private void BarButtonItem_ItemClick ( object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e )
        {
            XtraReport1 report1 = new XtraReport1 ( );
            ReportPrintTool rpt = new ReportPrintTool ( report1);
            rpt.ShowPreviewDialog();
        }

        private void btnCodePrint_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {          
            XtraReport2 report2 = new XtraReport2();
            report2.Print();
        }
    }
}
