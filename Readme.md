<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581018/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T372347)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_AggrPercentOfTotal/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_AggrPercentOfTotal/Form1.vb))
<!-- default file list end -->
# Dashboard for WinForms - How to Calculate the Contribution of Quarterly Sales to Total Yearly Sales.


This example shows how to calculate a contribution of individual quarter sales to the grand total sales.

## Example Structure

In this example, the [Pivot](https://docs.devexpress.com/Dashboard/15266/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/pivot) dashboard item displays the sum of sales by year/quarter. The Sales field is placed in the [Values](https://docs.devexpress.com/Dashboard/15456/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/pivot/providing-data) section and the hierarchy of OrderDate fields (with the Year and Quarter [group intervals](https://docs.devexpress.com/Dashboard/15693/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/data-shaping/grouping)) is placed in [Rows](https://docs.devexpress.com/Dashboard/15456/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/pivot/providing-data).

![screenshot](/images/aggr_example2_salesbyquarteryear122821.png)

The following expressions calculate quarterly sales as a percentage of total sales:

| Calculated Field | Expression |
| --- | --- |
| Grand Total Sales | ``` aggr(Sum([Sales])) ``` |
| Percent of Grand Total | ``` Sum([Sales]) / Sum([Grand Total Sales]) ``` |

The following screenshot demonstrates the final result:

![screenshot](/images/aggr_example2_salesbyquarteryear_percentoftotal122822.png)

## Documentation

- [Intermediate Level Aggregations](https://docs.devexpress.com/Dashboard/115870/)
- [Aggregations](https://docs.devexpress.com/Dashboard/115894/)
- [Expression Constants, Operators, and Functions](https://docs.devexpress.com/Dashboard/400122/)

## More Examples

- [Dashboard for WinForms - How to display best and worst monthly sales for each year](https://github.com/DevExpress-Examples/how-to-display-best-and-worst-monthly-sales-for-each-year-t369371)
- [Dashboard for WinForms - How to evaluate a customer acquisition using the quarter/year of their first purchase](https://github.com/DevExpress-Examples/how-to-divide-customers-count-by-the-number-of-orders-they-made-t372356)
- [Dashboard for WinForms - How to divide customers' count by the number of orders they made](https://github.com/DevExpress-Examples/how-to-divide-customers-count-by-the-number-of-orders-they-made-t372356)
- [Dashboard for WinForms - How to calculate Highest Product Sales by Year](https://github.com/DevExpress-Examples/how-to-show-products-with-the-best-sales-in-a-year-along-with-sales-values-t372408)
- [Dashboard for WinForms - How to display sales by years in comparison with the previous year's sales](https://github.com/DevExpress-Examples/win-dashboard-display-previous-year-sales)
- [Dashboard for WinForms - How to Display Product Sales that are Greater than $20k](https://github.com/DevExpress-Examples/How-to-Display-Product-Sales-that-are-Greater-than-20k)
- [Dashboard for WinForms - How to Display Products with Sales Greater than Average Sales per Category](https://github.com/DevExpress-Examples/How-to-Display-Product-with-Sales-Greater-than-Average-Sales-per-Category)
