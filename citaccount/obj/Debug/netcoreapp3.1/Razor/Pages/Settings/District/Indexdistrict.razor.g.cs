#pragma checksum "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406df2b7d75492f33e04069097a07149ef1f6c56"
// <auto-generated/>
#pragma warning disable 1591
namespace citaccount.Pages.Settings.District
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\citaccount\citaccount\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\citaccount\citaccount\_Imports.razor"
using citaccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\citaccount\citaccount\_Imports.razor"
using citaccount.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\citaccount\citaccount\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
using citaccount.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
using citaccount.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/district")]
    public partial class Indexdistrict : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
 if (dis == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>ກຳລັງໂຫຼດຂໍ້ມູນ...</em></p>\r\n");
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<a class=\"btn btn-primary btn-sm\" href=\"/createdistrict\">ເພີ່ມໃໝ່</a>\r\n    ");
            __builder.OpenComponent<BlazorTable.Table<TblDistrict>>(4);
            __builder.AddAttribute(5, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblDistrict>>(
#nullable restore
#line 17 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                          dis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                         10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ShowSearchBar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblDistrict>>(11);
                __builder2.AddAttribute(12, "Title", "ຊື່ເມືອງ");
                __builder2.AddAttribute(13, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblDistrict, System.Object>>>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                  x=>x.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Width", "20%");
                __builder2.AddAttribute(17, "SetFooterValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                                                             TotalDistrictText

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblDistrict>>(19);
                __builder2.AddAttribute(20, "Title", "ຊື່ແຂວງ");
                __builder2.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblDistrict, System.Object>>>(
#nullable restore
#line 19 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                 x=>x.Pro.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Width", "60%");
                __builder2.AddAttribute(25, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.AggregateType?>(
#nullable restore
#line 19 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                                                          AggregateType.Count

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblDistrict>>(27);
                __builder2.AddAttribute(28, "Title", "Actions");
                __builder2.AddAttribute(29, "Width", "20%");
                __builder2.AddAttribute(30, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblDistrict>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n                ");
                    __builder3.OpenElement(32, "a");
                    __builder3.AddAttribute(33, "type", "button");
                    __builder3.AddAttribute(34, "class", "btn btn-primary btn-sm");
                    __builder3.AddAttribute(35, "href", "editdistrict/" + (
#nullable restore
#line 22 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                    context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(36, "ແກ້ໄຂ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __builder3.OpenElement(38, "a");
                    __builder3.AddAttribute(39, "type", "button");
                    __builder3.AddAttribute(40, "class", "btn btn-danger btn-sm");
                    __builder3.AddAttribute(41, "href", "deletedistrict/" + (
#nullable restore
#line 23 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                     context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(42, "ລຶບຂໍ້ມູນ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Pager>(45);
                __builder2.AddAttribute(46, "ShowPageNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ShowTotalCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.AddContent(50, "    ");
            __builder.OpenComponent<BlazorTable.Table<TblDistrict>>(51);
            __builder.AddAttribute(52, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblDistrict>>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                          dis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                         10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ColumnReorder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblDistrict>>(57);
                __builder2.AddAttribute(58, "Title", "ຊື່ແຂວງ");
                __builder2.AddAttribute(59, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblDistrict, System.Object>>>(
#nullable restore
#line 30 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                 x=>x.Pro.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "Width", "20%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.DetailTemplate<TblDistrict>>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<TblDistrict>)((contextDetail) => (__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<BlazorTable.Table<TblDistrict>>(67);
                    __builder3.AddAttribute(68, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblDistrict>>(
#nullable restore
#line 33 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                  dis

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(70, "\r\n                ");
                        __builder4.OpenComponent<BlazorTable.Column<TblDistrict>>(71);
                        __builder4.AddAttribute(72, "Title", "ຊື່ເມືອງ");
                        __builder4.AddAttribute(73, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblDistrict, System.Object>>>(
#nullable restore
#line 34 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                          x=>x.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(76, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 38 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Projects\citaccount\citaccount\Pages\Settings\District\Indexdistrict.razor"
       
    public string TotalDistrictText = "ລວມ:";
    List<TblDistrict> dis;
    protected override void OnInitialized()
    {
        dis = settingService.ShowAllDistrict();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SettingService settingService { get; set; }
    }
}
#pragma warning restore 1591
