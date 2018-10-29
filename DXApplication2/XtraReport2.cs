using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DXApplication2
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport2()
        {
            InitializeComponent();
            xrBarCode1.Text = "名称：" + "设备" + Environment.NewLine + "内容：" + "安钢" + Environment.NewLine + "型号：" + "未知" + Environment.NewLine + "数量：" + "10";
        }

    }
}
