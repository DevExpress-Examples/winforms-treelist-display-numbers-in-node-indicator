<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637503/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E741)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms TreeList - Display numbers within node indicator cells

This example handles the [CustomDrawNodeIndicator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CustomDrawNodeIndicator) event to display numbers within [node indicator cells](https://docs.devexpress.com/WindowsForms/1069/controls-and-libraries/tree-list/visual-elements/node-indicator-panel):

```csharp
private void treeList1_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e) {
    TreeList tree = sender as DevExpress.XtraTreeList.TreeList;
    IndicatorObjectInfoArgs args = e.ObjectArgs as IndicatorObjectInfoArgs;
    args.DisplayText = (tree.GetVisibleIndexByNode(e.Node) + 1).ToString();
    e.ImageIndex = -1;
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-display-numbers-in-node-indicator&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-display-numbers-in-node-indicator&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
