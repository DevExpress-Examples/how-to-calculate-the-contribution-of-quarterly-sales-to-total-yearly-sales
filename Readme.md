<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_AggrPercentOfTotal/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_AggrPercentOfTotal/Form1.vb))
<!-- default file list end -->
# How to Calculate the Contribution of Quarterly Sales to Total Yearly Sales.


This example shows how to calculate a contribution of individual quarter sales to the grand total sales.

## Example Structure

In this example, the [Pivot](https://docs.devexpress.com/Dashboard/15266/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/pivot) dashboard item displays the sum of sales by year/quarter. The Sales field is placed in the [Values](https://docs.devexpress.com/Dashboard/15456/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/pivot/providing-data) section and the hierarchy of OrderDate fields (with the Year and Quarter [group intervals](https://docs.devexpress.com/Dashboard/15693/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/data-shaping/grouping)) is placed in [Rows](https://docs.devexpress.com/Dashboard/15456/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/pivot/providing-data).

![screenshot](/images/aggr_example2_salesbyquarteryear122821.png)

The following expressions calculate quarterly sales as a percentage of total sales.

- Grand Total Sales:

```
 aggr(Sum([Sales]))
```

- Percent of Grand Total:

```
Sum([Sales]) / Sum([Grand Total Sales])
```

![screenshot](/images/aggr_example2_salesbyquarteryear_percentoftotal122822.png)
