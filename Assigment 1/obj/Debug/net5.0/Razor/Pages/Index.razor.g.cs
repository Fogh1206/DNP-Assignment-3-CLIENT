#pragma checksum "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e29675e634cc1d935b9e72123f8241f66f6c5ef"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Assigment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Assigment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><link rel=\"stylesheet\" href=\"css/bootstrap/bootstrap.min.css\">\r\n    <link rel=\"stylesheet\" href=\"css/custom/customCss.css\"></head>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container p-3 my-3");
            __builder.AddMarkupContent(3, "<h1>Add New Adult</h1>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 16 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
        ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form__group field");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "class", "form__field");
            __builder.AddAttribute(12, "placeholder", "fName");
            __builder.AddAttribute(13, "name", "fname");
            __builder.AddAttribute(14, "id", "fname");
            __builder.AddAttribute(15, "required");
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                   (e) => { FirstName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                            FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<label for=\"fname\" class=\"form__label\">First name:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form__group field");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form__field");
            __builder.AddAttribute(27, "placeholder", "lName");
            __builder.AddAttribute(28, "name", "lname");
            __builder.AddAttribute(29, "id", "lname");
            __builder.AddAttribute(30, "required");
            __builder.AddAttribute(31, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                  (e) => { LastName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                            LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<label for=\"lname\" class=\"form__label\">Last name:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form__group field");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form__field");
            __builder.AddAttribute(42, "placeholder", "hairColour");
            __builder.AddAttribute(43, "name", "hairColour");
            __builder.AddAttribute(44, "id", "hairColour");
            __builder.AddAttribute(45, "required");
            __builder.AddAttribute(46, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                                  (e) => { HairColor = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                           HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HairColor = __value, HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.AddMarkupContent(50, "<label for=\"hairColour\" class=\"form__label\">Hair colour:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form__group field");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form__field");
            __builder.AddAttribute(57, "placeholder", "eyeColour");
            __builder.AddAttribute(58, "name", "eyeColour");
            __builder.AddAttribute(59, "id", "eyeColour");
            __builder.AddAttribute(60, "required");
            __builder.AddAttribute(61, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                              (e) => { EyeColor = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                        EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EyeColor = __value, EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<label for=\"eyeColour\" class=\"form__label\">Eye colour:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form__group field");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "class", "form__field");
            __builder.AddAttribute(72, "placeholder", "age");
            __builder.AddAttribute(73, "name", "age");
            __builder.AddAttribute(74, "id", "age");
            __builder.AddAttribute(75, "required");
            __builder.AddAttribute(76, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                       (e) => { Age = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                      Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Age = __value, Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.AddMarkupContent(80, "<label for=\"age\" class=\"form__label\">Age:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "form__group field");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "class", "form__field");
            __builder.AddAttribute(87, "placeholder", "weight");
            __builder.AddAttribute(88, "name", "weight");
            __builder.AddAttribute(89, "id", "weight");
            __builder.AddAttribute(90, "required");
            __builder.AddAttribute(91, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                   (e) => { Weight = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                               Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Weight = __value, Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.AddMarkupContent(95, "<label for=\"weight\" class=\"form__label\">Weight:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form__group field");
            __builder.OpenElement(99, "input");
            __builder.AddAttribute(100, "type", "text");
            __builder.AddAttribute(101, "class", "form__field");
            __builder.AddAttribute(102, "placeholder", "height");
            __builder.AddAttribute(103, "name", "height");
            __builder.AddAttribute(104, "id", "height");
            __builder.AddAttribute(105, "required");
            __builder.AddAttribute(106, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                   (e) => { Height = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                               Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Height = __value, Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.AddMarkupContent(110, "<label for=\"height\" class=\"form__label\">Height:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form__group field");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "text");
            __builder.AddAttribute(116, "class", "form__field");
            __builder.AddAttribute(117, "placeholder", "sex");
            __builder.AddAttribute(118, "name", "sex");
            __builder.AddAttribute(119, "id", "sex");
            __builder.AddAttribute(120, "required");
            __builder.AddAttribute(121, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                       (e) => { Sex = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                      Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Sex = __value, Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.AddMarkupContent(125, "<label for=\"sex\" class=\"form__label\">Sex:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "form__group field");
            __builder.OpenElement(129, "input");
            __builder.AddAttribute(130, "type", "text");
            __builder.AddAttribute(131, "class", "form__field");
            __builder.AddAttribute(132, "placeholder", "jobTitle");
            __builder.AddAttribute(133, "name", "jobTitle");
            __builder.AddAttribute(134, "id", "jobTitle");
            __builder.AddAttribute(135, "required");
            __builder.AddAttribute(136, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                           (e) => { JobTitle = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                     JobTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => JobTitle = __value, JobTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.AddMarkupContent(140, "<label for=\"jobTitle\" class=\"form__label\">Job title:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n    ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "form__group field");
            __builder.OpenElement(144, "input");
            __builder.AddAttribute(145, "type", "text");
            __builder.AddAttribute(146, "class", "form__field");
            __builder.AddAttribute(147, "placeholder", "salary");
            __builder.AddAttribute(148, "name", "salary");
            __builder.AddAttribute(149, "id", "salary");
            __builder.AddAttribute(150, "required");
            __builder.AddAttribute(151, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                                                   (e) => { Salary = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                                                               Salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(153, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Salary = __value, Salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n        ");
            __builder.AddMarkupContent(155, "<label for=\"salary\" class=\"form__label\">Salary:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n    ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "wrap");
            __builder.OpenElement(159, "input");
            __builder.AddAttribute(160, "id", "submitButton");
            __builder.AddAttribute(161, "type", "submit");
            __builder.AddAttribute(162, "value", "Submit");
            __builder.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
                                                                        Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\Index.razor"
       
    public string ErrorMessage { get; set; }
    public IList<Adult> Adults { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Age { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Sex { get; set; }
    public string JobTitle { get; set; }
    public string Salary { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Adults = AdultService.AdultsList;
    }

    public void Edit()
    {
        if (Check(FirstName) || Check(LastName) || Check(Age) || Check(HairColor) || Check(EyeColor) || Check(Weight) || Check(Height))
        {
            ErrorMessage = "Please fill all fields";
        }
        else
        {
            Adult adult = new Adult
            {
                Id = Adults.Count,
                FirstName = FirstName,
                LastName = LastName,
                Age = Int32.Parse(Age),
                Height = Int32.Parse(Height),
                Weight = float.Parse(Weight),
                Sex = Sex,
                EyeColor = EyeColor,
                HairColor = HairColor,
            };
            if (!Check(JobTitle))
            {
                Job job = new Job
                {
                    JobTitle = JobTitle,
                    Salary = Int32.Parse(Salary)
                };
                adult.JobTitle = job;
            }
            else
            {
                Job job = new Job
                {
                    JobTitle = "Unemployed",
                    Salary = 0
                };
                adult.JobTitle = job;
            }

            Adults.Add(adult);
            AdultService.Save();
            NavigationManager.NavigateTo("/fetchdata");
        }
    }

    public bool Check(string s)
    {
        return (s == null || s == String.Empty) ? true : false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
