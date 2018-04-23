using DevExpress.XtraBars.Ribbon;

namespace Dashboard_AggrSalesByMonths {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"..\..\Data\PercentOfTotal.xml");
        }
    }
}
