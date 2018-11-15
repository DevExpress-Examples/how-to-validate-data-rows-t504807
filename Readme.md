<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/App6/MainPage.xaml)
* **[MainPage.xaml.cs](./CS/App6/MainPage.xaml.cs)**
* [MainViewModel.cs](./CS/App6/MainViewModel.cs)
<!-- default file list end -->
# How to validate data rows


<p>This example shows how to check the validity of data entered by end-users into a data row. The <strong>ValidateRow</strong> and <strong>InvalidRowException</strong> events are handled to validate the focused row's data, and if it is invalid, prevent the row focus from being moved to another row until invalid values are corrected. </p>
<p><br>In this example, a Task's StartDate must be less than EndDate and if you try to change data item values so this condition is not met, the corresponding message will be shown.</p>

<br/>


